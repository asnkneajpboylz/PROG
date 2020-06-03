using System;
using static System.Math;
using static System.Console;
public class main{


	public static vector E = new vector(new double[]{101,103,105,107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,159});
	public static vector sig = new vector(new double[]{-0.25,-0.3,-0.15,-1.71,0.81,0.65,-0.91,0.91,0.96,-2.52,-1.01,2.01,4.83,4.58,1.26,1.01,-1.26,0.45,0.15,-0.91,-0.81,-1.41,1.36,0.5,-0.45,1.61,-2.21,-1.86,1.76,-0.5});
	public static vector err = new vector(new double[]{2.0,2.0,1.9,1.9,1.9,1.9,1.9,1.9,1.6,1.6,1.6,1.6,1.6,1.6,1.3,1.3,1.3,1.3,1.3,1.3,1.1,1.1,1.1,1.1,1.1,1.1,1.1,0.9,0.9,0.9});
	
public static void Main(){
	vector param=new vector(127,1,1);//starting values mass,A,Gamma
	double eps=1e-3;
	param=newton.qnewton(devfun,param,eps);
	double m=param[0];
	double A=param[2];
	double G=param[1];
	WriteLine($"mass={m}, Gamma={G}, Sqrt(chi^2/n)={Sqrt(devfun(param)/30)}");
	
	for(double en=E[0];en<=E[29];en+=0.5) Error.WriteLine($"{en} {A/((en-m)*(en-m)+G*G/4)}");
}
static double devfun(vector x){
	double m=x[0];
	double A=x[2];
	double G=x[1];
	double sum=0;
	for(int i=0;i<30;i++){
	sum+=Pow(A/((E[i]-m)*(E[i]-m)+G*G/4)-sig[i],2)/err[i]/err[i];}
	return sum;
}
}
