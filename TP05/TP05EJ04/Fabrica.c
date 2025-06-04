#include <stdio.h>
#include <stdlib.h>

float solicitarPeso();
int clasificarPeso(float weight);
void actualizarContadores(int *low, int *normal, int *overWeight, int clasificacion);
void output(int low, int normal, int overweight);


int main() {
    float peso = 0;
    int bajo = 0, conforme = 0, sobrepeso = 0, opc = 1, clasificacion = 0;
    do{
        peso = solicitarPeso();
        clasificacion = clasificarPeso(peso);
        actualizarContadores(&bajo, &conforme, &sobrepeso, clasificacion);
        do{
            if (opc < 1 || opc > 2){
                printf("\nError: ingresa una opcion valida.\n\n");
            }
            printf("Desea ingresar un nuevo producto?\n1. Para ingresar un nuevo producto\n2. Para Salir y ver resultados\n");
            scanf("%d", &opc);
            system("cls");
        } while (opc < 1 || opc > 2);
    } while (opc != 2);
    output(bajo, conforme, sobrepeso);
    return 0;
}

float solicitarPeso(){
    float weight = 0;
    do{
        printf("Cual es el peso del producto?: ");
        scanf("%f", &weight);
        system("cls");
    } while (weight <= 0);
    return weight;
}

int clasificarPeso(float weight) {
    if (weight < 190){return 1;}
    if (weight >= 190 && weight <= 210){return 2;}
    if (weight > 210){return 3;}
    else{return 0;}
}

void actualizarContadores(int *low, int *normal, int *overWeight, int clasificacion){
    switch (clasificacion){
        case 1: (*low)++;break;
        case 2: (*normal)++;break;
        case 3: (*overWeight)++;break;
    }
}

void output(int low, int normal, int overweight) {
    printf("\n\n____________________________________________");
    printf("\nNumero de productos con bajo peso: %d", low);
    printf("\nNumero de productos con peso optimo: %d", normal);
    printf("\nNumero de productos con sobrepeso: %d", overweight);
    printf("\n____________________________________________\n\n");
};