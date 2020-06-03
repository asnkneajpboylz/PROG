using System;
using static System.Math;
using static System.Console;
using System.Diagnostics;

public class akima{

	double[] b,c,d,x,y;

	public static int binsearch(double[] x, double z){
		int i=0;
		int j=x.Length-1;
		while(j-i>1) {
			int half=(i+j)/2;
			if (z>x[half])i=half;
			else j=half;
		}
		return i;
	}

	public akima(double[] xs,double[] ys){
		int n=xs.Length;
		double[] p=new double[n-1];
		double[] w=new double[n-2];
		double[] AAdif=new double[n];
		b=new double[n];
		c=new double[n-1];
		d=new double[n-1];
		x=new double[n];
		y=new double[n];
		for(int i=0; i<n;i++){
			 x[i]=xs[i];
			 y[i]=ys[i];}
		for(int i=0; i<n-1;i++)	p[i]=(y[i+1]-y[i])/(x[i+1]-x[i]);
		for(int i=0; i<n-2;i++) w[i]=Abs(p[i+1]-p[i]);
		AAdif[0]=p[0];
		AAdif[1]=0.5*(p[0]+p[1]);
		AAdif[n-2]=0.5*(p[n-2]+p[n-3]);
		AAdif[n-1]=p[n-2];
		for(int i=1;i<n-3;i++){
			if (w[i+1]+w[i-1]==0) AAdif[i+1]=0.5*(p[i]+p[i+1]);
			else AAdif[i+1]=(w[i+1]*p[i]+w[i-1]*p[i+1])/(w[i+1]+w[i-1]);
		}
		
		b[n-1]=AAdif[n-1];
		for(int i=0;i<=n-2;i++){
			b[i]=AAdif[i];//for a[i]=y[i] we take y[i]
			c[i]=(3*p[i]-2*AAdif[i]-AAdif[i+1])/(x[i+1]-x[i]);
			d[i]=(AAdif[i]+AAdif[i+1]-2*p[i])/Pow(x[i+1]-x[i],2);
		}
	}//constructor 

	public double eval(double z){
		Trace.Assert(z>= x[0] && z<= x[x.Length-1]);
		int i=binsearch(x,z);
		double m=z-x[i];
		return y[i]+m*b[i]+Pow(m,2)*c[i]+Pow(m,3)*d[i];
	}
}
