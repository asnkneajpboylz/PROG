using System;
using static System.Math;
using static System.Console;

public class main{
public static void Main(){
	int n=5;
	double xb=0;
	double xe=2*PI;
	int count=30;
	vector xs=new vector(count);
	vector ys=new vector(count);
	vector yi=new vector(count);
	vector yd=new vector(count);

	for(int i=0; i<count;i++){
		xs[i]=xb+(xe-xb)/(count-1)*i;
		ys[i]=Cos(xs[i]);
		WriteLine($"{xs[i]} {ys[i]}");
	}	
	Write("\n \n");

	var annet=new ann(n);	
	for (int i=0;i<n; i++){
		annet.paramet[3*i]=xb+(xe-xb)/n*i;
		annet.paramet[3*i+1]=1;
		annet.paramet[3*i+2]=1;
	}
	annet.paramet.print("Parameters:");
	annet.train(xs,ys);
	annet.paramet.print("Parameters after training:");
	Write("\n \n");

	int interp=150;
	double x,y;
	for(int i=0; i<interp;i++){
	x=xb+(xe-xb)/interp*i;
	y=annet.feedforward(x);
	WriteLine($"{x} {y}");
	}
	Write("\n \n");
	
	for(int i=0; i<count;i++){
		xs[i]=xb+(xe-xb)/(count-1)*i;
		yi[i]=Sin(xs[i]);//integration
		yd[i]=-yi[i];//differentiation
		WriteLine($"{xs[i]} {yi[i]} {yd[i]}");
	}
	Write("\n \n");
	for(int i=0; i<interp;i++){//integration
	x=xb+(xe-xb)/interp*i;
	y=annet.feed_int(x,xb);
	WriteLine($"{x} {y}");
	}
	Write("\n \n");
	for(int i=0; i<interp;i++){//differentiation
	x=xb+(xe-xb)/interp*i;
	y=annet.feed_dif(x);
	WriteLine($"{x} {y}");
	}
}
}
