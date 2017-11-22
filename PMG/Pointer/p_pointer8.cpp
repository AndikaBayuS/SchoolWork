#include "stdio.h"
#include "conio.h"

int main()
{
	int x[5], *p, k;
	p = x;
	x[0] = 5;	// x[0] diisi dengan 5 sehingga x[0] = 5
	x[1] = x[0]; // x[1] diisi dengan x[0] sehingga x[1] = 5
	x[2] = *p + 2; // x[2] diisi dengan x[0] + 2 sehingga x[2] = 7
	x[3] = *(p+1) - 3; 	// x[3] diisi dengan x[1]  - 3 sehingga x[3] = 2
	x[4] = *(x + 2); // x[4] diisi dengan x[2] sehingga x[4] = 7
	for(k=0; k<5; k++)
	printf("x[%i] = %i\n", k, x[k]);
	getch(); 
}