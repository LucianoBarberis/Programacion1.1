#include <stdio.h>
#include <stdlib.h>

int main()
{
    int count, sumador, num, cantidad = 2;
    float promedio;

    for (count = 0; count < cantidad; count++)
    {
        printf("Ingrese el num %d/%d: ", count, cantidad);
        scanf("%d", &num);
        sumador += num;
    };
    promedio = sumador / cantidad;
    printf("El promedio es: %.2f", promedio);
    return 0;
}
