#include "stdio.h" 
#include "conio.h" 
#include "math.h" 
main() 
{ 
	float sudut;
	 
	printf("Menghitung nilai sinus, cosinus dan tangens\n");
	printf("Masukkan sudut : ");scanf("%f", &sudut);
	printf("Nilai sinus %.2f derajat adalah %.3f \n", sudut, sin(sudut));
	printf("Nilai cosinus %.2f derajat adalah %.3f \n", sudut, cos(sudut)); 
	printf("Nilai tangens %.2f derajat adalah %.3f \n", sudut, tan(sudut)); 
	getch();   
}

