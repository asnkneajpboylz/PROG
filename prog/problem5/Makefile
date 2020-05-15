PLOT = Cos.svg
all: $(PLOT)

out.txt: main.exe
	mono main.exe 1> $@ 2> Log

main.exe: main.cs matlib.dll
	mcs $< -reference:matlib.dll

matlib.dll: ode.cs vector.cs
	mcs -target:library -out:$@ $^
clean:
	rm -f *.dll *exe out* *.svg

$(PLOT): out.txt Makefile
	echo '\
	set term svg;\
	set out "$(PLOT)";\
	set title "dy_0/dx=-y_1, dy_1/dy=y0";\
	set xlabel "x";\
	set ylabel "y";\
	plot\
	"out.txt" using 1:2 title "y_0"\
	,"out.txt" using 1:3 title "y_1"\
	,cos(x) title "cos"\
	,sin(x) title "sin"\
	'|gnuplot
