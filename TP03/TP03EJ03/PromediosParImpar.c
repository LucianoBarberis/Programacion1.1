#include <stdio.h>
#include <stdio.h>

int main(){
    int pares=0, impares=0, mayoresQ=0;
    int index, cantidad=8, input;
    float promGral=0, promPar=0, promImpar=0;

    for (index = 0; index < cantidad; index++)
    {
        printf("Ingresa el num %d/%d: ", index, cantidad);
        scanf("%d", &input);
        promGral += input;

        if (input % 2 == 0){
            pares += 1;
            promPar += input;
        }else {
            impares += 1;
            promImpar += input;
        }
        if (input > 15){
            mayoresQ += 1;
        }
    }
    promGral = promGral/cantidad;
    promImpar = promImpar/impares;
    promPar = promPar/pares;
    
    printf("\nPromedio general: %.2f\nPromedio impares: %.2f\nPromedio Pares: %.2f\nMayores a quince: %d\n", promGral, promImpar, promPar, mayoresQ);
    return 0;
}
