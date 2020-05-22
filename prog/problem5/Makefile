PLOT = Cos.svg
PLOTB= SIR.svg
all: $(PLOT) $(PLOTB)

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


mainB.exe: mainB.cs matlib.dll
	mcs $< -r:matlib.dll

outB.txt: mainB.exe
	mono mainB.exe >$@

$(PLOTB): outB.txt Makefile
	echo '\
	set term svg;\
	set out "$(PLOTB)";\
	set title "SIR Model Denmark - June to August Tc=3";\
	set xlabel "x";\
	set ylabel "y";\
	plot\
	"outB.txt" using 1:2 title "Susceptible"\
	,"outB.txt" using 1:3 title "Infected"\
	,"outB.txt" using 1:4 title "Recovered"\
	
	'|gnuplot
