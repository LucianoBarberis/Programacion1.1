#include <stdio.h>
#include <stdlib.h>
#include <string.h> //Añadí esta libreria para poder comparar cadenas de texto con la funcion strcmp

char saludar(char name[25]); // Esto es una función
void hola(); //Esto es simplemente un procedimiento que saluda pero no tiene argumentos que la modifican
int dobleValor(int num);

int main() {
    char condicion[6] = "salir";
    char nombre[25] = "";
    int valor = 1;
    hola();
    while (strcmp(nombre, condicion) != 0){
        printf("\nIngrese su nombre para que el sistema lo salude\n");
        scanf("%s", nombre);
        system("cls");
        if(strcmp(nombre, condicion) != 0) {
            saludar(nombre);
        }
    }
    while (valor != 0){
        printf("Ingrese el valor a procesar: ");
        scanf("%d", &valor);
        system("cls");
        if (valor != 0){
            printf("\nValor sin procesar %d | Valor procesado %d\n", valor, dobleValor(valor));
        }
    }
    return 0;
}

char saludar(char name[25]) {
    return printf("Hola!, %s.", name);
}

void hola(){
    printf("Hola\n");
}

int dobleValor(int num) {
    return num*2;
}