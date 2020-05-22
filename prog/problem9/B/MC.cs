using System;
using static System.Math;

public class MC{

public static Random rand=new Random();
public static vector plainmc(Func<vector,double> f, vector a, vector b, int N) {
	int n=a.size;
	//volume 
	double vol=1;
	for(int i=0;i<n;i++){
		vol*=b[i]-a[i];
	}

	double sum_func=0;
	double sum_square=0;	
	double fx=0;
	for (int i=0; i<N;i++) {
	fx=f(randomx(a,b,n));
	sum_func+= fx;
	sum_square+=fx*fx;
	}

	double mean=sum_func/N;
	double sigma=Sqrt(sum_square/N-mean*mean);
	double SIGMA=sigma/Sqrt(N);

	vector res=new vector(mean*vol, SIGMA*vol);
return res;}

public static vector randomx(vector a, vector b,  int n) {
	vector x=new vector(n);
	for(int i=0; i<n;i++){
	x[i]=a[i]+rand.NextDouble()*(b[i]-a[i]);}	
return x;}

}
