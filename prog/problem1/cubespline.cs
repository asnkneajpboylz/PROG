using System;
using static System.Math;
using System.Diagnostics;
using static System.Console;
public class cubespline{

	double[] x,y,b,c,d;

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

	public cubespline(double[] xs, double[] ys){
		int n=xs.Length; 
		Trace.Assert(ys.Length >=n);
		x=new double[n];
		y=new double[n];
		b=new double[n];
		c=new double[n-1];
		d=new double[n-1];
		for(int i=0; i<n;i++) {x[i]=xs[i]; y[i]=ys[i];}
		double[] h=new double[n-1];
		double[] p=new double[n-1];
		double[] D=new double[n];
		double[] Q=new double[n-1];
		double[] B=new double[n];
		for(int i=0; i<(n-1);i++) {
			h[i]=x[i+1]-x[i];
			p[i]=(y[i+1]-y[i])/h[i];
		}
		D[0]=2;
		D[n-1]=2;
		Q[0]=1;
		B[0]=3*p[0];
		B[n-1]=3*p[n-2];
		
		for(int i=0;i<n-2;i++){
			D[i+1]=2*(h[i]/h[i+1] +1);
			Q[i+1]=h[i]/h[i+1];
			B[i+1]=3*(p[i]+p[i+1]*h[i]/h[i+1]);
		}
		for(int i=1; i<n;i++){
			D[i]=D[i]-Q[i-1]/D[i-1];
			B[i]=B[i]-B[i-1]/D[i-1];
		}
		b[n-1]=B[n-1]/D[n-1];
		for(int i=n-2; i>=0;i--){
			b[i]=(B[i]-Q[i]*b[i+1])/D[i];
		}
		for(int i=0;i<n-1;i++){
			c[i]=(-2*b[i]-b[i+1]+3*p[i])/h[i];
			d[i]=(b[i]+b[i+1]-2*p[i])/Pow(h[i],2);
			
		}
	}

	public double eval(double z) {
		Trace.Assert(z >= x[0] && z<= x[x.Length-1]);
		int i=binsearch(x,z);
		double m= z-x[i];
		return y[i] + m*b[i]+m*m*c[i]+m*m*m*d[i];
	}

	public double integ(double z) {
		Trace.Assert(z>=x[0] && z<=x[x.Length-1]);
		int iz=binsearch(x,z);
		double sum=0;
		double dx=0;
		for(int i=0; i<iz;i++) {
			Trace.Assert(x[i+1]<z);
			dx=x[i+1]-x[i];
			sum=sum+y[i]*dx+b[i]*dx*dx/2+c[i]*Pow(dx,3)/3+d[i]/4*Pow(dx,4);
		}
		dx=z-x[iz];
		sum=sum+y[iz]*dx+b[iz]*dx*dx/2+c[iz]*Pow(dx,3)/3+d[iz]/4*Pow(dx,4);
		return sum;
	}	

	public double derive(double z) {
		int iz=binsearch(x,z);		
		double m=z-x[iz];
		double res= b[iz]+2*m*c[iz]+m*m*3*d[iz];
		return res;}
	


}
