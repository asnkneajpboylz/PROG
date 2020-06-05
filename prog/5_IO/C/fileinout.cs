using System;
using System.IO;
class fileinout{
static int Main(string[] args){
	string infile = args[0];
	string outfile = args[1];
	StreamReader instream = new StreamReader(infile);
	StreamWriter outstream = new StreamWriter(outfile, append:false);
	do{
		string line=instream.ReadLine();
		if(line==null) break;
		string[] words=line.Split(' ',',',',','\t');
		foreach(var word in words) {
			double x=double.Parse(word);
			outstream.WriteLine($"{x} {Math.Sin(x)} {Math.Cos(x)}");
		}
	}while(true);
	outstream.Close();
	instream.Close();
return 0;	}

}
