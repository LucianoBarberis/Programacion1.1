#include <stdio.h>
#include <stdlib.h>
#define T 10

void input(int vector[]);
void printV(int vector[]);
void printVInv(int vector[]);
void sumaElV(int vector1[]);
void productElV(int vector1[]);
void printPar(int vector[]);
void printImpar(int vector[]);
void sort(int vector[T]);

int main() {
    int vector[T], opc = 0;

    input(vector);
    do{
        printf("Queres ordenar el array antes de la ejecucion? \n1. Si \n2. No\nOpcion:");
        scanf("%d", &opc);
    } while (opc != 1 && opc != 2);
    if (opc == 1){
        sort(vector);
    }
    printV(vector);
    printVInv(vector);
    printPar(vector);
    printImpar(vector);
    printf("\n---Operaciones con el vector---\n");
    sumaElV(vector);
    productElV(vector);
    return 0;
}

void printV(int vector[]) {
    int i;
    printf("\n---Vector---\n");
    for (i = 0; i < T; i++){
        printf("%d ", vector[i]);
    }
    printf("\n");
}

void printVInv(int vector[]) {
    int i;
    printf("\n---Vector Invertido---\n");
    for (i = T-1; i >= 0; i--){
        printf("%d ", vector[i]);
    }
    printf("\n");
}

void sumaElV(int vector1[]) {
    int sumador = 0, i;
    for (i = 0; i < T; i++){
        sumador += vector1[i];
    }
    printf("La suma total del Vector es: %d\n", sumador);
}

void productElV(int vector1[]){
    int producto = 1, i;
    for (i = 0; i < T; i++){
        producto = producto * vector1[i];
    }
    printf("El producto total del Vector es: %d\n", producto);
};

void printPar(int vector[]) {
    int i;
    printf("\n---Valores Pares---\n");
    for (i = 0; i < T; i++){
        if (vector[i] % 2 == 0){
            printf("%d ", vector[i]);
        }
    }
    printf("\n");
}

void printImpar(int vector[]) {
    int i;
    printf("\n---Valores Impares---\n");
    for (i = 0; i < T; i++){
        if (vector[i] % 2 != 0){
            printf("%d ", vector[i]);
        }
    }
    printf("\n");
}

void input(int vector[]){
    int i;
    for (i = 0; i < T; i++){
        printf("Ingresa el valor del index %d/%d: ", i+1, T);
        scanf("%d", &vector[i]);
        system("cls");
    }
}

void sort(int vector[T]){
    int i,j,aux;
    for (i = 0; i <= T; i++){
        for (j = i+1; j <= T-1; j++){
            if (vector[i] > vector[j]){
                aux = vector[i];
                vector[i] = vector[j];
                vector[j] = aux;
            }
            
        }
    }
}