#include "stdio.h" 
#include "conio.h" 
#include "stdlib.h" 
main() 
{
	int x, y; 
	div_t hasil; 
	printf("Menghitung sisa dan hasil pembagian x dengan y\n"); 
	printf("x =  ");scanf("%i", &x); 
	printf("y =  ");scanf("%i", &y); 
	hasil = div(x,y); 
	printf("\n\n %3i div %3i = %3i sisa %3i", x, y, hasil.quot, hasil.rem); 
	getch();  
}
