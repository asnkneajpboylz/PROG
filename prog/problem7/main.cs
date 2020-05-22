using System;
using static System.Math;
using static System.Console;
public class main{

public static void Main(){
	double eps=1e-3;

	//Func<vector,double> Rosen= (x) => (1-x[0])*(1-x[0]) +100*Pow((x[1]-Pow(x[0],2)),2);
	vector z=new vector(2);
	z[0]=2;
	z[1]=2;

	Func<vector,vector> Rosendif= (x) =>new vector(-2+2*x[0]-400*x[0]*(x[1]-x[0]*x[0]),200*(x[1]-x[0]*x[0]));
	vector roo=roots.newton(Rosendif,z,eps);
	WriteLine($"eps {eps}");
	roo.print("Extremum of Function (root of gradient)");
	Rosendif(roo).print("gradient(solution)");
}

}
