#include <stdlib.h>
#include <stdio.h>

int main()
{
    int dia, salir = 1;
    do{
        printf("Escriba un numero de dia: ");
        scanf("%d", &dia);

        switch (dia)
        {
        case 1:
            printf("Dia Lunes\n");
            break;
        case 2:
            printf("Dia Martes\n");
            break;
        case 3:
            printf("Dia Miercoles\n");
            break;
        case 4:
            printf("Dia Jueves\n");
            break;
        case 5:
            printf("Dia Viernes\n");
            break;
        case 6:
            printf("Dia Sabado\n");
            break;
        case 7:
            printf("Dia Domingo\n");
            break;
        case 8: 
            salir = 0;
            break;
        default:
            printf("Dia no valido\n");
        }
    } while (salir == 1);
    return 0;
}
