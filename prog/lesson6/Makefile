Erf.svg: erf.gpi out.erf.txt
	gnuplot $<

out.erf.txt: main_erf.exe
	mono $< >out.erf.txt

main_erf.exe: main_erf.cs math.dll
	mcs $< -out:$@ -reference:math.dll

math.dll: erf.cs
	mcs $< -target:library -out:$@
