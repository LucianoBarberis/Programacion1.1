#include <stdlib.h>
#include <stdio.h>

/*
    Este algoritomo calcula el promedio de 3 valores y muestra los que son mayores al promedio.
*/
int main()
{
    float val1, val2, val3, promedio;
    printf("Ingrese el 1er valor: ");
    scanf("%f", &val1);
    printf("Ingrese el 2do valor: ");
    scanf("%f", &val2);
    printf("Ingrese el 3er valor: ");
    scanf("%f", &val3);

    promedio = (val1 + val2 + val3)/3;

    printf("Promedio: %.2f\n", promedio);

    if (val1 > promedio)
    {
        printf("%.2f\n", val1);
    }
    if (val2 > promedio)
    {
        printf("%.2f\n", val2);
    }
    if (val3 > promedio)
    {
        printf("%.2f\n", val3);
    }
    return 0;
}
