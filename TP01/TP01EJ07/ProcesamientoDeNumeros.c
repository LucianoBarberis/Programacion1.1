#include <stdio.h>
#include <stdlib.h>

/*
ALgorimo que calcula la suma, resta y producto de dos numeros enteros.
*/
int main(int argc, char *argv[]) {
	int num1, num2, sum, prod, res;
	
	printf("Ingrese el primer valor: ");
	scanf("%d", &num1);
	printf("Ingrese el segundo valor: ");
	scanf("%d", &num2);
	
	sum = num1 + num2;
	prod = num1 * num2;
	res = num1 - num2;
	
	printf("Suma: %d \nProducto: %d \nResta: %d \n", sum, prod, res);
	return 0;
}
