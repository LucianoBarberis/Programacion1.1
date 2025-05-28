#include <stdlib.h>
#include <stdio.h>

int main()
{
    int categoria, sueldo, antiguedad;

    printf("Ingrese el sueldo del empleado: ");
    scanf("%d", &sueldo);
    printf("Ingrese la categoria del empleado: ");
    scanf("%d", &categoria);
    printf("Ingrese la antiguedad del empleado: ");
    scanf("%d", &antiguedad);

    switch (categoria)
    {
    case 1:
        sueldo += antiguedad*50;
        break;
    case 2:
        sueldo += antiguedad*70;
        break;
    case 3:
        sueldo += antiguedad*80;
        break;
    
    default:
        break;
    }

    printf("El sueldo del empleado es: $%d", sueldo);
    return 0;
}
