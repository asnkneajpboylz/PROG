
out.txt: main.exe
	mono $< >$@

LIB= matlib.dll roots.dll

#main.exe: main.cs $(LIB)
#	mcs $< -r:$(call clist, $(LIB))

#roots.dll: roots.cs matlib.dll
#	mcs $< -t:library -r:matlib.dll -out:$@

#matlib.dll: QR.cs vector.cs matrix.cs 
#	mcs $^ -t:library -out:$@

main.exe: main.cs math.dll
	mcs $< -r:math.dll

math.dll: vector.cs QR.cs roots.cs matrix.cs
	mcs $^ -t:library -out:$@

comma:=,
empty:=
space:=$(empty) $(empty)
clist=$(subst $(space),$(comma),$(1))
