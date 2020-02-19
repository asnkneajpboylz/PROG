using System;
using static System.Console;
using static System.Math;

class main {
static int Main(){

int i=1;
int j=1;
while(i+1>i) {i++;}
Write("my max int={0}\n",i);
Write("intmaxvalue={0}\n",int.MaxValue);
while(j-1<j) {j--;}
Write($"my min int={j}\n");
Write("intminvalue={0}\n", int.MinValue);

double x=1;
while(1+x !=1) {x=x/2;}
Write($"{x}\n");
float y=1F;
while((float) (1F+y) != 1F) {y/=2F;}
Write($"{y}\n");


int max= int.MaxValue/2;
float sumup=1F;
for (int k=2;k<max; k++){
       	sumup= sumup+1F/k;}
Write($"sumup={sumup}\n");
float sumdown=1F/max;
for(int m=max-1;m>0; m--) sumdown= sumdown+1F/m;
Write($"sumdown={sumdown}\n");

double sumup_d=1;
for(int k=2; k<max; k++) {
	sumup_d=sumup_d+1.0/k;}// you had to write 1.0 in order for the operation not to be a integer division ging out an integer
Write($"sumup_d={sumup_d}\n");
double sumdown_d=1/max;
for(int m=max-1; m>0;m--) sumdown_d+=1.0/m;
Write($"sumdown_d={sumdown_d}\n");


bool boulout=boolfunc.approx(1, 2, 1e-9,1e-9);
Write($"out= {boulout}\n");
return 0;
}}
