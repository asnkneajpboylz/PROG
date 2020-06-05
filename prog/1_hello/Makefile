
out.txt: hello.exe
	mono $< >$@

hello.exe: hello.cs	
	mcs $< 

clean: 
	rm -f out.txt hello.exe	
