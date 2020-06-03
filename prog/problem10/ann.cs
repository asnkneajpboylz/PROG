using System;
using static System.Math;

public class ann{
	public int n;
	public Func<double,double> f= (x) => {return x*Exp(-x*x);};
	public Func<double,double> fd=(x) => {return Exp(-x*x)*(1-2*x*x);};
	public Func<double,double> fi=(x) => {return -1.0/2*Exp(-x*x);};	
	public vector paramet;
	
	public ann(int nod){
		n=nod;
	 	paramet=new vector(3*n);
	}	

	public double feedforward(double x, vector parameters = null){
	if(parameters == null) parameters=paramet;
	double sumN=0;
	for(int i=0; i<n;i++){
		double ai=parameters[0+3*i];
		double bi=parameters[1+3*i];
		double wi=parameters[2+3*i];
		sumN+=wi*f((x-ai)/bi);
		}
	return sumN;
	}

	public void train(vector x, vector y){
		Func<vector,double> delta= (z) => {
		double sum=0;
		for(int i=0; i<x.size;i++)sum+=Pow(feedforward(x[i],z)-y[i],2);
		return sum/x.size;};
		//vector p=paramet;
		vector p=newton.qnewton(delta, paramet, 1e-6);//minimization
		paramet=p;
	}
	
	public double feed_int(double x, double xlow, vector parameters=null){
	if(parameters == null) parameters=paramet;
	double sumN=0;
	double lowsum=0;
	for(int i=0; i<n;i++){
		double ai=parameters[0+3*i];
		double bi=parameters[1+3*i];
		double wi=parameters[2+3*i];
		sumN+=wi*fi((x-ai)/bi)*bi;
		lowsum+=wi*fi((xlow-ai)/bi)*bi;
		}
	return sumN-lowsum;}

	public double feed_dif(double x, vector parameters=null){
	if(parameters == null) parameters=paramet;
	double sumN=0;
	for(int i=0; i<n;i++){
		double ai=parameters[0+3*i];
		double bi=parameters[1+3*i];
		double wi=parameters[2+3*i];
		sumN+=wi*fd((x-ai)/bi)/bi;//chain rule
		}
	return sumN;
	}

}
