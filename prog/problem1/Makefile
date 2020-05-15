
all: quadspline.svg linspline.svg

quadspline.svg: quadspline.gpi out.txt
	gnuplot $<

linspline.svg: linspline.gpi out.txt
	gnuplot $<

out.txt: main.exe
	mono $< >$@

main.exe: main.cs matlib.dll
	mcs -reference:matlib.dll $<

matlib.dll: cspline.cs quadspline.cs
	mcs -target:library -out:$@ $^

clean:
	rm -f *.exe
