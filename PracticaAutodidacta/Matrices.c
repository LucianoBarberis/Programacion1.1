#include <stdio.h>
#include <stdlib.h>
#define T 3

void printMatriz(int mtz[T][T]);
void sumarMatriz(int mtz1[T][T], int mtz2[T][T], int result[T][T]);
void productMatriz3(int mtz1[T][T], int mtz2[T][T], int result[T][T]);

int main(){
    int matriz1[T][T];
    int matriz2[T][T];
    int result[T][T];
    int i, j;

    // ? Recorremos y le damos valores a las matrices
    for (i = 0; i < T; i++){
        for (j = 0; j < T; j++){
            matriz1[i][j] = i + j;
            matriz2[i][j] = (i + j) * 2;
        }
    }

    printf("---Matriz 1---\n");
    printMatriz(matriz1);
    printf("\n---Matriz 2---\n");
    printMatriz(matriz2);
    printf("\n---Matrices Sumadas---\n");
    sumarMatriz(matriz1, matriz2, result);
    printMatriz(result);
    printf("\n---Producto de Matrices---\n");
    productMatriz3(matriz1, matriz2, result);
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

void sumarMatriz(int mtz1[T][T], int mtz2[T][T], int result[T][T]) {
    int i, j;
    for (i = 0; i < T; i++){
        for (j = 0; j < T; j++){
            result[i][j] = mtz1[i][j] + mtz2[i][j];
        }
    }
}

void productMatriz3(int mtz1[T][T], int mtz2[T][T], int result[T][T]) {
    int i, j, k;

    for (i = 0; i < T; i++){
        for (j = 0; j < T; j++){
            result[i][j] = 0;
            for (k = 0; k < T; k++){
                result[i][j] += mtz1[i][k] * mtz2[k][j]; 
            }
        }
    }
}