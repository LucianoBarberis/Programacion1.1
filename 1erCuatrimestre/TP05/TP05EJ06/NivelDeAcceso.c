#include <stdio.h>
#include <stdlib.h>

int solicitarAntiguedad();
int clasificarAntiguedad(int antiguedad);
void actualizarContadores(int clasificacion, int *contNivel1, int *contNivel2, int *contNivel3);
void mostrarResultados(int nivel1, int nivel2, int nivel3);

int main() {
    int antiguedad, contNivel1 = 0, contNivel2 = 0, contNivel3 = 0, clasificacion;
    printf("Bienvenido a la empresa!\n");
    do{
        antiguedad = solicitarAntiguedad();
        if (antiguedad != -1){
            clasificacion = clasificarAntiguedad(antiguedad);
            actualizarContadores(clasificacion, &contNivel1, &contNivel2, &contNivel3);
        }
    } while (antiguedad != -1);
    mostrarResultados(contNivel1, contNivel2, contNivel3);
    return 0;
}

int solicitarAntiguedad(){
    int antiguedad = 0;
    do{
        if (antiguedad < -1 || antiguedad > 100){
            printf("Error: La edad ingresada no es valida.\nTip: Si desea ver el total de empleados ingresa -1\n\n");
        }
        
        printf("Ingrese la antiguedad del empleado: ");
        scanf("%d", &antiguedad);
        system("cls");
    } while (antiguedad < -1 || antiguedad > 100);
    return antiguedad;
}

int clasificarAntiguedad(int antiguedad) {
    if (antiguedad < 2){return 1;}
    if (antiguedad >= 2 && antiguedad <= 5){return 2;}
    if (antiguedad > 5){return 3;}
    else{return 0;}
}

void actualizarContadores(int clasificacion, int *contNivel1, int *contNivel2, int *contNivel3){
    switch (clasificacion){
    case 1: (*contNivel1)++;break;
    case 2: (*contNivel2)++;break;
    case 3: (*contNivel3)++;break;
    }
}

void mostrarResultados(int nivel1, int nivel2, int nivel3){
    printf("-------------------------------------------------\n\n");
    printf("Empleados con nivel de acceso 1:%d\n", nivel1);
    printf("Empleados con nivel de acceso 2:%d\n", nivel2);
    printf("Empleados con nivel de acceso 3:%d", nivel3);
    printf("\n\n-------------------------------------------------\n\n");
}