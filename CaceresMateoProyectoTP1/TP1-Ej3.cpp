/*A partir de una conocida cantidad de dias que el usuario ingresa a traves del teclado, escriba un programa para convertir los dias en horas
en minutos y en segundos.
*/
#include<iostream>
using namespace std;
int main(){
	int dias,horas=0,minutos=0,segundos=0;
	
	cout<<"Ingrese una cantidad de dias: "; cin>>dias;
	cout<<endl<<endl;
	horas=dias*24;
	minutos=horas*60;
	segundos=minutos*60;
	
	cout<<dias<<" DIA/S\t\t"<<horas<<" HORAS\t"<<minutos<<" MINUTOS\t"<<segundos<<" SEGUNDOS\t";
	
	return 0;
}