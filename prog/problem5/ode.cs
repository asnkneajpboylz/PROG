using System.Collections.Generic;
using static System.Console;
using static System.Math;
using System;
public class ode{
	public static vector[] rkstep12(Func<double,vector,vector> f, double t, vector yt, double h) {
		vector k0=f(t,yt);
		vector k=f(t+0.5*h,yt+0.5*h*k0);
		vector yh=yt+h*k;
		vector err= (k-k0)*h;
		vector[] re={yh,err};
		return re;	 }
	
	public static vector driver(Func<double,vector,vector> F, double a, vector ya,double b,double acc, 
			double eps, double h,List<double> xlist, List<vector> ylist, int limit, 
			Func<Func<double,vector,vector>,double,vector,double,vector[]> stepper){
			
		int nsteps=0;
		if(xlist!=null) {xlist.Clear(); xlist.Add(a);}
		if(ylist!=null) {ylist.Clear(); ylist.Add(ya);}
		do{	if(a>=b) return ya;
			if(nsteps>limit) {
			Error.Write($"driver: nsteps>{limit}\n");
			return ya;
				}
			if(a+h>b) h=b-a;

			vector[] trial=stepper(F,a,ya,h);
			vector   yh=trial[0];
			vector   er=trial[1];
			vector to = new vector(er.size);

			for(int i=0; i<to.size; i++){
			to[i]=(acc+Abs(yh[i])*eps)*Sqrt(h/(b-a));
			if(er[i]==0)er[i]=to[i]/4;
				}
			double wo=to[0]/Abs(er[0]);
			for(int i=1; i<to.size; i++)
			wo=Min(wo,Abs(to[i]/er[i]));

			double hnew = h*Min( Pow(wo,0.25)*0.95, 2);
					
			if(wo >1){
			a+=h; ya=yh; h=hnew; nsteps++;
			if(xlist!=null) xlist.Add(a);
			if(ylist!=null) ylist.Add(ya);
				}
			else { h=hnew; Error.WriteLine($"driver: bad step at {a}"); }
			}while(true);
	}


	public static vector rk12(Func<double,vector,vector> F, double a, vector ya, double b, double acc=1e-3,
		       	double eps=1e-3, double h=0.1, List<double> xlist=null, List<vector> ylist=null, int limit=999)
		{return driver(F,a,ya,b,acc,eps,h,xlist,ylist,limit,rkstep12); }



}

