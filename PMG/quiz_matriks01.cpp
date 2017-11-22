#include<stdio.h> 
#include<conio.h>
#include<iostream>
#include<windows.h>
using namespace std;

void gotoxy(int x,int y)
{
	COORD coord;
	coord.X = x;
	coord.Y = y;
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE),coord);
	getch();
}

int x,y,brs,kol;
char op1,op2;
int A[10][10],B[10][10],C[10][10],X[10][10],Y[10][10];

main()
{
	gotoxy(1,1); printf("Masukan Operator 1: ");
	gotoxy(23,1); scanf("%s",&op1);
	gotoxy(1,2); printf("Masukan Operator 2: ");
	gotoxy(23,2); scanf("%s",&op2);
	
	gotoxy(1,4); printf("Baris Matrik: ");
	gotoxy(16,4); scanf("%d",&brs);
	gotoxy(1,5); printf("Kolom Matrik: ");
	gotoxy(16,5); scanf("%d",&kol);
	
/*input matrik A */

for(x=0;x<brs;x++)
{
	for(y=0;y<kol;y++)
	{
		gotoxy((y+1)*3,x+7);scanf("%d",&A[x][y]);
	}
}

/*input matrik B */

for(x=0;x<brs;x++)
{
	for(y=0;y<kol;y++)
	{
		gotoxy((y+5)*3,x+7);scanf("%d",&B[x][y]);
	}
}

/*input matrik C */

for(x=0;x<brs;x++)
{
	for(y=0;y<kol;y++)
	{
		gotoxy((y+9)*3,x+7);scanf("%d",&C[x][y]);
	}
}

/*jika operator-dan+*/
if((op1=='-')&&(op2=='+'))
{
	for(x=0;x<brs;x++)
	{
		for(y=0;y<kol;y++)
		{
			X[x][y]=A[x][y]-B[x][y]+C[x][y];
		}
	}
}
/*jika operator+dan-*/
if((op1=='+')&&(op2=='-'))
{
	for(x=0;x<brs;x++)
	{
		for(y=0;y<kol;y++)
		{
			X[x][y]=A[x][y]+B[x][y]-C[x][y];
		}
	}
}
/*jika operator+dan+*/
if((op1=='+')&&(op2=='+'))
{
	for(x=0;x<brs;x++)
	{
		for(y=0;y<kol;y++)
		{
			X[x][y]=A[x][y]+B[x][y]+C[x][y];
		}
	}
}

/*jika operator-dan-*/
if((op1=='-')&&(op2=='-'))
{
	for(x=0;x<brs;x++)
	{
		for(y=0;y<kol;y++)
		{
			X[x][y]=A[x][y]-B[x][y]-C[x][y];
		}
	}
}

/*cetak hasil*/
for(x=0;x<brs;x++)
{
	for(y=0;y<kol;y++)
	{
		gotoxy((y+13)*3,x+7);printf("%d",X[x][y]);
	}
}

getch();
return 0;
}
