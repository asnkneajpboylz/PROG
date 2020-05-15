using System;
using static System.Math;
public class QR{

	public static void qr_gs_decomp(matrix Q, matrix R){	
		for(int i=0; i<Q.size2;i++){
			R[i,i]=Q[i].norm();
			Q[i]=Q[i]/R[i,i];
			for(int j=1+i;j<Q.size2;j++){
				R[i,j]=Q[i]%Q[j];
				Q[j]=Q[j]-Q[i]*R[i,j];	
			}	}	}


	public static vector qr_qs_solve(matrix Q,matrix R, vector b) {
		vector y=new vector(R.size1);
		vector x=new vector(R.size1);
		y= (Q.T)*b;
		for(int i=R.size1-1; i>=0; i=i-1) {
			x[i]=y[i];
			for(int j=i+1; j<R.size1;j++) {
			x[i]=x[i]-R[i,j]*x[j];	}
			x[i]=x[i]/R[i,i];
		}
		return x;
}
}
