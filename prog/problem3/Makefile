lsquare.svg: lsquare.gpi outfit.txt outdata.txt
	gnuplot $<

outfit.txt: main.exe
	mono $< 1>$@ 2>Log

main.exe: main.cs matlib.dll
	mcs -reference:matlib.dll $<

matlib.dll: matrix.cs vector.cs QR.cs
	mcs -target:library -out:$@ $^  

clean: 
	rm -f *.svg *.exe *.txt *.dll

outdata.txt: Makefile
	echo '1 117' >$@
	echo '2 100' >>$@
	echo '3 88' >>$@
	echo '4 72' >>$@
	echo '6 53' >>$@
	echo '9 29.5' >>$@
	echo '10 25.2' >>$@
	echo '13 15.2' >>$@
	echo '15 11.1' >>$@
