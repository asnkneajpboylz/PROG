
out.txt: main.exe
	mono $^ >$@

main.exe: main.cs matlib.dll
	mcs $< -r:matlib.dll 

matlib.dll: vector.cs matrix.cs newton.cs
	mcs $^ -t:library -out:$@
