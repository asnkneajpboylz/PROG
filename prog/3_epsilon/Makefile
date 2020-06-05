
out.txt : main.exe
	mono main.exe > out.txt

main.exe: main.cs boolfunc.dll
	mcs -reference:boolfunc.dll main.cs

boolfunc.dll: boolfunc.cs
	mcs -target:library boolfunc.cs

