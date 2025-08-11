#include <stdio.h>
#include <stdlib.h>

/*
    Este algoritmo determina si dos valores son iguales.
*/
int main()
{
    int val1, val2;
    printf("Ingrese el primer valor: ");
    scanf("%d", &val1);
    printf("Ingrese el segundo valor: ");
    scanf("%d", &val2);
    if (val1 == val2){
        printf("Los valores son iguales\n");
    }
    system("pause");
    
    return 0;
}
