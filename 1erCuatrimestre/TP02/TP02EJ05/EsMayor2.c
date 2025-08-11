#include <stdio.h>
#include <stdlib.h>

/*
    Este algoritmo toma 4 valores, los suma y verfica cual de las 2 sumas es mayor.
*/

int main()
{
    int val1, val2, val3, val4, suam1, suma2;
    printf("Ingrese el 1er valor: ");
    scanf("%d", &val1);
    printf("Ingrese el 2do valor: ");
    scanf("%d", &val2);
    printf("Ingrese el 3er valor: ");
    scanf("%d", &val3);
    printf("Ingrese el 4to valor: ");
    scanf("%d", &val4);

    suam1 = val1 + val2;
    suma2 = val3 + val4;
    if (suam1 > suma2)
    {
        printf("La suma de %d y %d es mayor que la suma de %d y %d\n", val1, val2, val3, val4);
    }else if (suma2 > suam1)
    {
        printf("La suma de %d y %d es mayor que la suma de %d y %d\n", val3, val4, val1, val2);
    }
    return 0;
}
