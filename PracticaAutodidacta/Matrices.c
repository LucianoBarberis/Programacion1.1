#include <stdio.h>
#include <stdlib.h>
#define T 3

void printMatriz(int mtz[T][T]);

int main(){
    int matriz1[T][T];
    int matriz2[T][T];
    int result[T][T];
    int i, j;

    for (i = 0; i < T; i++){
        for (j = 0; j < T; j++){
            matriz1[i][j] = i + j;
            matriz2[i][j] = i + j;
        }
    }
    printMatriz(matriz1);
    printf("\n");
    printMatriz(matriz2);
    for (i = 0; i < T; i++){
        for (j = 0; j < T; j++){
            result[i][j] = matriz1[i][j] + matriz2[i][j];
        }
    }
    printf("\n");
    printMatriz(result);
    return 0;
}

void printMatriz(int mtz[T][T]) {
    for (int i = 0; i < T; i++){
        for (int j = 0; j < T; j++){
            printf("%d ", mtz[i][j]);
        }
        printf("\n");
    }
}