/*Crar un programa que solicite al usuario que ingrese el precio de un producto al inicio del año, y el precio del mismo al fin de año.
El programa debe calcular cual fue el porcentaje de aumento que tuvo ese producto en el año y mostrarlo por pantalla.*/
#include <iostream>
using namespace std;
int main(){
	float precioi,preciof,precioc=0,preciofinal=0;
	
	
	cout<<"Ingrese el precio inicial de un producto: "; cin>>precioi;
	cout<<"\n\nIngrese el precio final de el producto: "; cin>>preciof;
	
	precioc=preciof-precioi;
	preciofinal=precioc*100/precioi;
	
	cout<<"El aumento del producto fue del: "<<preciofinal<<"%";
	
	
	return 0;
}
