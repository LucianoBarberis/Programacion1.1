#include <stdio.h>
#include <stdlib.h>

float solicitarGasto(); //Retorna el el gasto por ese articulo
float sumarGastos(float gastos, float newGasto); //Retorna el nuevo total de gastos
void outputTGastos(float tGastos); //Muestra en consola los gastos totales

int main() {
    float gastos, nuevoGasto;

    printf("Bienvenido a la calculadora de gastos\n");

    do{
        nuevoGasto = solicitarGasto();
        if (nuevoGasto != -1){gastos = sumarGastos(gastos, nuevoGasto);}
    }while (nuevoGasto != -1);

    outputTGastos(gastos);

    return 0;
}

float solicitarGasto() {
    float spent = 0;

    do{
        if (spent < -2){
            printf("Error: El monto ingresado no es valido.\nTip: Si desea ver el total de gastos ingresa $-1\n");
        }
        printf("\n---------Ingrese el nuevo gasto---------\nNuevo Gasto: $");
        scanf("%f", &spent);
        system("cls");
    } while (spent < -2);

    return spent;
}

float sumarGastos(float gastos, float newGasto) {
    return gastos += newGasto;
}

void outputTGastos(float tGastos){
    printf("-------------------------------------------------\n\n");
    printf("El total de gastos durante el viaje fue de $%.2f", tGastos);
    printf("\n\n-------------------------------------------------\n\n");
}