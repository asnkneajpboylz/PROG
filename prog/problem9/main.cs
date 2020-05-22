using System;
using static System.Math;
using static System.Console;

public class main{
public static void Main(){
	vector a= new vector(0.0,0.0,0.0);
	vector b= new vector(PI,PI,PI);
	int N=50000;//evaluations
	
	Func<vector, double> g= (x) => {return x[0]*x[0]*x[1]*x[2];};
	Func<vector, double> f= (x) => {return 1/(1-Cos(x[0])*Cos(x[1])*Cos(x[2]))/PI/PI/PI;};
	vector resf=MC.plainmc(f,a,b,N);
	vector resg=MC.plainmc(g,a,b,N);
	
	WriteLine("Two integrals calculated via Monte Carlo Integration");
	WriteLine($"Lower bound (0,0,0), upper bound (3.14, 3.14, 3.14)");
	WriteLine($"Evaluations: {N}");
	Write("\n");
	WriteLine("x^2*y*z");
	WriteLine($"Results: integral estimate {resg[0]}, error {resg[1]}");
	Write("\n");
	WriteLine("1/(1-Cos(x)*Cos(y)*Cos(z))*1/(PI^3)");
	WriteLine($"Results: integral estimate {resf[0]}, error {resf[1]}");
	

}
}
