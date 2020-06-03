using System;
using static System.Math;
using static System.Console;
class main{

static int Main(){
	//public Func<double,double>[] f;
	int n=8;
       	int m=2;
	matrix R=new matrix(m,m);
	matrix Q=new matrix(n,m);
	vector c=new vector(m);
	vector y=new vector(n);
	matrix A=new matrix(n,m);
	matrix B=new matrix(m,n);
	matrix sigma=new matrix(m,m);
	Func<double,double>[] f= {t =>1,t => t};
	vector b=new vector(new double []{117,100,88,72,53,29.5,25.2,15.2,11.1});
	var dy=0.05*b;
	vector x=new vector(new double []{1,2,3,4,6,9,10,13,15});
	for(int i=0; i<n;i++) {
		y[i]=Log(b[i]);
		y[i]=y[i]/0.05;
		dy[i]=dy[i]/b[i];}
	for(int i=0;i<n; i++){
		for(int k=0;k<m;k++){
		A[i,k]=f[k](x[i])/dy[i];
		Q[i,k]=A[i,k];
		}
	}
	
	//A.print($"matrix A: ");
	QR.qr_gs_decomp(Q, R);
	c=QR.qr_qs_solve(Q,R,y);//coeff
	B=QR.inverse(Q,R);
	sigma=B*B.T;
	vector delta=new vector(m);//delta are uncertainties of coeff
	for(int i=0;i<m;i++) delta[i]=Sqrt(sigma[i,i]);

	for(double i=0;i<20;i=i+0.1) WriteLine($"{i} {Exp(c[0])*Exp(c[1]*i)}");

	c.print($"solution x");
	Error.WriteLine($"N0={Exp(c[0])}");
	Error.WriteLine($"lambda={c[1]}");
	Error.WriteLine($"The half life time calculated via the fitting function is ln(2)/lambda= {Log(2)/-c[1]:f1} days");
	Error.WriteLine("The actual half life time is 3.6 days.");
	//(A*c).print("check Ax~b");

	//B 
	double unc=Log(2)/(c[1]*c[1])*delta[1];
	Error.WriteLine($"Uncertainty for estimated halflife: {unc:f1} days");
	Error.WriteLine($"The estimated value doesn't agree with the modern value");

	return 0;}	
}
