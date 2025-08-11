#include <stdio.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
	int vh, ch, emp, sdo;
	
	printf("----------Calculadora de Sueldo----------\n\n");
	printf("Ingresa el identificador del empleado: ");
	scanf("%d", &emp);
	printf("Cantidad de horas trabajadas: ");
	scanf("%d", &ch);
	printf("Valor por hora: ");
	scanf("%d", &vh);
	sdo = vh*ch;
	printf("\n-------------------------------------\n\n");
	printf("Empleado numero: %d", emp);
	printf("\nSueldo a pagar: $%d", sdo);
	printf("\n\n-------------------------------------\n");
	return 0;
}
