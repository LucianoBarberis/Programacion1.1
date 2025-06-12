#include <stdio.h>
#include <stdlib.h>
#define T 10

void divider() {
    printf("\n\n----------------------------------------------\n\n");
}

void ingresarArray(int arr[]);
void mostrarArray(int arr[]);
void ordenarArray(int arr[]);
int buscarDicotomico(int arr[]);

int main() {
    int array[T], search = 0;

    ingresarArray(array);
    mostrarArray(array);
    ordenarArray(array);
    search = buscarDicotomico(array);
    switch (search){
        case 1: printf("El objetivo existe en el array");break;
        case 2: printf("El objetivo no existe");break;
    }
    return 0;
}

void ingresarArray(int arr[]) {
    int i, dato;

    printf("---Ingreso de datos a un array---\n");
    for (i = 0; i < T; i++){
        do{
            printf("Ingresa el dato del indice %d/%d del array: \n", i, T);
            scanf("%d", &dato);
            system("cls");
        } while (dato <= 0);
        arr[i] = dato;
    }
}

void mostrarArray(int arr[]) {
    int i;
    printf("\n\n---Mostrando el array---\n");
    for (i = 0; i < T; i++){
        printf("El valor del indice %d del array es %d\n", i, arr[i]);
    }
    return;
}

// Selection Sort
void ordenarArray(int arr[]) {
    int i,j, aux;

    for (i = 0; i <= T-2; i++){
        for (j = i+1; j <= T-1; j++){
            if (arr[i] > arr[j]){
                aux = arr[i];
                arr[i] = arr[j];
                arr[j] = aux;
            }
        }
    }
    mostrarArray(arr);
}

int buscarDicotomico(int arr[]) {
    int izq = 0;
    int der = T - 1;
    int mitad, obj;

    printf("Escribe el numero que quieres buscar: ");
    scanf("%d", &obj);

    while (izq <= der) {
        mitad = izq + (der - izq) / 2;
        
        if (arr[mitad] == obj) {
            return 1;
        }
        
        if (arr[mitad] < obj) {
            izq = mitad + 1;
        } else {
            der = mitad - 1;
        }
    }
    return 2;
}