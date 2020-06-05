using System;
using static System.Console;

class r_cmdline{
static int  Main(string[] arguments){
	
	foreach(var r in arguments){
		double x=double.Parse(r);
		WriteLine($"{x} ");}

return 0;}}
