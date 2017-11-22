#include "stdio.h"
#include "conio.h"

int main()
{
	int a = 100, b = 200, *pa, *pb;
	pa = &a;
	pb = &b;
 // This is not a very good way to describe pointer address
	if(*pa < *pb)
	printf("pa menunjuk ke memori lebih rendah dari pb\n");
	if(*pa == *pb)
	printf("pa menunjuk ke memori yang sama dengan pb\n");
	if(*pa > *pb)
	printf("pa menunjuk ke memori lebih tinggi dari pb\n");
	getch();
}