report.pdf: report.tex plot.tex
	pdflatex $<
	pdflatex $<


plot.tex: plot.gpi out.txt
	gnuplot $<

out.txt: main.exe
	mono $< 1> $@ 2> log

main.exe: main.cs matlib.dll
	mcs -reference:matlib.dll $<

matlib.dll: vector.cs ode.cs
	mcs -target:library -out:$@ $^

clean:
	rm -f *.svg *.dll *.exe log* out*
