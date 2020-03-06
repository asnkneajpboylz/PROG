using System;
using static System.Math;
using static System.Console;
using System.Collections;
using System.Collections.Generic;

class main{
static int Main(string[] args){
double a=0, y0=1,y1=0,b=20;
foreach(string s in args){
string[] ws=s.Split('=');
if(ws[0]=="a") a=double.Parse(ws[1]);
if(ws[0]=="y0") y0=double.Parse(ws[1]);
if(ws[0]== "y1") y1=double.Parse(ws[1]);
if(ws[0]== "b") b=double.Parse(ws[1]);
}

Func<double, vector, vector> cosine=(x,y) => new vector(y[1],-y[0]);
vector ya=new vector(y0,y1);
List<double> xs=new List<double>();
List<vector> ys=new List<vector>();
ode.rk23(cosine,a,ya,b,xs,ys);
for(int i=0;i<xs.Count;i++)
	WriteLine($"{xs[i]} {ys[i][0]}");


return 0;}
}
