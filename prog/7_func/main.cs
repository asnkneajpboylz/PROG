using System;
using static System.Console;
using static System.Math;
class main{

// also use lambda notation Func<double,double> f = (x) => Log(x)/Sqrt(x);

const double inf=System.Double.PositiveInfinity;
const double infn=System.Double.NegativeInfinity;

static double ln_int(){
	Func<double,double> f =delegate(double x){
		return Log(x)/Sqrt(x);};
	return quad.o8av(f,0,1);}

static double gauss(){
	Func<double,double> g=delegate(double x){
		return Exp(-x*x);};
	return quad.o8av(g,infn,inf);}

static double gamm(double p){
	Func<double,double> h=delegate(double x){
		return Pow(Log(1/x),p);};
	return quad.o8av(h,0,1);}


static int Main(){
WriteLine($"ln_int={ln_int()}");
WriteLine($"exact solution=-4");
Write("\n \n");
WriteLine($"gauss={gauss()}");
WriteLine($"exact solution={Sqrt(PI)}");
Write("\n \n");
for(int i=0;i<11; i=i+5)
	WriteLine($"gamma({i})={gamm(i)}");

WriteLine($"exact solution=1");
WriteLine($"exact solution=120");
WriteLine($"exact solution=3628800");
return 0;}
}
