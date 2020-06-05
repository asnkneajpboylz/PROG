using System;
using static System.Console;
using static System.Math;
public class main{
	public static void Main(){
		int n=3;
		matrix A=new matrix(n,n);
		matrix V=new matrix(n,n);
		vector e=new vector(n);
		var rand=new Random();
		for(int i=0; i<n;i++) {
			for(int j=i;j<n;j++) {
			A[i,j]=rand.NextDouble() *10;
			A[j,i]=A[i,j];
			}
		}
		A.print("Symmetric matrix A:");
		matrix Ao=new matrix(n,n);
		Ao=A.copy();
		int count=jacobi.cycsweep(A,e,V);
		
		WriteLine($"Number of sweeps: {count}");
		V.print("Eigenvectors");
		A.print("new A");
		e.print("Eigenvalues");
		(V.T*Ao*V).print("V^T*A*V diagonal, test");
	}

}
