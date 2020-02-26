Gamma.svg: gamma.gpi out.gamma.txt fact.txt
	gnuplot $<

out.gamma.txt: main_gamma.exe 
	mono $< >out.gamma.txt

main_gamma.exe: main_gamma.cs math.dll
	mcs $< -out:$@ -reference:math.dll

math.dll: gamma.cs
	mcs $< -target:library -out:$@

clean: 
	rm --force *.dll *.exe out* *.svg
