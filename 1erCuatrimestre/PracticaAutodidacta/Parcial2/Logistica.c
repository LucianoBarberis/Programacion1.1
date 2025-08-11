#include <stdio.h>
#include <stdlib.h>
#define R 7


void input(int entregas[R]);
int totalPaquetes(int entregas[R]);
float promedio(int entregas[R]);
int masEntregas(int entregas[R]);
void entregasPorRepartidor(int entregas[R]);
void output(int total, float promedio, int max);

int main() {
    int paquetesEntregados[R]; // R = a la cantidad de repartidores
    int totalEntregas, bestRepartidor;
    float promedioEntregas;

    input(paquetesEntregados);
    totalEntregas = totalPaquetes(paquetesEntregados);
    promedioEntregas = promedio(paquetesEntregados);
    bestRepartidor = masEntregas(paquetesEntregados);
    entregasPorRepartidor(paquetesEntregados);
    output(totalEntregas, promedioEntregas, bestRepartidor);

    return 0;
}

void input(int entregas[R]){
    int i, pack;
    for (i = 0; i < R; i++){
        do{
            printf("Ingresa los paquetes entregados del Repartidor N%d: ", i+1);
            scanf("%d", &pack);
        } while (pack < 0);
        entregas[i] = pack;
    }
}

int totalPaquetes(int entregas[R]) {
    int i, sumador = 0;
    for (i = 0; i < R; i++){
        sumador += entregas[i];
    }
    return sumador;
};

float promedio(int entregas[R]) {
    int i;
    float sumador = 0, promedio = 0;
    for (i = 0; i < R; i++){
        sumador += entregas[i];
    }
    if (sumador != 0 || i != 0){
        promedio = sumador/i;
        return promedio;
    }else {
        return 0;
    }
}

int masEntregas(int entregas[R]) {
    int i, maxE = 0, maxP = 0; //MaxE = Maximo entregador; MaxP = Maximo Paquetes
    for (i = 0; i < R; i++){
        if (entregas[i] > maxP) {
            maxE = i;
            maxP = entregas[i];
        }
    }
    return maxE;
}

void entregasPorRepartidor(int entregas[R]){
    system("cls");
    int i;
    printf("\n---Entregas por repartidor---\n");
    for (i = 0; i < R; i++){
        printf("Repartidor N%d --- Entregas: %d\n", i+1, entregas[i]);
    }
}

void output(int total, float promedio, int max) {
    printf("\n---Total Entregas---\n");
    printf("Total: %d\n", total);
    printf("\n---Promedio Entregas---\n");
    printf("Promedio: %.2f\n", promedio);
    printf("\n---Empleado Que Mas Repartio---\n");
    printf("Empleado N: %d", max+1);
}