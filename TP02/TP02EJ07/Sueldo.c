#include <stdlib.h>
#include <stdio.h>

int main()
{
    int vh, ht, sueldo;
    printf("Ingrese el valor por hora: ");
    scanf("%d", &vh);
    printf("Ingrese la cantidad de horas trabajadas: ");
    scanf("%d", &ht);

    sueldo = vh * ht;

    if(ht > 50){
        sueldo = sueldo + 100;
    }
    if(ht > 150){
        sueldo = sueldo + 100;
    }

    printf("El sueldo del empleado es: $%d\n", sueldo);
    system("pause");
    return 0;
}
