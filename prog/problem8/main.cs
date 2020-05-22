using System;
using static System.Math;
using static System.Console;

public class main{
public static void Main(){
	double eps=1e-5;
	double res=0;
	Func<vector,double> Rosen= (x) => {return res=Pow(1-x[0],2)+100*Pow(x[1]-x[0]*x[0],2);};
	Func<vector,double> Himmel=(x) => {return res=Pow(Pow(x[0],2)+x[1]-11,2)+Pow(x[0]+x[1]*x[1]-7,2);};
	vector v=new vector(2);
	v[0]=1;
	v[1]=1;

	vector solR=newton.qnewton(Rosen, v, eps);
	vector solH=newton.qnewton(Himmel, v, eps);

	WriteLine($"Minimum of Rosenbrock's valley function at {solR[0]} {solR[1]}");
	WriteLine($"Minimum of Himmelblaus's function at {solH[0]} {solR[1]}");
}
}
