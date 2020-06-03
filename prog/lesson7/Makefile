out.txt: main.exe
	mono $< 1> $@

main.exe: main.cs integ8.dll
	mcs $< -reference:integ8.dll

integ8.dll: integ8.cs
	mcs $< -target:library -out:$@

clean:
	rm -f *.exe *.dll *.txt
