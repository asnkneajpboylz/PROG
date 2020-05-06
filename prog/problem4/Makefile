out.txt: main.exe
	mono main.exe >$@

main.exe: main.cs matlib.dll jacobi.dll
	mcs $<  -r:matlib.dll -r:jacobi.dll -o:$@

jacobi.dll: jacobi.cs matlib.dll
	mcs $< -t:library -r:matlib.dll -out:$@
matlib.dll: matrix.cs vector.cs 
	mcs -t:library -out:$@ $^

clean:
	rm -rf *-exe *.dll
