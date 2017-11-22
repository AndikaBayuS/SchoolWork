#include "stdio.h"
#include "conio.h"
main()
{
	static int tgl_lahir[]={13,9,1982};
	int *ptgl;
	ptgl = tgl_lahir;
	
	printf("Diakses dengan pointer");
	printf("Tanggal = %i\n", *ptgl);
	printf("Bulan = %i\n", *(ptgl + 1));
	printf("Tahun = %i\n", *(ptgl + 2));
	
	printf("\nDiakses dengan array biasa\n");
	printf("Tanggal = %i\n", tgl_lahir[0]);
	printf("Bulan = %i\n", tgl_lahir[1]);
	printf("Tahun = %i\n", tgl_lahir[2]);
	getch();
}
