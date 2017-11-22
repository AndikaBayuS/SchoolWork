#include "stdio.h"
#include "stdlib.h" 
#include "conio.h" 
#include "math.h" 
main()
{ 
char x[4] = "100", y[5] ="10.3"; 
int a; 
float b;  
a = atoi(x);  
b = atof(y); 
printf("Semula A = %s B = %s\n", x,y); 
printf("Setelah dikonversi A = %i B = %.2f", a,b); 
getch();  
}
