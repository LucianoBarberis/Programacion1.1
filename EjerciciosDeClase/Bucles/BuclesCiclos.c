#include <stdlib.h>
#include <stdio.h>

int main(){   
    printf("----------------For----------------------\n\n");
    // Bucle for
    int index = 0;
    for (index = 0; index <= 10; index++){
        printf("Es es la iteracion numero: %d \n", index);
    }

    printf("\n\n----------------While--------------------\n\n");
    // Bucle while
    int salida = 1;
    int iteracion = 0;
    while (salida != 0)
    {
        iteracion++;
        printf("Iteracion num: %d\n", iteracion);
        printf("\n0 para salir del bucle?: ");
        scanf("%d", &salida);
    }
    
    printf("\n\n---------------Do-While------------------\n\n");
    // Bucle do-while
    int salirDo = 1;
    int iteracionDo = 0;
    do{
        iteracionDo++;
        printf("Iteracion num: %d\n", iteracionDo);
        printf("\n0.Para salir del bucle?\n1.Para ejecutar un bucle infinito\n Opcion: ");
        scanf("%d", &salirDo);
        if (salirDo == 1){
            int i = 1;
            while (i == 1){
                printf("Bucle infinito");
            }
        }
    } while (salirDo != 0);
    
    system("pause");
    return 0;
}
