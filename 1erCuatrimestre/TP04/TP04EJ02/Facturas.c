#include <stdio.h>

int main() {
    int nFactura, importe;
    int total = 0, masDiez = 0, factLow = 0;

    while (1) {
        printf("Ingrese el número de la factura (0 para salir): ");
        scanf("%d", &nFactura);

        if (nFactura == 0) {
            break;
        }

        printf("Ingrese el importe de la factura: ");
        scanf("%d", &importe);

        total += importe;

        if (importe > 10000) {
            printf("Factura N°: %d supera $10000\n", nFactura);
            masDiez++;
        }

        if (importe > 4000 && importe < 7000) {
            factLow++;
        }
    }

    printf("\n-------------------------------\n");
    printf("Total: $%d\n", total);
    printf("Más de $10000: %d\n", masDiez);
    printf("Entre $4000 y $7000: %d\n", factLow);
    printf("-------------------------------\n");

    return 0;
}