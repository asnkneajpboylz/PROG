using System;
using static System.Console;
public class main{
	public static void Main(){

	vector3d m=new vector3d(4,5,3);
	WriteLine($"test vector: {m}");
	WriteLine($"to String: {m.ToString()}");
	vector3d n=m*2;
	WriteLine($"multiplication by 2, {n}");
	double a=n.dot_product(m);
	WriteLine($"dot_product, {a}");

}
}
