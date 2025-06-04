#include <stdio.h>
#include <stdlib.h>

void solicitarValor(float *capacidad, float *consumo);
float calcularDuracionBateria(float capacidad, float consumo);
int datosValidos(float consumo, float capacidad);
void mostrarResultados(float result);

int main() {
    int opc;
    int validador = 0;
    float  duracionBat,consumo, capacidad;
    printf("-----------Calculadora de duracion de bateria-----------\n\n");
    do{
        validador = 0;
        solicitarValor(&capacidad, &consumo);

        validador = datosValidos(consumo, capacidad);
        if (validador == 1){
            duracionBat = calcularDuracionBateria(capacidad, consumo);
            mostrarResultados(duracionBat);
        } else {
            printf("Error: Los valores ingresados no son validos");
        }
        do{
            printf("\nDesea calcular la duracion de bateria de otro dispositivo?\n1. Para ingresar un nuevo dispositivo\n2. Para Salir\n");
            scanf("%d", &opc);
            system("cls");
        } while (opc != 1 && opc != 2);
    } while (opc == 1);    
    system("pause");
    return 0;
}

void solicitarValor(float *capacidad, float *consumo){
    printf("Ingrese la capacidad de la bateria en mAh: ");
    scanf("%f", capacidad);
    printf("Ingrese el consumo de la bateria en mA: ");
    scanf("%f", consumo);
}


int datosValidos(float consumo, float capacidad){
    if(consumo > 0 && capacidad > 0) {
        return 1;
    }else {
        return 0;
    }
}

float calcularDuracionBateria(float capacidad, float consumo) {
    return capacidad / consumo;
}

void mostrarResultados(float result){
    printf("La duracion de la bateria es de %.2fhs\n", result);
}
