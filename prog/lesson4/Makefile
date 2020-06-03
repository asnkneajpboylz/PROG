out.txt: main.exe
	mono main.exe < out.txt

main.exe: main.cs vector3d.dll
	mcs -target:exe -out:$@ -reference:$(word 2, $^) @<

vector3.dll: vector3d.cs
	mcs -target:library -out:$@ @<

clean:
	rm -f *.exe *.dll *.txt
