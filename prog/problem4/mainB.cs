using System;
using static System.Console;
using static System.Math;
using System.Diagnostics;

public class main{
public static void Main(){

	
	for(int n=5; n<300;n=n+50){
		matrix A=new matrix(n,n);
		matrix V=new matrix(n,n);
		vector e=new vector(n);
		var rand=new Random(1);
		
		for(int i=0;i<n;i++){
		for(int j=i;j<n;j++){
			A[i,j]=2*(rand.NextDouble()-0.5);
			A[j,i]=A[i,j];}}
		
		Stopwatch rowt=new Stopwatch();//one EV
		matrix AAf=A.copy();
		rowt.Start();
		int count=jacobiB.jacobirow(AAf,e,1,V);
		rowt.Stop();

		Stopwatch rowh=new Stopwatch();//full diag
		matrix Vh=new matrix(n,n);
		vector eh=new vector(n);
		matrix AAh=A.copy();
		rowh.Start();
		int counth=jacobiB.jacobirow(AAh,eh,n,Vh);
		rowh.Stop();
			
		matrix Vt=new matrix(n,n);//cyclic
		vector et=new vector(n);
		matrix AAt=A.copy();
		Stopwatch cyct=new Stopwatch();
		cyct.Start();
		int countt=jacobi.cycsweep(AAt,et,Vt);
		cyct.Stop();

		WriteLine($"{n} {rowt.ElapsedMilliseconds} {count} {rowh.ElapsedMilliseconds} {counth} {cyct.ElapsedMilliseconds} {countt}");
	}






}
}
