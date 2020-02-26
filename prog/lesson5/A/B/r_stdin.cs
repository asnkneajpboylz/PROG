using System;
using System.IO;
class r_stdin{
static int Main(){

	do {
		string s=Console.In.ReadLine();
		if (s==null) break;
		string[] all=s.Split(' ',',','\t');

		foreach(var piece in all) {
		double x=double.Parse(piece);
		Console.Out.WriteLine($"{x} {Math.Sin(x)} {Math.Cos(x)}");
	}
}
while(true);
return 0;}
}
