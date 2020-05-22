test.svg: test.gpi out.txt
	gnuplot $<

out.txt: main.exe
	mono main.exe >$@

main.exe: main.cs matlib.dll
	mcs main.cs -r:matlib.dll 

matlib.dll: vector.cs MC.cs
	mcs $^ -t:library -out:$@ 
