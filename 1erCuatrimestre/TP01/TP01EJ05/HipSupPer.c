#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/*
Algorimo para calcular el perimetro, la hipotenusa y la superficie de un triangulo rectangulo
*/
int main() {
	float ladoA, ladoB, hip, per, sup;
	
	printf("Ingrese el primer lado: ");
	scanf("%f", &ladoA);
	printf("Ingrese el segundo lado: ");
	scanf("%f", &ladoB);
	
	hip = sqrt(pow(ladoA,2)+pow(ladoB,2));
	per = ladoA + ladoB + hip;
	sup = (ladoA*ladoB)/2;
	
	printf("-----------------------------------\n");
	printf("Hipotenusa: %.2f\nPerimetro: %.2f\nSuperficie: %.2f", hip, per, sup);
	printf("\n-----------------------------------");
	return 0;
}
