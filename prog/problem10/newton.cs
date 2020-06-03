using System;
using static System.Math;
using static System.Console;
 
public class newton{

	public static vector qnewton(Func<vector,double> f, vector xstart, double eps) {
		double fx = f(xstart);
		vector gx = gradient(f,xstart,eps);
		int m=xstart.size;
		matrix B=new matrix(m,m);
		for(int i=0;i<m;i++) B[i,i]=1;
		//B.print("B");
		int n=0;
		while(n<500){
			vector Dx =-B*gx;
			n++;
			if(gx.norm()<eps) break;
			double lambda = 1.0;
			while(f(xstart+lambda*Dx)>fx){
				if(lambda<eps){
					for(int i=0;i<m;i++) B[i,i]=1;
					break;
				}
				lambda/=2.0;
			}
			vector s = lambda*Dx;
			vector gz = gradient(f,xstart+s,eps);
			vector y = gz-gx;
			vector u = s-B*y;
			if(Abs(u%y)>1e-6){
				for(int i=0; i<m;i++){
					for(int j=0; j<m;j++){
					B[i,j]=B[i,j]+u[i]*u[j]*1.0/(u%y);
				}}
			}
			xstart = xstart+s;
			gx = gz;
			fx = f(xstart);
		}
		return xstart;
	
	}
	public static vector gradient(Func<vector,double> f, vector x, double eps){
		int n=x.size;
		double feval=f(x);
		vector g=new vector(n);
		for(int i=0;i<n;i++){
			x[i]+=eps;
			g[i]=(f(x)-feval)/eps;
			x[i]-=eps;
			}
	return g;}
}
