plot.svg: plot.gpi out.txt
	gnuplot $<

out.txt: main.exe Makefile
	mono $< a=0 y0=0.5 b=3 1> $@ 2>log

main.exe: main.cs matlib.dll
	mcs -reference:matlib.dll $<

matlib.dll: vector.cs ode.cs
	mcs -target:library -out:$@ $^

clean:
	rm -f  *.svg *.dll *.exe log* out*
