#include <stdio.h>
#include <stdlib.h>
#define T 10

void divider() {
    printf("\n\n----------------------------------------------\n\n");
}

int main() {
    int array[T];
    int i = 0;
    int dato = 0;

    for (i = 0; i < T; i++){
        dato = 1;
        do{
            if (dato <= 0){
                printf("\nError!!! El valor debe ser positivo\n\n");
            }
            printf("Ingrese un dato numerico positivo: ");
            scanf("%d", &dato);
            system("cls");
            array[i] = dato;
        } while (dato <= 0);
    }
    printf("Los datos del array son los siguientes: ");
    for (i = 0; i < T; i++){
        printf("%d ", array[i]);
    }
    return 0;
}