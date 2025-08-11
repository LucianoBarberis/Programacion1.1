#include <stdio.h>
#include <stdlib.h>

/*
Algoritmo que calcula el sueldo de un empleado de una concesionaria de autos.
*/
int main()
{
    int vehiculos, valorVehiculo, recaudado;
    float sueldo = 500, comision;

    printf("-------Liquidacion de sueldos Concesionaria-------\n\n");
    printf("Cuantos vehiculos vendio?: ");
    scanf("%d", &vehiculos);

    if(vehiculos != 0){
        printf("Valor del tipo de vehiculo vendido?: ");
        scanf("%d", &valorVehiculo);

        recaudado = valorVehiculo * vehiculos;
        comision = recaudado * 0.10;
        sueldo += comision + (vehiculos * 50);

        printf("-----------------------------\n");
        printf("Sueldo minimo: $500\n");
        printf(" -----\n");
        printf(" Vehiculos vendidos: %d\n", vehiculos);
        printf(" Total recaudado: $%d\n", recaudado);
        printf(" 10%% de cada vehiculo: $%.2f\n", valorVehiculo * 0.10);
        printf(" -----\n");
        printf("Total valor constante x c/u ($50): $%d \n", vehiculos * 50);
        printf("Total correspondiente por venta: $%.2f \n", comision);
        printf("Su sueldo total es de: $%.2f \n", sueldo);
        printf("-----------------------------\n");
    } else {
        printf("\nLe corresponden $%.2f", sueldo);
    }
    return 0;
}
