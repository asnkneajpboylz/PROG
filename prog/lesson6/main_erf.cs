using static System.Console;
using static System.Math;

class erfmain{
static int Main(){
for (double x=-3.5;x<=3.5; x+=0.1) {
	WriteLine("{0,10:f2} {1,15:f8}", x, math.erf(x));
	}
return 0;}
}
