#include <stdio.h>
#include <stdlib.h>

/*
Algoritmo para calcular el sueldo de un empleado con el valor de la hora fijo.
*/
int main(int argc, char *argv[]) {
	int sueldo, vh, ht;
	vh = 10;
	
	printf("Horas trabajadas: ");
	scanf("%d", &ht);
	sueldo = vh * ht;
	
	printf("Le corresponden $%d", sueldo);
	return 0;
}
