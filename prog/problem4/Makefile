all: boxfunc.svg plotB.svg plotOn3.svg outB2.txt

outB2.txt: mainB2.exe
	mono $< >$@

mainB2.exe: mainB2.cs jacobi.dll matlib.dll
	mcs $< -r:matlib.dll -r:jacobi.dll -o:$@

plotOn3.svg: plotOn3.gpi outB.txt
	gnuplot $<

plotB.svg: plotB.gpi outB.txt	
	gnuplot $<

outB.txt:mainB.exe
	mono $< >$@

mainB.exe:mainB.cs jacobi.dll matlib.dll
	mcs $< -r:matlib.dll -r:jacobi.dll -o:$@

boxfunc.svg: boxfunc.gpi outbox_plot.txt 	
	gnuplot $<

outbox_text.txt outbox_plot.txt:mainbox.exe
	mono mainbox.exe 1>outbox_text.txt  2>outbox_plot.txt

out.txt: main.exe
	mono main.exe >$@

mainbox.exe:mainbox.cs matlib.dll jacobi.dll
	mcs $< -r:matlib.dll -r:jacobi.dll -o:$@

main.exe: main.cs matlib.dll jacobi.dll
	mcs $< -r:matlib.dll -r:jacobi.dll -o:$@

jacobi.dll: jacobi.cs jacobiB.cs matlib.dll 
	mcs jacobi.cs jacobiB.cs -t:library -r:matlib.dll -out:$@

matlib.dll: matrix.cs vector.cs 
	mcs -t:library -out:$@ $^

clean:
	rm -f *.exe *.dll *.txt *.svg


