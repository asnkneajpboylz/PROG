using System;
using static System.Math;

public class boolfunc {
	public static bool approx(double a, double b, double tau, double eps)

	{
	if ((Abs(a-b) < tau) || ((Abs(a-b)/(Abs(a)+Abs(b)))<eps/2))
		return true;
	else return false;
	}

}
