using System;
using static System.Math;

public class roots{

	public static vector newton(Func<vector,vector> f, vector x, double eps=1e-3, double dx=1e-7){
	int n=x.size;
	vector fx=f(x),z,fz;
	while(true){
		matrix J=jacobi(f,fx,x);
		matrix R=new matrix(n,n);
		QR.qr_gs_decomp(J,R); 
		matrix B= QR.qr_gs_inverse(J,R);
		//B.print("inverse B");
		vector del_x=-B*fx; 
		double lambda=1;
		while(true){
			z=x+lambda*del_x;
			fz=f(z);
			if(fz.norm()<(1-lambda/2)*fx.norm()) break;		
			else if(lambda<1.0/64) break;		
			else lambda/=2;				
				}
		x=z;
		fx=fz;
		if(fx.norm()<eps) break; 
		else if(x.norm()<dx) break;
		}
	return x;
	
	}

	public static matrix jacobi(Func<vector,vector> f, vector feval, vector x, double dx=1e-7) {
	int n=x.size;
	matrix J=new matrix(n,n);
	if(feval==null) feval=f(x);
	for(int k=0; k<n;k++){
		x[k]=x[k]+dx;
		vector tmp=f(x)-feval;	
		x[k]=x[k]-dx;
		for(int i=0;i<n;i++)J[i,k]=tmp[i]/dx;
		}
	return J;}

}
