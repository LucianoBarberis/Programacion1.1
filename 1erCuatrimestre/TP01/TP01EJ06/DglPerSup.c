#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/*
Algoritmo para calgular la diagonal, el perimetro y la superficie de un rectangulo
*/
int main(int argc, char *argv[]) {
	float ladoA, ladoB, dgl, per, sup;
	
	printf("Ingrese el primer lado de su rectangulo: ");
	scanf("%f", &ladoA);
	printf("Ingrese el segundo lado de su rectangulo: ");
	scanf("%f", &ladoB);
	
	dgl = sqrt(pow(ladoA,2)+pow(ladoB,2));
	per = (ladoA + ladoB) * 2;
	sup = ladoA * ladoB;
	
	printf("------------------------------------------\n");
	printf("Diagonal: %.2f\nPerimetro: %.2f\nSuperficie: %.2f", dgl, per, sup);
	printf("\n------------------------------------------");
	return 0;
}
