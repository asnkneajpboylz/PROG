class hello {
	static void Main(){
		string userName=System.Security.Principal.WindowsIdentity.GetCurrent().Name;
		System.Console.Write("hello, {0}",userName);
		
	}
}
