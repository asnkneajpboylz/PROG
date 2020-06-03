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

jacobi.dll: jacobi.cs matlib.dll
	mcs $< -t:library -r:matlib.dll -out:$@

matlib.dll: matrix.cs vector.cs 
	mcs -t:library -out:$@ $^

clean:
	rm -f *.exe *.dll *.txt *.svg


