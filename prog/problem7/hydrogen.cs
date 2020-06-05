using System;
public class hydrogen{

public static double Fe(double e,double r){
	double rmin=1e-3;
	if(r<rmin) return r-r*r;

	Func<double,vector,vector> swave= (x,y) =>{return new vector(y[1],-2*(e*y[0]+y[0]/x));};
	vector yrmin=new vector(rmin-rmin*rmin,1-2*rmin);
	vector yrmax= ode.rk12(swave,rmin,yrmin,r,1e-3);
	return yrmax[0];


}
}
