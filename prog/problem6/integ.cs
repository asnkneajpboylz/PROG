using System;
using static System.Math;
public class integ{
public static vector integrec(Func<double,double> f, double a, double b, double d, double e, double f2, double f3, int c)
{
	double f1=f(a+(b-a)/6);
	double f4=f(a+5*(b-a)/6);
	double Q=(2*f1+f2+f3+2*f4)/6*(b-a);
        double q=(f1+f2+f3+f4)/4*(b-a);
	double tol=d+e*Abs(Q);
	double err=Abs(Q-q);
	vector v=new vector(Q,err);
	if(err <tol) return v;
	else{
	vector interv1=integrec(f,a,(a+b)/2,d/Sqrt(2),e,f1,f2,c+1);
	vector interv2=integrec(f,(a+b)/2,b,d/Sqrt(2), e,f3,f4,c);
	Q=interv1[0]+interv2[0];
	err=Sqrt(interv1[1]*interv1[1]+interv2[1]*interv2[1]);
	return v;
}
}

public static vector integr(Func<double,double> f, double a, double b, double d, double e){
	double f2=f(a+2*(b-a)/6);
	double f3=f(a+4*(b-a)/6);
	int c=0;
	return integrec(f,a,b,d,e,f2,f3,c);
	}

public static vector CleCur(Func<double,double> f, double a,double b, double d, double eps){
	Func<double, double> g= (x) => {return f((a+b)/2+(b-a)*Cos(x)/2)*Sin(x)*(b-a)/2;};
	return integr(g, 0,PI, d, eps);
	}

}
