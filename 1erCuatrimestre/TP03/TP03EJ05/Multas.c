#include <stdio.h>

int main() {
    int masCuarenta = 0, index, cantidad = 5;
    float input, sumaMasCuarenta = 0, totalMultas = 0, porcentaje;

    for (index = 1; index <= cantidad; index++) {
        printf("Ingrese el valor de la multa %d: $", index);
        scanf("%f", &input);

        totalMultas += input;

        if (input > 40000) {
            masCuarenta++;
            sumaMasCuarenta += input;
        }
    }

    porcentaje = (sumaMasCuarenta / totalMultas) * 100;

    printf("Cantidad de multas mayores a $40000: %d\n", masCuarenta);
    printf("Porcentaje del total que representan: %.2f%%\n", porcentaje);

    return 0;
}