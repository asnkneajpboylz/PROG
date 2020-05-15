using System;
using static System.Math;

public partial class jacobi{
	public void cycsweep(matrix A,vector e, matrix V) {
		int n=A.size1;
		for(int p=0;p<(n-1);p++){
			for(int q=p+1; q<n;q++){
				double App=e[p];
				double Aqq=e[q];
				double Apq=A[p,q];
				double phi=0.5*Math.Atan(2*Apq/(Aqq-App));
				double c=Cos(phi);
				double s=Sin(phi);
				double Appn=c*c*App-2*s*c*Apq+s*s*Aqq;
				double Aqqn=s*s*App+2*s*c*Apq+c*c*Aqq;
				e[p]=Appn;
				e[q]=Aqqn;
				A[p,q]=0.0;

				for(int i=0;i<p;i++){
					double Aip=A[i,p];
					double Aiq=A[i,q];
					A[i,p]=c*Aip-s*Aiq;
					A[i,q]=c*Aiq+s*Aip;}
				for(int i=p+1;i<q;i++){
					double Api=A[p,i];
					double Aiq=A[i,q];
					A[p,i]=c*Api-s*Aiq;
					A[i,q]=c*Aiq+s*Api;}
				for(int i=q+1;i<n;i++){
					double Api=A[p,i];
					double Aqi=A[q,i];
					A[p,i]=c*Api-s*Aqi;
					A[q,i]=c*Aqi+s*Api;}
				for(int i=0;i<n;i++) {					
					double Vip=V[i,p];
					double Viq=V[i,q];
					V[i,p]=c*Vip-s*Viq;
					V[i,q]=c*Viq+s*Vip;	
				}
			}
		}
		
	}

}
