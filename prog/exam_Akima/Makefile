plot.svg: plot.gpi out.txt data.txt
	gnuplot $<

out.txt data.txt: main.exe
	mono $< 1>out.txt 2>data.txt

main.exe: main.cs matlib.dll
	mcs $< -r:matlib.dll

matlib.dll: vector.cs akima.cs
	mcs $^ -t:library -out:$@ 

clean: 
	rm -f *.exe out* *.dll *.svg
