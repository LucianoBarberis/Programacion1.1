#include <stdio.h>
#include <stdlib.h>

int inputDeMonto();
int calcularPuntosCompra(int monto);
void acumularPuntos(int *acPoints, int newPoints);
void mostrarPuntos(int acPoints);

int main() {
    int monto = 0, puntos = 0, newPuntos = 0;
    printf("--------Sistema de puntos de lealtad cafeteria--------\n");

    do{
        monto = inputDeMonto();
        if (monto > 0){
            newPuntos = calcularPuntosCompra(monto);
            acumularPuntos(&puntos, newPuntos);
        }
    } while (monto > 0);
    mostrarPuntos(puntos);
    return 0;
}

int inputDeMonto(){
    int mont = 0;

    printf("Ingrese el monto de la compra: ");
    scanf("%d", &mont);

    return mont;
};

int calcularPuntosCompra(int monto){
    if (monto <= 10) {return 2;}
    if (monto >= 10 && monto <= 25) {return 5;}
    if (monto > 25){return 10;}
    else {return 0;}
};

void acumularPuntos(int *acPoints, int newPoints){
    *acPoints += newPoints;
};

void mostrarPuntos(int acPoints){
    printf("El total de puntos es de %d", acPoints);
};