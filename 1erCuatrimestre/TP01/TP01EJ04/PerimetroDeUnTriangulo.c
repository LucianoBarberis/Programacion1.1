#include <stdio.h>
#include <stdlib.h>

/*
Algoritmo para calcular el perimetro de un triangulo
*/
int main(int argc, char *argv[]) {
	int ladoA, ladoB, ladoC, result;
	
	printf("--------------Calculadora de perimetro de un triangulo---------------\n");
	printf("Ingrese el primer lado: ");
	scanf("%d", &ladoA);
	printf("Ingrese el segundo lado: ");
	scanf("%d", &ladoB);
	printf("Ingrese el tercer lado: ");
	scanf("%d", &ladoC);
	result = ladoA + ladoB + ladoC;
	printf("El perimetro de su triangulo es %d", result);
	return 0;
}
