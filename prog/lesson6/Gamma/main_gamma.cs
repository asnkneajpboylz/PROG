using static System.Console;

class main{
static int Main(){
for(double x=-5.005;x<=6;x=x+0.01)
	WriteLine("{0,10:f2} {1,15:f8}",x, math.gamma(x));
return 0;}
}
