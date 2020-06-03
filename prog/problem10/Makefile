all: out.txt Cos.svg Der.svg Int.svg

Der.svg: Der.gpi out.txt
	gnuplot $<

Int.svg: Int.gpi out.txt
	gnuplot $<

Cos.svg: Cos.gpi out.txt
	gnuplot $< 

out.txt: main.exe
	mono $< >$@

main.exe: main.cs matlib.dll
	mcs $< -r:matlib.dll

matlib.dll: matrix.cs newton.cs vector.cs ann.cs
	mcs $^ -t:library -out:$@

clean: 
	rm -f *.exe out* *.dll *.svg
