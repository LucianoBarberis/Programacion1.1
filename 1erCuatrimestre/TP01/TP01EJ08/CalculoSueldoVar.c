#include <stdio.h>
#include <stdlib.h>

/*
ALgoritmo para calcular el sueldo de un empleado.
*/
int main(int argc, char *argv[]) {
	int vh, tt, sueldo;
	
	printf("Valor por hora trabajada: ");
	scanf("%d", &vh);
	printf("Horas trabajadas: ");
	scanf("%d", &tt);
	sueldo = tt * vh;
	
	printf("Le Corresponden $%d", sueldo);
	return 0;
}
