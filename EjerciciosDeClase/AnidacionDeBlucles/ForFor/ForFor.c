#include <stdio.h>
#include <stdlib.h>

int main() {
    int i, j, CA, CN;
    float nota, promeduiU, promedioCurso;
    
    CA = 5;
    CN = 10;

    promedioCurso = 0;

    for (i = 1; i <= CA; i++){
        promeduiU = 0;
        printf("____________________________________\n");
        printf("Calculo del promedio del alumno: %d \n", i);
        for (j = 1; j <= CN; j++){
            do{
                printf("Ingrese la nota %d del alumno %i: ", j, i);
                scanf("%f", &nota);
                system("cls");
                if (nota < 0 || nota > 10)
                {
                    printf("Nota incorrecta!!\n");
                }else {
                    promeduiU += nota;
                }
            } while (nota < 1 || nota > 10);
        }
        promeduiU = promeduiU / CN;
        promedioCurso += promeduiU;
        printf("El promedio general del alumno %d es %.2f \n", i, promeduiU);
    }
    promedioCurso = promedioCurso / CA;
    printf("____________________________________\n");
    printf("El promedio general del curso es: %.2f \n", promedioCurso);
    return 0;
}