#include <stdio.h>
#include <stdlib.h>

/*
Algoritmo para sumar 3 enteros
*/
int main(int argc, char *argv[]) {
	int num1, num2, num3, result, opc;
	
	do {
		printf("\n\n-------------------Algoritmo de Suma---------------------");
		printf("\nPrimer Numero: ");
		scanf("%d", &num1);
		printf("\nSegundo Numero: ");
		scanf("%d", &num2);
		printf("\nTercer Numero: ");
		scanf("%d", &num3);
		result = num1 + num2 + num3;
		printf("\nLa suma de %d, %d y %d da como resultado %d", num1, num2, num3, result);
		printf("\n\nPara salir escribir 0: ");
		scanf("%d", &opc);
	}while(opc != 0);
	printf("\n\n----------------Saliendo del Algoritmo---------------------\n\n");
	return 0;
}
