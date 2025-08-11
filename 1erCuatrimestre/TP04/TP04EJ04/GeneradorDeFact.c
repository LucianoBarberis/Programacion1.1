#include <stdio.h>

int main() {
    int nFact, nArt, totalSell, precioU;
    float total, totalConIVA;

    while (1) {
        printf("Ingresa el num de factura (0 para salir): ");
        scanf("%d", &nFact);

        if (nFact == 0) {
            printf("Saliendo del sistema...\n");
            break;
        }

        printf("Ingresa el num de articulo: ");
        scanf("%d", &nArt);

        printf("Ingresa el total de vendidos: ");
        scanf("%d", &totalSell);

        printf("Ingresa el precio unitario: ");
        scanf("%d", &precioU);

        total = precioU * totalSell;
        totalConIVA = total * 1.21;

        printf("\n------------------------------\n");
        printf("Factura N°: %d\n", nFact);
        printf("Artículo N°: %d\n", nArt);
        printf("Vendidos: %d\n", totalSell);
        printf("Precio unitario: $%d\n", precioU);
        printf("Total: $%.2f\n", total);
        printf("Total con IVA: $%.2f\n", totalConIVA);
        printf("------------------------------\n\n");
    }

    return 0;
}