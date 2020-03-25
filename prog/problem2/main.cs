using System;
using static System.Math;
using static System.Console;
class main{


static matrix qr_gs_decomp(matrix A, matrix R){
		matrix Q=A.copy();	
		for(int i=0; i<Q.size2;i++){
			R[i,i]=Q[i].norm();
			Q[i]=Q[i]/R[i,i];
			for(int j=1+i;j<Q.size2;j++){
				R[i,j]=Q[i]%Q[j];
				Q[j]=Q[j]-Q[i]*R[i,j];
			}
		}
	return Q;
	}


static int Main(){
	int n=5;
       	int m=4;
	Random random=new Random();
	matrix R=new matrix(m,m);
	matrix Q=new matrix(n,m);
	matrix A=new matrix(n,m);
	for(int i=0;i<n; i++){
		for(int j=0;j<m;j++){
		A[i,j]=random.Next(10);
		}
	}
	A.print($"matrix A: ");
	Q=qr_gs_decomp(A, R);
	R.print($"matrix R: ");
	Q.print($"matrix Q: ");
	(Q*R).print($"matrix QR: ");
	(Q.T *Q).print($"matrix Q^T Q: ");
	return 0;}	
}
