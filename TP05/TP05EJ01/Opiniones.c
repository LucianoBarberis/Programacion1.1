#include <stdio.h>
#include <stdlib.h>

void solicitarOpinion(int *op);
void calificarOpinion(int *contPos, int *contNeu, int *contNeg, int op);
void mostrarCalificaciones(int pos, int neu, int neg);

int main() {
    int contPos = 0, contNeu = 0, contNeg = 0, opinion;

    printf("-------Opina de nuestro producto-------\n");
    
    do{
        solicitarOpinion(&opinion);
        if (opinion != 0){
            calificarOpinion(&contPos, &contNeu, &contNeg, opinion);
        }
    } while (opinion > 0 && opinion <= 5);

    if (contPos == 0 && contNeg == 0 && contNeu == 0){
        printf("No hay calificaciones para mostrar.");
    }else {
        mostrarCalificaciones(contPos, contNeu, contNeg);
    }
    return 0;
}

void solicitarOpinion(int *op) {
    printf("Ingresa una opinion del 1-5 de nuestro producto: ");
    scanf("%d", op);
    system("cls");
}

void calificarOpinion(int *contPos, int *contNeu, int *contNeg, int op){
    if (op == 5 || op == 4){
        *contPos += 1;
    }
    if(op == 3){
        *contNeu += 1;
    }
    if(op == 2 || op == 1){
        *contNeg += 1;
    }
}

void mostrarCalificaciones(int pos, int neu, int neg) {
    printf("Calificaciones positivas: %d\n", pos);
    printf("Calificaciones neutras: %d\n", neu);
    printf("Calificaciones negativas: %d\n", neg);
};