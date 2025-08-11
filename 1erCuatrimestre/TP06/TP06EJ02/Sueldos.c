#include <stdio.h>
#include <stdlib.h>
#define T 5

/*
Ingresar 10 sueldos y edades de una empresa y calcular
Sueldo promedio
Sueldo promedio de los empleados que tienen entre 23 y 40 años
Edad promedio
Cantidad de empleados mayores a 30 años y sueldo menor a $ 1000.
Cantidad de empleados con edades menor a la edad promedio
*/

void input(int arr[T][2]);
float promedio(int arr[T][2]);
float promedioEntreEdad(int arr[T][2]);
float promedioEdad(int arr[T][2]);
int cantidadDeEmpleadosMayor(int arr[T][2]);
int cantidadDeEmpleadosMenor(int arr[T][2], int edadProm);

int main() {
    int employes[T][2];
    int i;
    float prom = 0, promEntreEdad = 0, promEdad = 0;
    int empleadosMayor, empleadosMenor;

    input(employes);
    prom = promedio(employes);
    promEntreEdad = promedioEntreEdad(employes);
    promEdad = promedioEdad(employes);
    empleadosMayor = cantidadDeEmpleadosMayor(employes);
    empleadosMenor = cantidadDeEmpleadosMenor(employes, promEdad);

    printf("---Lista de sueldo y edad de los empleados---\n");
    for (i = 0; i < T; i++) {
        printf("Sueldo: %d   Edad: %d\n", employes[i][0], employes[i][1]);
    }
    printf("\nPromedio de los sueldos: %.2f\n", prom);
    printf("Sueldo promedio de los empleados que tienen entre 23 y 40 anios: %.2f\n", promEntreEdad);
    printf("El promedio de edad de los empleado es de: %.2f\n", promEdad);
    printf("Cantidad de empleados mayores a 30 anios y sueldo menor a $1000: %d\n", empleadosMayor);
    printf("Cantidad de empleados con edades menor a la edad promedio: %d", empleadosMenor);
}

void input(int arr[T][2]){
    int i;
    for (i = 0; i < T; i++){
        printf("---Ingreso de datos del empleado %d---\n", i+1);
        printf("Ingrese el sueldo %d: ", i+1);
        scanf("%d", &arr[i][0]);
        printf("Ingrese la edad del empleado %d: ", i+1);
        scanf("%d", &arr[i][1]);
        system("cls");
    }
};

float promedio(int arr[T][2]){
    int sumador = 0, i;

    for ( i = 0; i < T; i++){
        sumador += arr[i][0];
    }
    return (float)sumador / T;
}

float promedioEntreEdad(int arr[T][2]){
    int sumador = 0, cont = 0, i;

    for (i = 0; i < T; i++){
        if ((arr[i][1] > 23) && (arr[i][1] < 40)){
            sumador =+ arr[i][0];
            cont =+ 1;
        }
    }
    return (float)sumador / cont;
}

float promedioEdad(int arr[T][2]){
    int sumador = 0, i;

    for ( i = 0; i < T; i++){
        sumador += arr[i][1];
    }
    return (float)sumador / T;
}

int cantidadDeEmpleadosMayor(int arr[T][2]) {
    int i, cont = 0;
    for (i = 0; i < T; i++){
        if (arr[i][1] > 30 && arr[i][0] < 1000){
            cont += 1;
        }
    }
    return cont;
}

int cantidadDeEmpleadosMenor(int arr[T][2], int edadProm) {
    int i, cont = 0;
    for (i = 0; i < T; i++){
        if (arr[i][1] > edadProm){
            cont += 1;
        }
    }
    return cont;
}