using System;
using static System.Console;
using static System.Math;
public class main{
	public static void Main(){
		int n=5;
		matrix A=new matrix(n,n);
		matrix V=new matrix(n,n);
		vector e=new vector(n);
		vector en=new vector(n);
		jacobi ja=new jacobi();
		var rand=new Random();
		for(int i=0; i<n;i++) {
		V[i,i]=1;
			for(int j=i;j<n;j++) {
			A[i,j]=rand.NextDouble() *10;
			A[j,i]=A[i,j];
			}
		}
		A.print("Symmetric matrix A:");
		matrix AN= A.copy();
		int count=0;
		for(int i=0;i<n;i++) e[i]=A[i,i];
		do{
			en=e.copy();
			ja.cycsweep(A,e,V);
			count++;
		}while((en-e).norm() >0.001) ;
		WriteLine($"Number of sweeps: {count}");
		V.print("Eigenvectors");
		e.print("Eigenvalues");
		(V.T*AN*V).print("V^T*A*V diagonal, test");
	}

}
