#include "stdio.h"
#include "conio.h"

static const char *nama1 = "SPIDERMAN";
static const char *nama2 = "GATOTKACA";

int main()
{
	puts("SEMULA : ");
	printf("Saya suka >> %s\n", nama1);
	printf("Tapi saya juga suka >> %s\n", nama2);
	printf("SEKARANG : ");
	printf("Saya suka >> %s\n", nama1);
	printf("Dan saya juga masih suka >> %s\n", nama2);
	getch();
}