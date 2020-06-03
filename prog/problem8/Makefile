plot.svg: plot.gpi outB.txt data.txt
	gnuplot $<
out.txt: main.exe
	mono $^ >$@

main.exe: main.cs matlib.dll
	mcs $< -r:matlib.dll 

matlib.dll: vector.cs matrix.cs newton.cs
	mcs $^ -t:library -out:$@

outB.txt: mainB.exe
	mono $< 1>Log 2>$@

mainB.exe:mainB.cs matlib.dll
	mcs $< -r:matlib.dll




clean:
	rm -f *.dll *exe out* *.svg
