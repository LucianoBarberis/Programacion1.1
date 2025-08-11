#include <stdio.h>
#include <stdlib.h>

int main() {
    // Definicion de variables...
        // ? sufijo Al = para alumnos
        // ? sufijo No = notas

    int opcAl = 0, opcNo = 0, canAl = 0, canNo = 0;
    float promedioU, promedioCurso = 0, nota;
    // Estructura de Bulces anidados
    while (opcAl == 0){
        promedioU = 0;
        opcNo = 0;
        opcAl = 0;
        do{
            printf("Desea ingresar un nuevo alumno?\n(0).Ingresar\n(1).Finalizar\nOpcion: ");
            scanf("%d", &opcAl);
            system("cls");
        } while (opcAl != 0 && opcAl != 1);
        if (opcAl == 0){
            canAl += 1;
            while (opcNo == 0){
                if (canNo != 0){
                    do{
                        printf("Desea ingresar una nueva nota?\n(0).Ingresa \n(1).No\nOpcion: ");
                        scanf("%d", &opcNo);
                        system("cls");
                    } while (opcNo != 0 && opcNo != 1);
                }
                if (opcNo != 1){
                    canNo += 1;
                    do{
                        printf("Ingrese la nota %d del alumno %i: ", canNo, canAl);
                        scanf("%f", &nota);
                        system("cls");
                        if (nota < 0 || nota > 10)
                        {
                            printf("Nota incorrecta!!\n");
                        }else {
                            promedioU += nota;
                        }
                    } while (nota < 0 || nota > 10);
                }
            }
        }
        if (canNo == 0){
            printf("No hay notas para sacar el promedio :/\n");
        }else {
            promedioU = promedioU / canNo;
            promedioCurso += promedioU;
            printf("--------------------------------------------\n");
            printf("El promedio general del alumno %d es %.2f \n", canAl, promedioU);
            printf("--------------------------------------------\n");
            canNo = 0;
        }
    }
    if (canAl == 0){
        printf("No hay alumnos para sacar el promedio de sus notas :/\n");
    }else{
        promedioCurso = promedioCurso / canAl;
        printf("____________________________________\n");
        printf("El promedio general del curso es: %.2f \n", promedioCurso);
    }
    return 0;
}