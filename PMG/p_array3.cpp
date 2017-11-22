 #include <iostream>
#include <conio.h>
using namespace std;
main()
{
	//variable j untuk pembentuk baris 
	//varuable k untuk pembentuk kolom 
	int j,k;
	
	//menampilkan data 3 baris dan 3 kolom yang bertipe integer
	int data[3][3]={
					{4,3,2},
					{1,5,8},
					{2,9,3}};
	//melakukan looping sebanyak 2 kali 
	for(j=0;j<=2;j++)
	{
		for(k=0;k<=2;k++)
		{
			//menampilkan hasil 
			cout<<" "<<data[j][k];
		}
		cout<<endl;
	}
	getch();
}
