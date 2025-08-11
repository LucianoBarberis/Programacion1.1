#include <stdio.h>
#include <stdlib.h>

int main() {
    int i, CA, CN = 0, opc;
    float nota, promeduiU, promedioCurso;

    promedioCurso = 0;
    printf("Ingrese la cantidad de alumnos: ");
    scanf("%d", &CA);
    system("cls");
    for (i = 1; i <= CA; i++){
        promeduiU = 0;
        CN = 0;
        opc = 0;
        printf("____________________________________\n");
        printf("Calculo del promedio del alumno: %d \n", i);
        while (opc == 0){
            if (CN != 0){
                do{
                    printf("Desea ingresar una nueva nota?\n(1) Para salir\n(0) Para Seguir\nOpcion: ");
                    scanf("%d", &opc);
                    system("cls");
                } while (opc != 0 && opc != 1);
            }
            if (opc != 1){
                CN += 1;
                do{
                    printf("Ingrese la nota %d del alumno %i: ", CN, i);
                    scanf("%f", &nota);
                    system("cls");
                    if (nota < 0 || nota > 10)
                    {
                        printf("Nota incorrecta!!\n");
                    }else {
                        promeduiU += nota;
                    }
                } while (nota < 0 || nota > 10);
            }
        }
        promeduiU = promeduiU / CN;
        promedioCurso += promeduiU;
        printf("El promedio general del alumno %d es %.2f \n", i, promeduiU);
        CN = 0;
    }
    promedioCurso = promedioCurso / CA;
    printf("____________________________________\n");
    printf("El promedio general del curso es: %.2f \n", promedioCurso);
    return 0;
}