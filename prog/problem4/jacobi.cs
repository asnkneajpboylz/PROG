

using System;
using static System.Math;
public partial class jacobi{
	public static int cycsweep(matrix A,vector e, matrix V=null) {
		int n=A.size1;
		int count=0;
		bool run;
		for(int i=0; i<n;i++) {
			e[i]=A[i,i];
			if (V !=null) {
				V[i,i]=1.0;
				for(int j=i+1;j<n;j++) {
				V[i,j]=0;
				V[j,i]=0;}}}
		do{ 
		count++;
		run=false;
		for(int q=n-1;q>0;q--){
			for(int p=0; p<q;p++){
				double App=e[p];
				double Aqq=e[q];
				double Apq=A[p,q];
				double phi=0.5*Math.Atan2(2*Apq,Aqq-App);
				double c=Cos(phi);
				double s=Sin(phi);
				double Appn=c*c*App-2*s*c*Apq+s*s*Aqq;
				double Aqqn=s*s*App+2*s*c*Apq+c*c*Aqq;
				if(Appn != App || Aqqn != Aqq) {
				run=true;
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
				if (V!=null) for(int i=0;i<n;i++) {					
					double Vip=V[i,p];
					double Viq=V[i,q];
					V[i,p]=c*Vip-s*Viq;
					V[i,q]=c*Viq+s*Vip;	
				}
			}}}}while(run==true);
return count;
}
}
