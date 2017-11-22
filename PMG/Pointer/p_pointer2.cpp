#include "stdio.h"
#include "conio.h"
main()
{
	float *x1,*x2,y;
	y = 13.45;
	x1 = &y;
	x2 = x1; /* isi variabel x1 disalin ke variabel x2 */
	printf("Nilai variabel y = %.2f ada di alamat %p\n", y,x1);
	printf("Nilai variabel y = %.2f ada di alamat %p\n", y,x2);
	getch();
}
