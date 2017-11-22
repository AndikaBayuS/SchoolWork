#include "stdio.h"
#include "conio.h"
#include "string.h"
main()
{
	char nama[25];
	strcpy(nama, "Achmad Solichin ");
	printf("Nama : %s", nama);
	printf("Banyaknya karakter nama Anda adalah : %i", strlen(nama));
	getch();
}
