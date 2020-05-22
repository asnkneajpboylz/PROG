using System;
using static System.Math;
using static System.Console;
class main{
static void qr_gs_decomp(matrix Q, matrix R){	
		for(int i=0; i<Q.size2;i++){
			R[i,i]=Q[i].norm();
			Q[i]=Q[i]/R[i,i];
			for(int j=1+i;j<Q.size2;j++){
				R[i,j]=Q[i]%Q[j];
				Q[j]=Q[j]-Q[i]*R[i,j];	
			}
		}
	}

static vector qr_gs_solve(matrix Q,matrix R, vector b) {
	vector y=new vector(R.size1);
	vector x=new vector(R.size1);
	//(Q.T).print($"Q^T");
	y= (Q.T)*b;
	for(int i=R.size1-1; i>=0; i=i-1) {
		x[i]=y[i];
		for(int j=i+1; j<R.size1;j++) {
			x[i]=x[i]-R[i,j]*x[j];	}
		x[i]=x[i]/R[i,i];
	}
	//(R*x).print("Rx"); y.print("y"); (Q*y).print("Qy");
	return x;
}

static matrix qr_gs_inverse(matrix Q, matrix R) {
	matrix B=new matrix(R.size1,R.size1);
	vector sol=new vector(R.size1);
	vector E=new vector(R.size1);
	for(int i=0; i<R.size1; i++) {
		E[i]=1;
		sol=qr_gs_solve(Q,R,E);
		for(int j=0;j<R.size1;j++) B[j,i]=sol[j];
		E[i]=0;
	}
return B;}

static int Main(){
	int n=3;
       	int m=3;
	Random random=new Random();
	matrix R=new matrix(m,m);
	matrix Q=new matrix(n,m);
	vector x1=new vector(m);
	matrix A=new matrix(n,m);
	matrix Ain=new matrix(n,m);
	vector b=new vector(n);
	for(int i=0;i<n; i++){
		b[i]=random.Next(10);
		for(int j=0;j<m;j++){
		A[i,j]=random.Next(10);
		Q[i,j]=A[i,j];
		}
	}
	A.print($"matrix A: ");
	qr_gs_decomp(Q, R);
	R.print($"matrix R: ");
	Q.print($"matrix Q: ");
	(Q*R).print($"matrix QR: ");
	(Q.T *Q).print($"matrix Q^T Q: ");
	x1=qr_gs_solve(Q,R,b);
	b.print("b");
	((Q*R)*x1).print($"QRx");
	x1.print($"solution x");
	(A*x1).print("check Ax=b");
	Ain=qr_gs_inverse(Q,R);
	Ain.print("Inverse of A");
	(A*Ain).print("Test: A*Ainv=I:");
	return 0;}	
}
