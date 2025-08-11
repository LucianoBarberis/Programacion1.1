#include <stdio.h>
#include <stdlib.h>

/*
    Este programa valida una fecha ingresada por el usuario.
*/

void biciesto(){
    printf("Hola esto es una funcion");
}

int main()
{
    int dia, mes, ano, bisiesto, fecha;

    printf("Dia: ");
    scanf("%d", &dia);
    printf("Mes: ");
    scanf("%d", &mes);
    printf("Ano: ");
    scanf("%d", &ano);

    if(ano > 0)
    {
        if(ano % 4 == 0){
            if(ano % 100 == 0){
                if(ano % 400 == 0){
                    bisiesto = 1;
                }else{
                    bisiesto = 0;
                }
            }else{
                bisiesto = 1;
            }
        }else{
            bisiesto = 0;
        }

        if (bisiesto == 1) {
            if (mes > 0 && mes <= 12) {
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
                    if (dia > 0 && dia <= 30) {
                        fecha = 1;
                    } else {
                        fecha = 0;
                    }
                } else if (mes == 2) {
                    if (dia > 0 && dia <= 29) {
                        fecha = 1;
                    } else {
                        fecha = 0;
                    }
                } else {
                    if (dia > 0 && dia <= 31) {
                        fecha = 1;
                    } else {
                        fecha = 0;
                    }
                }
            }
        }

        if (bisiesto == 0) {
            if (mes > 0 && mes <= 12) {
                if (mes == 4 || mes == 6 || mes == 9 || mes == 11) {
                    if (dia > 0 && dia <= 30) {
                        fecha = 1;
                    } else {
                        fecha = 0;
                    }
                } else if (mes == 2) {
                    if (dia > 0 && dia <= 28) {
                        fecha = 1;
                    } else {
                        fecha = 0;
                    }
                } else {
                    if (dia > 0 && dia <= 31) {
                        fecha = 1;
                    } else {
                        fecha = 0;
                    }
                }
            }
        }
        if (fecha == 1) {
            printf("\nFecha valida\n");
            printf("%d/%d/%d\n", dia, mes, ano);
        }else {
            printf("\nFecha no valida\n");
            printf("%d/%d/%d\n", dia, mes, ano);
        }
    }else {
        printf("El ano no es valido\n");
    }
    return 0;
}
