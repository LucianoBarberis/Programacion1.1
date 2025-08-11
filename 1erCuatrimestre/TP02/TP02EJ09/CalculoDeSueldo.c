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

    if(categoria == 1 && antiguedad >= 1) {
        sueldo += antiguedad*50;
        printf("Calculando... \n");
    }

    printf("El sueldo del empleado es: $%d", sueldo);
    return 0;
}
