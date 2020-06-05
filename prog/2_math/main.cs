using System;
using static System.Console;
using static System.Math;
using static cmath;
using static complex;

class main {
	
	static int Main(){
	Write($"check, sqrt(2)={Sqrt(2)}\n"); //system.math
	Write($"cmath, sqrt(2)={sqrt(2)}\n\n"); //library	
	
	complex I =new complex(0,1);
	complex IpowI= I.pow(I);
	Write($"check, exp(i)*exp(-i)={exp(I)*exp(-I)}\n");
	Write($"cmath,exp(i)={exp(I)}\n\n");

	Write($"check, abs(exp(i*Pi))={abs(exp(I*PI))}\n");
	Write($"cmath,exp(i*Pi)={exp(I*PI)}\n\n");

	Write($"check, exp(-pi/2)={exp(-PI/2)}\n");
	Write($"cmath,i^i={IpowI}\n\n");

	Write($"check, euler={I/2*(exp(PI)-exp(-PI))}\n");
	Write($"cmath,sin(ipi)={sin(I*PI)}\n\n");
	return 0;}

}
