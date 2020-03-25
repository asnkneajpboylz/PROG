out.txt: main.exe
	mono $<

main.exe: main.cs matlib.dll
	mcs -reference:matlib.dll $<

matlib.dll: cspline.cs
	mcs -target:library -out:$@ $^

clean:
	rm -f *.exe
