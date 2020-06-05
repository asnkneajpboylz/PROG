all:out.txt plot.svg
out.txt: main.exe
	mono $< >$@

main.exe: main.cs math.dll
	mcs $< -r:math.dll

math.dll: vector.cs QR.cs roots.cs matrix.cs ode.cs 
	mcs $^ -t:library -out:$@

plot.svg:plot.gpi outB.txt	
	gnuplot $<

outB.txt:mainB.exe
	mono $< >$@ 

mainB.exe: mainB.cs hydrogen.cs math.dll
	mcs mainB.cs hydrogen.cs -r:math.dll

clean:
	rm -f *.dll *exe out* *.svg
comma:=,
empty:=
space:=$(empty) $(empty)
clist=$(subst $(space),$(comma),$(1))
