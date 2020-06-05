out.txt: main.exe
	mono main.exe  >out.txt

main.exe: main.cs vector3d.dll
	mcs main.cs -r:vector3d.dll 

vector3d.dll: vector3d.cs
	mcs vector3d.cs -target:library -out:$@ 

clean:
	rm -f *.exe *.dll *.txt
