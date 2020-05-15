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
	vector y=new vector(n);
	vector c=new vector(m);
	matrix A=new matrix(n,m);
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
	c=QR.qr_qs_solve(Q,R,y);
	for(double i=0;i<20;i=i+0.1) WriteLine($"{i} {Exp(c[0])*Exp(c[1]*i)}");
	//b.print($"b");
	c.print($"solution x");
	WriteLine($"N0={Exp(c[0])}");
	WriteLine($"lambda={c[1]}");
	WriteLine($"The half life time calculated via the fitting function is ln(2)/lambda= {Log(2)/-c[1]} days");
	WriteLine("The actual half life time is 3.6 days.");
	//(A*c).print("check Ax~b");
	return 0;}	
}
