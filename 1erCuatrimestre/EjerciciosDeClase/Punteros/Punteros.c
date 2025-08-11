#include <stdio.h>
#include <stdlib.h>

char divider[60] = "---------------------------------------------------------\n";

int main() {
    int num = 10;
    int *numPtr = &num;
    printf("%s", divider);
    printf("Direccion de el valor de la variable numPtr %p\n", numPtr);
    printf("Accediendo al valor de la variable a la que apunta el puntero %d\n", *numPtr);
    printf("Accediendo a la direccion de memoria a traves de la variable num %p\n", &num);
    printf("Accediendo al valor de la variable num %d\n", num);
    printf("%s", divider);
    return 0;
}