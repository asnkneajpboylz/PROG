using System;
using static System.Console;
using static System.Math;
public class main{
	public static void Main() {

	int n=60;
	double s=1.0/(n+1);
	matrix H = new matrix(n,n);
	for(int i=0;i<n-1;i++){
		  matrix.set(H,i,i,-2);
		  matrix.set(H,i,i+1,1);
		  matrix.set(H,i+1,i,1);
		        }
	matrix.set(H,n-1,n-1,-2);
	matrix.scale(H,-1/s/s);
	matrix V = new matrix(n,n);
	vector en=new vector(n);
	int count=jacobi.cycsweep(H,en,V);
		
	V.print("V test");	
	H.print("H new");
	
	en.print("eigenvalues");
	
	for (int k=0; k < n/3; k++){
	    double exact = PI*PI*(k+1)*(k+1);
	    double calculated = en[k];
	    WriteLine($"{k} {calculated} {exact}");
	}
	Write("\n \n");
	
	for (int k=0;k<4;k++){  	
		Error.WriteLine($"{0} {0}");
		for(int i=0;i<n;i++){
		//double fact=Sign(V[0,k])/Sqrt(s);		
		Error.WriteLine($"{(i+1.0)/(n+1)} {matrix.get(V,i,k)}");//c fragwürdig still oscillation        
 		}
	 	Error.WriteLine($"{1} {0}");
	 	Error.Write("\n \n");          
	}	
}}
