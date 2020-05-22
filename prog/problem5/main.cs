using static System.Console;
using static System.Math;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
static class main{
	static void Main(){
	double ya0 =1 ;
	double ya1 =0;
	double a = 0;
	double b =100 ;
	double acc = 1e-3, eps = 1e-3;
	vector ya = new vector(ya0,ya1);
	Func<double,vector,vector> diff_eq=(x,y) => new vector(-y[1],y[0]);
	
	List<double> xs = new List<double>();
	List<vector> ys = new List<vector>();
	ode.rk12(diff_eq,a,ya,b,xlist:xs,ylist:ys,acc:acc,eps:eps);
	int N = xs.Count;
	for(int i=0;i<N;i++)
	WriteLine($"{xs[i]} {ys[i][0]} {ys[i][1]}");
	Write("\n \n");
        							
} 
}

