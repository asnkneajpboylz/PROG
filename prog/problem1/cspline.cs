using System;
using System.Diagnostics;
public class cspline{

	double[] x,y,a,b;

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

	public cspline(double[] xs, double[] ys){
		int n=xs.Length; Trace.Assert(ys.Length >=n);
		x=new double[n];
		y=new double[n];
		a=new double[n-1];
		b=new double[n-1];
		for(int i=0; i<n;i++) {x[i]=xs[i]; y[i]=ys[i];}
	
		for(int i=0; i<(n-1);i++) {
			a[i]=y[i];
			b[i]=(y[i+1]-y[i])/(x[i+1]-x[i]);
		}	
	}

	public double eval(double z) {
		Trace.Assert(z >= x[0] && z<= x[x.Length-1]);
		int i=binsearch(x,z);
		return a[i] + (z-x[i])*b[i];
	}

	public double integ(double z) {
		Trace.Assert(z>=x[0] && z<=x[x.Length-1]);
		int iz=binsearch(x,z);
		double sum=0;
		
		for( int i=0; i<iz;i++) {
			Trace.Assert(x[i+1]<z);
			sum=sum+y[i]*(x[i+1]-x[i])+1.0/2*b[i]*(x[i+1]-x[i])*(x[i+1]-x[i]);
			
		}
		sum=sum+y[iz]*(z-x[iz])+0.5*b[iz]*(z-x[iz])*(z-x[iz]);
		return sum;
	}	


}
