#include "stdio.h"
#include "conio.h"
main()
{
	int x,y;
	int *px;
	x= 87;
	px = &x;
	y = *px;
	
	printf("Alamat x = %p\n", &x);
	printf("Isi px = %p\n", px);
	printf("Isi xn = %i\n", x);
	printf("Nilai yang ditunjuk oleh px = %i\n", *px);
	printf("Nilai y = %i\n", y);
	getch();
}
