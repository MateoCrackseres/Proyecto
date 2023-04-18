//Solicitar al usuario que ingrese la base y altura de un rectangulo, calcular y mostrar por pantalla el area y perimetro del mismo
#include <iostream>
using namespace std;
int main(){
	int area=0,br,ar,perimetro=0;
	
	cout<<"Ingrese la longitud de la base del ractangulo: "; cin>>br;
	cout<<"\n\nIngrese la altura del rectangulo: "; cin>>ar;
	area=br*ar;
	perimetro=(2*ar)+(2*br);
	
	cout<<"\nAREA DEL RECTANGULO:\n\t"<<area;
	cout<<"\n\nPERIMETRO DEL RACTANGULO:\n\t"<<perimetro;
	
	return 0;
}
