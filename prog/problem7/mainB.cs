using System;
using static System.Console;
using static System.Math;
public class main{
public static void Main(){

	double rmax=7;
	Func<vector,vector> M= (v) => {double e=v[0]; double frmax=hydrogen.Fe(e,rmax);return new vector(frmax);};

	vector vstart=new vector(-1.0);
	vector v_root=roots.newton(M,vstart,1e-3);
	double energy=v_root[0];
	WriteLine($"energy={energy}");
	WriteLine("r Fe(e,r) exact");
	for(double r=0;r<=rmax;r=r+0.1) WriteLine($"{r} {hydrogen.Fe(energy,r)} {r*Exp(-r)}");

}
}	
