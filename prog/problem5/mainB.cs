using System;
using static System.Math;
using static System.Console;
using System.Collections.Generic;

public class main{
public static void Main(){
	int N= 5500000;
	double Tc=5;//one person infects 3 
	double Tr=15;//contagiousness lasts 15 days
	int a=0;
	int b=90;
	double eps=0.01;
	double acc=0.01;

	Func<double, vector,vector> f= (x,y) => {return new vector(-y[1]*y[0]*1/(N*Tc),y[1]*y[0]/(N*Tc) - y[1]/Tr, y[1]/Tr);};
	List<double> xs = new List<double>();
	List<vector> ys = new List<vector>();
	vector ya=new vector(5490000,978,9643);
	ode.rk12(f,a,ya,b,xlist:xs,ylist:ys,acc:acc,eps:eps);
	int c = xs.Count;
	for(int i=0;i<c;i++)
	{WriteLine($"{xs[i]} {ys[i][0]} {ys[i][1]} {ys[i][2]}");}
}
}
