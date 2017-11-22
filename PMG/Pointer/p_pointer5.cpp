#include "stdio.h"
#include "conio.h"
char *nama1 ="SPIDERMAN";
char *nama2 ="GATOTKACA";
main()
{
	char namax;
	puts("SEMULA : ");
	printf("Saya suka >> %s\n", nama1);
	printf("Tapi saya juga suka >> %s\n", nama2);
	printf("SEKARANG : ");
	printf("Saya suka >> %s\n", nama1);
	printf("Dan saya juga masih suka >> %s\n", nama2);
	getch();
}
