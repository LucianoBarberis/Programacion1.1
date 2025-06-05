#include <stdio.h>
#include <stdlib.h>

float solicitarUso();
int clasificarUso(float uso);
void actualizarContadores(int clasificacion, int *contUso1, int *contUso2, int *contUso3);
void mostrarContUso(int uso1, int uso2, int uso3);

int main() {
    int contUso1 = 0, contUso2 = 0, contUso3 = 0, clasificacion;
    float uso = 0;
    do{
        uso = solicitarUso();
        if (uso != 0){
            clasificacion = clasificarUso(uso);
            actualizarContadores(clasificacion, &contUso1, &contUso2, &contUso3 );
        }
    } while (uso != 0);
    mostrarContUso(contUso1, contUso2, contUso3);
    return 0;
}

float solicitarUso(){
    float use = 0;
    do{
        if (use < 0 ){
            printf("Error: El uso ingresado no es valido.\nTip: Si desea ver el total del uso de las maquinas ingresa 0\n\n");
        }
        
        printf("Ingresa el uso de la computadora en horas: ");
        scanf("%f", &use);
        system("cls");
    } while (use < 0);
    return use;
}

int clasificarUso(float uso) {
    if (uso <= 30){return 1;}
    if (uso > 30 && uso <= 120){return 2;}
    if (uso > 120){return 3;}
    else{return 0;}
}

void actualizarContadores(int clasificacion, int *contUso1, int *contUso2, int *contUso3){
    switch (clasificacion){
        case 1: (*contUso1)++;break;
        case 2: (*contUso2)++;break;
        case 3: (*contUso3)++;break;
    }
}

void mostrarContUso(int uso1, int uso2, int uso3){
    printf("-------------------------------------------------\n\n");
    printf("Maquinas con tiempo de uso Bajo:%d\n", uso1);
    printf("Maquinas con tiempo de uso Medio:%d\n", uso2);
    printf("Maquinas con tiempo de uso Extenso:%d", uso3);
    printf("\n\n-------------------------------------------------\n\n");
}