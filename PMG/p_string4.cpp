#include "stdio.h" 
#include "conio.h" 
#include "ctype.h" 
main() 
{
char karakter; 
//clrscr(); 
printf("Masukkan sebuah karakter : ");  
karakter = getche(); 
if(isupper(karakter)) 	//periksa apakah "karakter" adalah huruf kapital 
{ 
puts(" adalah huruf besar"); 
printf("Huruf kecilnya adalah : %c", tolower(karakter));
} 
else 
if(islower(karakter)) 	//periksa apakah "karakter" adalah huruf kecil 
{ 
puts(" adalah huruf kecil"); 
printf("Huruf besarnya adalah : %c", toupper(karakter)); 
} 
else
if(isdigit(karakter))	//periksa apakah "karakter" adalah digit   
puts(" adalah karakter digit"); 
else puts(" bukan huruf besar, huruf kecil atau digit"); 
getch(); 
}
