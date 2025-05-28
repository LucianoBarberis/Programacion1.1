#include <stdio.h>
#include <stdlib.h>
/*
Algoritmo para sumar 3 enteros de 2 en 2
*/
int main(int argc, char *argv[]) {
	int num1;
	int num2;
	int num3;
	int result;
	int opc;
	
	do{
		printf("----------Algoritmo de Suma---------\n\n");
		printf("Ingresa el primer numero: ");
		scanf("%d", &num1);
		printf("\nIngresa el segundo numero: ");
		scanf("%d", &num2);
		result = num1 + num2;
		printf("\nLa suma de %d y %d da como resultado %d", num1, num2, result);
		printf("\n\nIngresa el tercer numero: ");
		scanf("%d", &num3);
		result = result + num3;
		printf("\nLa suma de %d, %d y %d da como resultado %d", num1, num2, num3, result);
		printf("\n\nPara salir escribir 0: ");
		scanf("%d", &opc);
	}while(opc != 0);
	printf("\n\n---------Saliendo del programa-----------");
	return 0;
}
