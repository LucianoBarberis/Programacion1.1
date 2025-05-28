#include <stdlib.h>
#include <stdio.h>

/*
    Este algoritmo muestra la altura de la persona mayor
*/

int main()
{
    int altura1, altura2, edad1, edad2;
    printf("Ingrese la edad de la primera persona: ");
    scanf("%d", &edad1);
    printf("Ingrese la altura de la primera persona: ");
    scanf("%d", &altura1);
    printf("Ingrese la edad de la segunda persona: ");
    scanf("%d", &edad2);
    printf("Ingrese la altura de la segunda persona: ");
    scanf("%d", &altura2);

    if (edad1 > edad2)
    {
        printf("%d\n", altura1);
    }
    else
    {
        printf("%d\n", altura2);
    }
    
    return 0;
}
