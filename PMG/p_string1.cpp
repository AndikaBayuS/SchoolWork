#include "stdio.h" 
#include "conio.h" 
#include "string.h" 
main() 
{
char nama[25]; 
strcpy(nama, "Asto Arianto Dan Andika Dwi Santoso ");
printf("Nama : %s", nama);
printf("Banyaknya karakter nama Anda adalah : %i", strlen(nama));
getch(); 
}

//strlen berfungsi untuk menghitung jumlah karakter pada nama
