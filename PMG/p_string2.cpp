#include "stdio.h"
#include "conio.h"
#include "string.h"
main()
{ 
char satu[30] = "Teknik Komputer";
char dua[30] = "SMK TELKOM Purwokerto";
//clrscr();
strcat(satu, dua);
printf("Hasil penggabungannya : %s\n", satu);
printf("Jika diubah menjadi huruf kapital semua :\n");
printf("%s", strupr(satu));
printf("Jika diubah menjadi huruf kecil semua :\n");
printf("%s", strlwr(satu));
getch(); 
}  

