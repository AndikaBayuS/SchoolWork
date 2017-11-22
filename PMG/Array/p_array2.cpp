#include <iostream>
using namespace std;
int main()
{
	//mendeklarasikan array dan langsung menginisialisasi nilainya
	int x[5]={15,25,35,45,55};
	
	//menampilkan nilai yang terdapat dalam elemen array
	cout<<"Sebelum dilakukan perubahan nilai"<<endl;
	cout<<"x[0] ="<< x[0] <<endl;
	cout<<"x[1] ="<< x[1] <<endl;
	cout<<"x[2] ="<< x[2] <<endl;
	cout<<"x[3] ="<< x[3] <<endl;
	cout<<"x[4] ="<< x[4] <<endl;
	
	//mengubah elemen ke-1 dan ke-2
	x[0] = 12;
	x[1] = 20;
	
	//menampilkan kembali nilai yang terdapat nilai yang terdapat dalam elemen array 
	cout<<"Setelah dilakukan perubahan nilai"<<endl;
	cout<<"x[0] ="<< x[0] <<endl;
	cout<<"x[1] ="<< x[1] <<endl;
	cout<<"x[2] ="<< x[2] <<endl;
	cout<<"x[3] ="<< x[3] <<endl;
	cout<<"x[4] ="<< x[4] <<endl;
	return 0;
}
