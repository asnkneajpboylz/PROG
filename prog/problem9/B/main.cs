using System;
using static System.Math;
using static System.Console;

public class main{
public static void Main(){
	vector a= new vector(0.0,0.0,0.0);
	vector b= new vector(2.0,2.0,2.0);
	int exact= 16;
	WriteLine("N error Abs(estim-exact) 1/sqrt(N)");
	Func<vector, double> g= (x) => {return x[0]*x[0]*x[0]*x[1]*x[2];};
	int N1=5000;
	vector resg1=MC.plainmc(g,a,b,N1);
	double scale=resg1[1]*Sqrt(N1);
	for(int N=10000; N<1000000;N=N+5000){
	vector resg=MC.plainmc(g,a,b,N);
	WriteLine($"{N} {resg[1]} {Abs(resg[0]-exact)} {scale/Sqrt(N)}");
	}
	
	//WriteLine($"Lower bound (0,0,0), upper bound (3.14, 3.14, 3.14)");
	
	

}
}
