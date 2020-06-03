all: out.txt outB.txt

out.txt: main.exe
	mono $< >out.txt

main.exe: main.cs integlib.dll
	mcs $< -reference:integlib.dll 

integlib.dll: integ.cs quad.cs vector.cs
	mcs $^ -target:library -out:$@

mainB.exe: mainB.cs integlib.dll
	mcs $< -r:integlib.dll

outB.txt: mainB.exe
	mono $< >outB.txt
clean:
	rm -f *.dll *exe out* *.svg
