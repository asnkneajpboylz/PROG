DIR=~/pracpro/PROG/prog/problem3
LIB=\
    $(DIR)/vector.cs\
    $(DIR)/matrix.cs\
    $(DIR)/QR.cs

out.txt: main.exe
	mono $< >$@

main.exe: main.cs roots.dll
	mcs $< -r:roots.dll

roots.dll: roots.cs matlib.dll
	mcs $< -t:library -r:matlib.dll -out:$@

matlib.dll: $(LIB)
	mcs $^ -t:library -out:$@
