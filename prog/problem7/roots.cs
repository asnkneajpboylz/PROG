using System;
using static System.Math;

public class roots{

	public static vector newton(Func<vector,vector> f, vector x, double epsilon=1e-3, double dx=1e-7){
	int n=x.size;
	vector root=new vector(n);
	return root;
	}

	public static matrix jacobi(Func<vector,vector> f, vector x, double dx=1e-7) {
	int n=x.size;
	matrix J=new matrix(n,n);
	vector feval=f(x);
	for(int k=0; k<n;k++){
		x[k]=x[k]+dx;
		for(int i=0;i<n;i++){
		vector tmp=f(x)-feval;	
		J[i,k]=tmp[i]/dx;
		x[k]=x[k]-dx;}
	}
	return J;}

}
