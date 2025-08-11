#include <stdio.h>
#include <stdlib.h>
#define D 15 // D = Dias


void input(float produccion[D], float *umbral);
float totalProduccion(float produccion[D]);
float promedioDiario(float produccion[D]);
int produccionSuperior(float produccion[D], float umbral); //Dias con mayor produccion al umbral establecido
float minProduccion(float produccion[D]);

int main() {
    int diasAltaProduccion, i;
    float producciones[D], total, promedio, minimaProduccion, umbral;

    input(producciones, &umbral);
    total = totalProduccion(producciones);
    promedio = promedioDiario(producciones);
    diasAltaProduccion = produccionSuperior(producciones, umbral);
    minimaProduccion = minProduccion(producciones);


    for (i = 0; i < D; i++){
        printf("Dia: %d --- Total produccion: %.2fKG\n", i+1, producciones[i]);
    }
    printf("Total producido: %.2fKG\n", total);
    printf("Promedio de produccion: %.2fKG\n", promedio);
    printf("Total de dias en los que se supero la marca: %d\n", diasAltaProduccion);
    printf("Minima produccion: %.2fKG", minimaProduccion);
    return 0;
}

void input(float produccion[D], float *umbral){
    int i;
    float kgDePan, objetivo;
    printf("---Ingreso de datos---\n");
    do{
        printf("Ingrese el objetivo de produccion diario: ");
        scanf("%f", &objetivo);
    } while (objetivo < 0);
    for (i = 0; i < D; i++){
        do{
            printf("Ingrese la produccion del dia %d: ", i+1);
            scanf("%f", &kgDePan);
        } while (kgDePan < 0);
        produccion[i] = kgDePan;
    }
    *umbral = objetivo;

    printf("\n");
}

float totalProduccion(float produccion[D]) {
    int i, sumador = 0;
    for (i = 0; i < D; i++){
        sumador += produccion[i];
    }
    return sumador;
}

float promedioDiario(float produccion[D]) {
    int i;
    float promedio = 0, sumador = 0;
    for (i = 0; i < D; i++){
        sumador += produccion[i];
    }
    if (sumador != 0 || i != 0){
        return promedio = sumador/i;
    }else {
        return 0;
    }
}

int produccionSuperior(float produccion[D], float umbral) {
    int i, contador = 0;
    for ( i = 0; i < D; i++){
        if (produccion[i] > umbral){
            contador++;
        }
    }
    return contador;
}

float minProduccion(float produccion[D]) {
    int i;
    float min = produccion[0];
    for (i = 0; i < D; i++){
        if (produccion[i] < min){
            produccion[i] = min;
        }
    }
    return min;
}