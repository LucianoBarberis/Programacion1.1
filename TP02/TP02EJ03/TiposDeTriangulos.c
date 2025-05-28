#include <stdio.h>
#include <stdlib.h>

/*
    Este algoritmo determina el tipo de triangulo que se forma con los lados ingresados por el usuario.
    Los tipos de triangulos son:
    - Equilatero: Todos los lados son iguales.
    - Isosceles: Dos lados son iguales.
    - Escaleno: Todos los lados son diferentes.
*/
int main()
{
    int lado1, lado2, base;

    printf("Ingrese el 1er lado: ");
    scanf("%d", &lado1);
    printf("Ingrese el 2do lado: ");
    scanf("%d", &lado2);
    printf("Ingrese la base: ");
    scanf("%d", &base);
    
    if (lado1 + lado2 <= base || lado2 + base <= lado1 || base + lado1 <= lado2)
    {
        printf("\nNo es un triangulo");
    }else if (lado1 == lado2 && base == lado2)
    {
        printf("Triangulo equilatero");
    }else if (lado1 == lado2 && base != lado1)
    {
        printf("Triangulo isosceles");
    }else
    {
        printf("Triangulo escaleno");
    }
    
    return 0;
}
