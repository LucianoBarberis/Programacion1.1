#include <stdio.h>
#include <stdlib.h>

double solicitarDouble(char* mensaje);
double calcularPorcentajeDescuento(int cantidad);
double calcularPrecioFinal(double precioUnitario, int cantidad, double porcentajeDescuento);
int solicitarCantidad();
void mostrarResultado(double precioFinal, double descuento);

int main() {
    int opc, cantidad;
    double precioUnitario, porcentajeDescuento, precioFinal;

    printf("-----------Sistema de Descuentos-----------\n\n");
    do {
        precioUnitario = solicitarDouble("Ingrese el precio unitario del producto: $");
        cantidad = solicitarCantidad();

        porcentajeDescuento = calcularPorcentajeDescuento(cantidad);
        precioFinal = calcularPrecioFinal(precioUnitario, cantidad, porcentajeDescuento);
        
        mostrarResultado(precioFinal, porcentajeDescuento);

        do {
            printf("\nDesea calcular otra compra?\n1. Si\n2. No\nOpcion: ");
            scanf("%d", &opc);
            system("cls");
        } while (opc != 1 && opc != 2);
    } while (opc == 1);

    return 0;
}

double solicitarDouble(char* mensaje) {
    double valor;
    int esValido;
    do {
        printf("%s", mensaje);
        esValido = scanf("%lf", &valor);
        while (getchar() != '\n');  // Limpia el buffer
        
        if (!esValido || valor <= 0) {
            printf("Error: Ingrese un valor numerico valido mayor a 0\n");
            esValido = 0;
        }
    } while (!esValido);
    return valor;
}

int solicitarCantidad() {
    int cantidad;
    do {
        printf("Ingrese la cantidad de unidades: ");
        scanf("%d", &cantidad);
        if (cantidad <= 0) {
            printf("Error: La cantidad debe ser mayor a 0\n");
        }
    } while (cantidad <= 0);
    return cantidad;
}

double calcularPorcentajeDescuento(int cantidad) {
    if (cantidad > 10) return 0.10;       // 10% de descuento
    if (cantidad >= 5) return 0.05;       // 5% de descuento
    return 0.0;                           // Sin descuento
}

double calcularPrecioFinal(double precioUnitario, int cantidad, double porcentajeDescuento) {
    double subtotal = precioUnitario * cantidad;
    double descuento = subtotal * porcentajeDescuento;
    return subtotal - descuento;
}

void mostrarResultado(double precioFinal, double descuento) {
    printf("\nResumen de la compra:\n");
    printf("Descuento aplicado: %.1f%%\n", descuento * 100);
    printf("Precio final: $%.2f\n", precioFinal);
}