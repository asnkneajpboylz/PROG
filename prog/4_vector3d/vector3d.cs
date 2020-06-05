public struct vector3d{
	private double _x,_y,_z;//due to this I can use one vector input less in the functions 
	
	public double x{get{return _x;} set{_x=value;}}
	public double y{get{return _y;} set{_y=value;}}
	public double z{get{return _z;} set{_z=value;}}
//constructor
	public vector3d(double a, double b, double c){_x=a;_y=b;_z=c;}

//operators
	public static vector3d operator+(vector3d u, vector3d v){
		return new vector3d(u.x+v.x,v.y+u.y,u.z+v.z);}

	public static vector3d operator-(vector3d u, vector3d v){
		return new vector3d(u.x-v.x,u.y-v.y,u.z-v.z);}

	public static vector3d operator*(double a, vector3d v) {
		return new vector3d(a*v.x,a*v.y,a*v.z);}
	
	public static vector3d operator*(vector3d v, double a) {
		return a*v;
	}

	
	//scalar product
	public double dot_product(vector3d v) {
	double r=x*v.x+y*v.y+z*v.z;
	return r;}

	public vector3d vector_product( vector3d v){
	double a=y*v.z-z*v.y;
	double b=z*v.x-x*v.z;
	double c=x*v.y-y*v.x;
	return new vector3d(a,b,c);}
	
	public double magnitude(){
	double normsquared=this.x*this.x+this.y*this.y+this.z*this.z;
	return normsquared;}
	//magnitude is for checking which number is greater, remember root of sqare of big number

	
	public override string ToString(){
	return $"({this.x},{this.y},{this.z})\n"; 
	}
}
