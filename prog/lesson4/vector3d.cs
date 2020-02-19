public struct vector3d{
	public double x,y,z;
	
	
//constructor
	public vector3d(double a, double b, double c){x=a;y=b;z=c;}
	public vector3d(){x=0;y=0;z=0;}
//operators
	public static vector3d operator+(vector3d u, vector3d v){
		vector3d r= new vector3d();
		for(int i=0; i=2; i++) r[i]=u[i]+v[i];
		return r}

	public static vector3d operator-(vector3d u, vector3d v){
		vector3d r=new vector3d();
		for(int i=0;i=2;i++) r[i]=u[i]-v[i];
		return r}

	public static vector3d operator*(double a, vector3d v) {
		vector3d r=new vector3d();
		for(int i=0;i=2;i++) r[i]=a*v[i];
		return r}
	
	public static vector3d operator*(vector3d v, double a) {
		return a*v;


	
	//scalar product
	public static double dot_product(vector3d u, vector3d v) {
	double r=0;
	for(int i=0;i=2; i++) r=r+u[i]*v[i];
	return r}

	public static vector3d vector_product(vector3d u, vector3d v){
	vector3d r=new vector3d();
	r[0]=u[1]*v[2]-u[2]*v[1];
	r[1]=u[2]*v[0]-u[0]*v[2];
	r[2]=u[0]*v[1]-u[1]*v[0];
	
	return r}
	
	public static double magnitude(){}
	//magnitude is for checking which number is greater, remember root of sqare of big number
	


	//override to string, mess
	public string ToString(vector3d u){
	return string b=("{0},{1},{2}", x,y,z); 
//methods
	}





}
