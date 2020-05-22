using System;
using static System.Math;
using static System.Console;

public class main{
static int Main(){
	int eval=0;
	double a=0;
	double b=1;
	double acc=0.0001;
	double eps=0.0001;

	Func<double, double> g1=(x) => {eval++; return Sqrt(x);};
	vector result1=integ.integr(g1,a,b,acc,eps);
	WriteLine("Problem A: Integration sqrt(x) from 0 to 1:");
	WriteLine($"result: {result1[0]} with {eval} evaluations, exact result {2.0/3}");

	eval=0;
	Func<double,double> g2=(x) => {eval++; return 4*Sqrt(1-x*x);};
	vector result2=integ.integr(g2,a,b,acc,eps);
	WriteLine("Problem B: Integration 4*sqrt(1-x*x) from 0 to 1:");
	WriteLine($"result: {result2[0]} with {eval} evaluations, exact result {PI}");


return 0;}
}
