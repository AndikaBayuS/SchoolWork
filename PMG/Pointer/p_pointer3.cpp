#include "stdio.h"
#include "conio.h"
main()
{
	int nilai[3], *penunjuk;
	nilai[0] = 125;
	nilai[1] = 345;
	nilai[2] = 750;
	penunjuk = &nilai[0];
	printf("Nilai %i ada di alamat memori %p\n", *penunjuk,penunjuk);
	printf("Nilai %i ada di alamat memori %p\n", *(penunjuk+1), penunjuk+1);
	printf("Nilai %i ada di alamat memori %p\n", *(penunjuk+2), penunjuk+2);
	getch();
}
