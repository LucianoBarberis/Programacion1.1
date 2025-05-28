#include <stdio.h>
#include <stdlib.h>

/*
? A partir de ahora vamos a emprezar a pseudo-modularizar nuestro codigo en 3 funciones
? ingreso()/input()
? proceso()
? salida()/output()
? Con el fin de modularizar de alguna forma nuestro codigo y que este sea mas mantenible,
? limpio y facil de depurar.
*/

void input(int *d1, int *d2, int *d3);
float proces(int d1, int d2, int d3);
void output(float valor);

int main() {
    int dato1 = 0, dato2 = 0, dato3 = 0;
    float promedio;

    input(&dato1, &dato2, &dato3);// Pasar las direcciones de memoria
    promedio = proces(dato1, dato2, dato3);
    output(promedio);
    return 0;
}

void input(int *d1, int *d2, int *d3) {
    printf("Ingrese el primer dato: ");
    scanf("%d", d1);
    printf("Ingrese el segundo dato: ");
    scanf("%d", d2);
    printf("Ingrese el tercer dato: ");
    scanf("%d", d3);
    return;
}

float proces(int d1, int d2, int d3) {
    float resultado;
    resultado = (float)(d1 + d2 + d3)/3;
    return resultado;
}

void output(float valor) {
    printf("%.2f", valor);
}

/*
? Si necesitamos pasar datos para unicamente "pasar" a una funcion sin modificarlo, a la 
? funcion unicamente le vamos a pasar la variable. Y si necesitamos pasar el dato para
? modificarlo vamos a definir los parametros de la funcion como punteros y a la funcion
? le vamos a pasar la direccion de la variable a modificar
*/