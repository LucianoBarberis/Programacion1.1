#include <stdio.h>
#include <stdlib.h>

/*
    Este algoritmo determina si un numero es positivo, negativo o cero.
*/
int main()
{
    int val1;
    printf("Ingresa el primer valor: ");
    scanf("%d", &val1);
    if (val1 > 0)
    {
        printf("El valor es positivo\n");
    }else if (val1 < 0)
    {
        printf("El valor es negativo\n");
    }else
    {
        printf("Es 0 \n");
    }
    
    system("pause");
    return 0;
}