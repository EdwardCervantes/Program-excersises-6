int A = 5;
double C = 7.2;
char e = 'a';
boolean b1 = true;
	
A = C;	//possible lossy conversion from double to int A = C;
A = D;	//ok
e = A;	//possible lossy conversion from int to char e = A;
b1 = A;	//incompatible types: int cannot be converted to boolean b1 = A;
e = b1;	//incompatible types: boolean cannot be converted to char e = b1;
b1 = C;	//incompatible types: double cannot be converted to boolean b1 = C;
D = b1; // incompatible types: double cannot be converted to float D = b1;