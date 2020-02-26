public struct vector3d{
	public double x,y,z;//due to this I can use one vector input less in the functions 
	
	
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
	public static double dot_product( vector3d v) {
	double r=0;
	r=this.x*v[0]+this.y*v[1]+this.z*v[2];
	return r}

	public static vector3d vector_product( vector3d v){
	vector3d r=new vector3d();
	r[0]=this.y*v[2]-this.z*v[1];
	r[1]=this.z*v[0]-this.x*v[2];
	r[2]=this.x*v[1]-this.y*v[0];
	
	return r}
	
	public static double magnitude(){}
	double normsquared=this.x*this.x+this.y*this.y+this.z*this.z);
	return normsquared;
	//magnitude is for checking which number is greater, remember root of sqare of big number
	


	//override to string, mess
	public string ToString(vector3d u){
	return string b=("{0},{1},{2}", x,y,z); 
//methods
	}





}
