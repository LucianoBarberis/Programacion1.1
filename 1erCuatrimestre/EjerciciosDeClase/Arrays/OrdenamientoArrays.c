#include <stdio.h>
#include <stdlib.h>
#define T 5

int main() {
    // ? Ordenamiento de un array (Bubble sort)
    int array[T] = {5, 2, 3, 7, 9};
    int i, j, aux;
    
    printf("Array desordenado\n");
    for (i = 0; i < T; i++){
        printf("%d ", array[i]);
    }
    for (i = 0; i <= T; i++){
        for (j = i+1; j <= T-1; j++){
            if (array[i] > array[j]){
                aux = array[i];
                array[i] = array[j];
                array[j] = aux;
            }
            
        }
    }
    printf("\nArray ordenado de menor a mayor \n");
    for (i = 0; i < T; i++){
        printf("%d ", array[i]);
    }
    
    return 0;
}