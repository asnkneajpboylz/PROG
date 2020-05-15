out.txt: main.exe
	mono $< >out.txt

main.exe: main.cs integlib.dll
	mcs $< -reference:integlib.dll 

integlib.dll: integ.cs
	mcs $^ -target:library -out:$@
