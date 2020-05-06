using System;
using static System.Math;

public partial class jacobi{
	public static void cycsweep(matrix A,vector e, matrix V) {
		int n=A.size1;
		for(int p=0;p<n;p++){
			for(int q=p+1; q<n;q++){
				double App=e[p];
				double Aqq=e[q];
				double Apq=A[p,q];
				double phi=0.5*Math.Atan(2*A[p,q]/(A[q,q]-A[p,p]));
				double c=Cos(phi);
				double s=Sin(phi);
				double Appn=c*c*App-2*s*c*Apq+s*s*Aqq;
				double Aqqn=s*s*App+2*s*c*Apq+c*c*Aqq;
				e[p]=Appn;
				e[q]=Aqqn;
				A[p,q]=0.0;

				for(int i=0;i<n;i++){
					double Aip=A[i,p];
					double Aiq=A[i,q];
					if(i != p) {
					A[i,p]=c*Aip-s*Aiq;
					A[p,i]=A[i,p];}
					if(i != q) {
					A[i,q]=c*Aiq+s*Aip;
					A[q,i]=A[i,q];
					}		
				}
			}
		}
		
	}

}
