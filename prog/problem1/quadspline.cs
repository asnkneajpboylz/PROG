using System;
using System.Diagnostics;
using static System.Console;
public class quadspline{

	double[] x,y,p,c;

	public static int binsearch(double[] x, double z) {
		int i=0;
		int j=x.Length-1;
		while(j-i>1) {
			int sep=(i+j)/2;
			if (z>x[sep]) i=sep;
			else j=sep;
			}
		return i;
	}	

	public quadspline(double[] xs, double[] ys){
		int n=xs.Length; Trace.Assert(ys.Length >=n);
		x=new double[n];
		y=new double[n];
		p=new double[n-1];
		c=new double[n-1];
		for(int i=0; i<n;i++) {x[i]=xs[i]; y[i]=ys[i];}
		for(int i=0; i<(n-1);i++) {
			p[i]=(y[i+1]-y[i])/(x[i+1]-x[i]);
		}
		c[n-2]=0;
	for(int i=n-3;i>=0;i--){
		c[i]=(p[i+1]-p[i]-c[i+1]*(x[i+2]-x[i+1]))/(x[i+1]-x[i]);	
	}}

	public double eval(double z) {
		Trace.Assert(z >= x[0] && z<= x[x.Length-1]);
		int i=binsearch(x,z);
		return y[i] + (z-x[i])*p[i]+c[i]*(z-x[i])*(z-x[i+1]);
	}

	public double integ(double z) {
		Trace.Assert(z>=x[0] && z<=x[x.Length-1]);
		int iz=binsearch(x,z);
		double sum=0;
		double dx=0;
		for(int i=0; i<iz;i++) {
			Trace.Assert(x[i+1]<z);
			dx=x[i+1]-x[i];
			sum=sum+y[i]*dx+p[i]*dx*dx/2+c[i]*dx*dx*dx/3;
		}
		dx=z-x[iz];
		sum=sum+y[iz]*dx+p[iz]*dx*dx/2+c[iz]*dx*dx*dx/3;
		return sum;
	}	

	public double derive(double z) {
		int iz=binsearch(x,z);		
		double sum= p[iz]+2*c[iz]*(z-x[iz]);
		return sum;}
	


}
