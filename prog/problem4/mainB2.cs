using System;
using static System.Math;
public class main{
public static void Main(){	
	//now test highest EV
	int n=5;
	matrix A=new matrix(n,n);
	matrix V=new matrix(n,n);
	vector e=new vector(n);
	var rand=new Random(1);
		
		for(int i=0;i<n;i++){
		for(int j=i;j<n;j++){
			A[i,j]=2*(rand.NextDouble()-0.5);
			A[j,i]=A[i,j];}}
		
		//2 highest EV
		matrix AA2=A.copy();
		string order="high";
		int count=jacobiB.jacobirow(AA2,e,2,V,order);
		e.print("First 2 values should be highest EVs");

		//full diag
		matrix Vh=new matrix(n,n);
		vector eh=new vector(n);
		matrix AAh=A.copy();
		int counth=jacobiB.jacobirow(AAh,eh,n,Vh);
		eh.print("all eigenvalues");
}}
