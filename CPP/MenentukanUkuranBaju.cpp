#include <iostream>
using namespace std;

int main() {
	int panjang, lebar;
	string ukuran;
	cout << "Menentukan ukuran Baju " << endl;
  	cout << "Panjang : "; cin >> panjang;
  	cout << "Lebar : "; cin >> lebar;
  	
  	if (panjang >= 43 && panjang <= 51) {
	  ukuran = "S";
  	}
  	
  	cout << "Ukuran Kaos : " << ukuran;
	   
  	return 0;
}
