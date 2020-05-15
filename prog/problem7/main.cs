using System;
using static System.Math;

public class main{

public static void Main(){
	double dx=1e-7;

	Func<vector,double> f= (x) => (1-x[0])*(1-x[0]) +100*Pow((x[1]-Pow(x[0],2)),2);
	vector z=new vector(2);
	z[0]=1;
	z[1]=2;
	vector roo=roots.Jacobi(f,z,dx);
}

}
