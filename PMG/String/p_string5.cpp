#include "stdio.h" //Digunakan untuk operasi input dan output
#include "conio.h" //Menampilkan hasil  contoh getch() clscr()
#include "math.h"  // Digunakan untuk melakukan operasi Matematika
main() //pembuka/awal dari eksekusi program
{	
	int x, y; //tipe data integrer
	float z;//tipe data float
	
	printf("Menghitung x Pangkat y\n");//printf membuat output tampilan
	printf("x = "); scanf("%i", &x); //%i membaca inputan nilai desimal
	printf("y = "); scanf("%i", &y); //scanf berfungsi untuk menerima inputan dari user
	printf("%i dipangkatkan dengan %i adalah %7.2lf \n", x, y, pow(x, y)); // \n untuk meletakkan baris baru/ganti baris & pow = memberikan nilai berupa double
	getch(); //menghentikan proses yang sedang berjalan
	
	printf("Menghitung akar suatu bilangan z\n");
	printf("z = "); scanf("%f", &z);
	printf("Akar dari %f adalah %7.2lf", z, sqrt(z)); //%f output data double/pecahan dan Sqrt berfungsi untuk memberikan nilai akar kuadrat
	getch();
}
