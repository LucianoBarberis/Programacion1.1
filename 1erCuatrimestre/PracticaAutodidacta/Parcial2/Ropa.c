#include <stdio.h>
#include <stdlib.h>
#define V 5
/*
3.	Tienda de Ropa "Moda Actual": Almacenar el monto de las ventas realizadas 
(en USD) por 10 vendedores en un día de ofertas especiales. Necesitan identificar
a los vendedores más efectivos.

Arreglo: float ventasVendedor[10];
Funciones Sugeridas: 
void ingresarVentas(float ventas[], int n);
float calcularTotalVentas(float ventas[], int n);
int encontrarVendedorMayorVenta(float ventas[], int n); (Obtener un máximo)
float calcularPorcentajeVentasVendedor(float ventas[], int n, int indiceVendedor); (Obtener porcentajes)
int contarVendedoresMetaSuperada(float ventas[], int n, float meta); (Contar condicionalmente)

*/
void input (float arr[V]);
void output(float total ,int mayorVenta, float porcentaje[V]/*, int supMeta*/);
float totalVentas(float arr[V]);
int encontrarVendedorMayorVenta(float arr[V]);
void calcularPorcentajeVentasVendedor(float arr[V], float porcentajes[V]);

int main() {
    int mayorVendedor, i;
    float total = 0;
    float ventasVendedor[V], porcentajes[V];
    input(ventasVendedor);
    total = totalVentas(ventasVendedor);
    mayorVendedor = encontrarVendedorMayorVenta(ventasVendedor);
    calcularPorcentajeVentasVendedor(ventasVendedor, porcentajes);

    printf("Mayor Vendedor: %d\n", mayorVendedor+1);
    printf("Total Ventas: $%.2f\n", total);
    for (i = 0; i < V; i++){
        printf("Vendedor N%d --- Ventas: $%.2f --- Porcentaje: %.2f%%\n", i+1, ventasVendedor[i], porcentajes[i]);
    }
    
    return 0;
}

void input (float arr[V]){
    int i;
    for (i = 0; i < V; i++){
        do{
            printf("---Ingrese las ventas de la vendedora %d ---\n$", i+1);    
            scanf("%f", &arr[i]);
        } while (arr[i] <= 0);
    }
}

float totalVentas(float arr[V]) {
    int i;
    float sum = 0;
    for (i = 0; i < V; i++){
        sum += arr[i];
    }
    return sum;
}

int encontrarVendedorMayorVenta(float arr[V]){
    int i, maxE;
    float  maxV = 0;

    for (i = 0; i < V; i++){
        if (arr[i] >= maxV){
            maxE = i;
            maxV = arr[i];
        }
    }
    return maxE;
}

void calcularPorcentajeVentasVendedor(float arr[V], float porcentajes[V]){
    int i;
    float total = 0;
    for (i = 0; i < V; i++){
        porcentajes[i] = 0;
    }
    for (i = 0; i < V; i++){
        total += arr[i];
    }
    for (i = 0; i < V; i++){
        if (total > 0){
            porcentajes[i] = ((float)arr[i] / total) * 100;
        }else {
            porcentajes[i] = 0;
        }
        
    }
}



