#include "stdio.h" 
#include "conio.h" 
#include "stdlib.h"
#include "math.h"
main() 
{ 
int x, y, z; 
//clrscr(); 
printf("Menentukan bilangan terbesar dan terkecil\n");
printf("X =  ");scanf("%i", &x);
printf("Y =  ");scanf("%i", &y);
printf("Z =  ");scanf("%i", &z);
printf("\nBilangan terbesar : %i", max(max(x, y), z));
printf("\nBilangan terkecil : %i", min(min(x, y), z));
getch(); 
}
