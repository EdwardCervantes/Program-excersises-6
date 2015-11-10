#include <stdio.h>
#include <stdlib.h>
int main(void) 
{
	int i=3;
       	float f=2.6;
	long  y = 5;
int r1=i+f;
float r2=i+f;
double d=5.8;
	char c='h';
	int r3=c+i;
	double r4=f+d;
printf("int: %d\n", r1);
printf ("float: %f\n", r2); 
printf ("int: %d\n", r3); 
printf ("double: %f\n", r4); 
	return 0;
}
Los resultados son:
int: 5
float: 5.600000
int: 107
double: 8.400000