using System;
using static System.Math;
using static System.Console;

public class main{
public static void Main(){	
	int N=100;
	double[] evalvec=new double[N];
	double[] x=new double[]{0,1,2,4,6,7,8};
	double[] y=new double[]{0,0,0,0.5,1,1,1};
	int n=x.Length;
	for(int i=0; i<n;i++){
		Error.WriteLine($"{x[i]} {y[i]}");
	}
	
	var aki=new akima(x,y);
	double z=x[0];
	double step=(x[n-1]-x[0])/(N-1);
	for(int i=0;i<N;i++){
		z=x[0]+i*step;
		evalvec[i]=aki.eval(z);
		WriteLine($"{z} {evalvec[i]}");
	}

		




}
}
