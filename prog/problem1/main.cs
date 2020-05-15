using System;
using static System.Console;
using static System.Math;
class main{
	static int Main(){

		int n=40;
		int N=100;
		double[] x=new double[n];
		double[] y=new double[n];
		int i;
//change 
		for(i=0;i<n;i++){
			x[i]=2*PI*i/(n-1);
			y[i]=Sin(x[i]);
			//WriteLine("equidistant points of sine {0:g6} {1:g6}", x[i],y[i]);
		}

		Write("\n");
		var cs=new cspline(x,y);
		var quads=new quadspline(x,y);
		double z=x[0];
	        double step=(x[n-1]-x[0])/(N-1);
		for(i=0; i<N;i++){
			z=x[0]+i*step;
			WriteLine($"{z} {cs.eval(z)} {cs.integ(z)} {quads.eval(z)} {quads.integ(z)} {quads.derive(z)}");
		}
		
	//	Write($"test integration of sine from 0 to 2pi: {cs.integ(2*PI)}\n");
	//	Write($"evaluate interpol sin at pi/2, pi: {cs.eval(PI/2)} {cs.eval(PI)}\n");
	return 0;}
}
