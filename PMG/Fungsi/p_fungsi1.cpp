#include "stdio.h"
#include "conio.h"
float tambah(float x, float y); /*prototype fungsi tambah(), ada titik koma*/
float kurang(float x, float y);
float bagi(float x, float y);
float kali(float x, float y);
main()
{
	float a,b,c,d,e,f;
	printf("A = "); scanf("%f", &a);
	printf("B = "); scanf("%f", &b);
	c = tambah(a,b);
	d = kurang(a,b);
	e = bagi(a,b);
	f = kali(a,b);
	printf("A + B = %.2f \n", c);
	printf("A - B = %.2f \n", d);
	printf("A / B = %.2f \n", e);
	printf("A * B = %.2f", f);
	getch();
}
float tambah(float a, float b)
{
	return(a+b);
}
float kurang(float a, float b)
{
	return(a-b);
}
float bagi(float a, float b)
{
	return(a/b);
}
float kali(float a, float b)
{
	return(a*b);
}                                                                          
