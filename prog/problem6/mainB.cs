using System;
using static System.Math;
using static System.Console;

public class main{
public static void Main(){
double eps=0.0001;					
double acc=0.0001;
double a=0,b=1;
int eval=0;
Func<double, double> f1= (x) => {eval++;return 1/Sqrt(x);};
Func<double, double> f2= (x) =>	{eval++;return Log(x)/Sqrt(x);};
Func<double, double> f3= (x) => {eval++;return 4*Sqrt(1-x*x);};


WriteLine("Comparison of different integration methods by using 3 functions");
WriteLine($"eps={eps}, acc={acc}, upper bound={a}, lower bound={b}");
Write("\n \n");

WriteLine("1/Sqrt(x)");
WriteLine("Analytic Result: 2");
vector res1_n=integ.integr(f1,a,b,acc,eps);
WriteLine($"Result: {res1_n[0]} Error: {res1_n[1]} Calls: {eval}"); 
eval=0;
vector res1_c=integ.CleCur(f1,a,b,acc,eps);
WriteLine($"Result: {res1_c[0]} Error: {res1_c[1]} Calls: {eval}"); 
eval=0;
double res1_8=quad.o8av(f1,a,b,acc,eps);
WriteLine($"Result: {res1_8} Calls: {eval}"); 
eval=0;
Write("\n \n");

WriteLine("Log(x)/Sqrt(x)");
WriteLine("Analytic Result: -4");
vector res2_n=integ.integr(f2,a,b,acc,eps);
WriteLine($"Result: {res2_n[0]} Error: {res2_n[1]} Calls: {eval}"); 
eval=0;
vector res2_c=integ.CleCur(f2,a,b,acc,eps);
WriteLine($"Result: {res2_c[0]} Error: {res2_c[1]} Calls: {eval}"); 
eval=0;
double res2_8=quad.o8av(f2,a,b,acc,eps);
WriteLine($"Result: {res2_8} Calls: {eval}"); 
eval=0;
Write("\n \n");


//eps=0;
//acc=1e-8;
WriteLine("4*Sqrt(1-x*x)");
WriteLine($"Analytic Result: {PI}");
vector res3_n=integ.integr(f3,a,b, acc, eps);
WriteLine($"Result: {res3_n[0]} Error: {res3_n[1]} Calls: {eval}"); 
eval=0;
vector res3_c=integ.CleCur(f3,a,b,acc,eps);
WriteLine($"Result: {res3_c[0]} Error: {res3_c[1]} Calls: {eval}"); 
eval=0;
double res3_8=quad.o8av(f3,a,b,acc,eps);
WriteLine($"Result: {res3_8} Calls: {eval}"); 
eval=0;

}
}
