#include <stdio.h>

int main() {
    int opc, sueldo, suma = 0, count = 0;
    float promedio;

    do {
        printf("1. Para Añadir un sueldo\n");
        printf("0. Para Ver resultados\n");
        printf("Ingrese una opción: ");
        scanf("%d", &opc);

        switch (opc) {
            case 1:
                printf("Sueldo: ");
                scanf("%d", &sueldo);
                suma += sueldo;
                count++;
                break;
            case 0:
                printf("Calculando resultados...\n");
                break;
            default:
                printf("Opción no válida...\n");
                break;
        }
    } while (opc != 0);

    if (count != 0) {
        promedio = (float)suma / count;
    } else {
        promedio = 0;
    }

    printf("Suma total de los sueldos: $%d\n", suma);
    printf("Promedio total de los sueldos: $%.2f\n", promedio);

    return 0;
}