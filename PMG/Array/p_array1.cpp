#include <iostream>
#include <conio.h>
using namespace std;
int main()
{
	//mendeklarasikan array angka dengan 5 buah elemen bertipe integer
	int angka [5];
	int i;
	cout<<"Input Angka [5 angka] : \n";
	for (i=0;i<5;i++)
	{
		//menginputkan nilai kedalam elemen array
		cout<<"Angka "<<(i+1)<<" :";
		cin>>angka[i]; //memasukkan nilai kedalam elemen aray
	 } 
	 //menampilkan nilai yang terdapat dalam array
	 cout<<"\n Angka yang telah kamu inputkan adalah";
	 for(i=0;i<5;i++)
	 {
	 	cout<<"\n Angka "<<(i+1)<<" : "<<angka[i];
	 }
	 	cout<<"\n Selamat Program Anda Berhasil ^_^";
	 	getch();
	 	return 0;
}
