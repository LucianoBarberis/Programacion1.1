#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define E 50 //Cantidad de empleados
#define CE 3 //Datos/Columnas de empleados
#define STR 20 //Largo de nombres
#define C 3 //Categorias

void input(int emp[E][CE], char name[E][STR]);
void empPorCat(int emp[E][CE], int categorias[C][3]);
void sueldosPorCat(int emp[E][CE], int categorias[C][3]);
void calculoDeSueldo(int emp[E][CE]);
float sueldoPromedio(int emp[E][CE]);
int sueldoMaximo(int emp[E][CE], char bestSueldo[STR], char name[E][STR]);
void porcentajeSueldo(int categorias[C][3]);
void output(int emp[E][CE], char name[E][STR], int categorias[C][3], float sueldoProm, char bestSueldo[STR], int sueldoMax);

/*
Array Empleados:
    0: Categoria
    1: Antiguedad
    2: Sueldo
Array Categorias:
    0: Empleados por categoria
    1: Total de sueldos pagados por categoria
    2: Porcentaje que representan el total de sueldos por categoria sobre el total
*/


int main() {
    int empleados[E][CE];
    char nombres[E][STR];
    int cats[C][3];
    float sueldoProm = 0;
    int sueldoMax = 0;
    char empleadoMax[STR];
    
    input(empleados, nombres);
    
    empPorCat(empleados, cats);
    sueldosPorCat(empleados, cats);
    calculoDeSueldo(empleados);
    sueldoProm = sueldoPromedio(empleados);
    sueldoMax = sueldoMaximo(empleados, empleadoMax, nombres);
    porcentajeSueldo(cats);

    output(empleados, nombres, cats, sueldoProm, empleadoMax, sueldoMax);
    return 0;
}

void input(int emp[E][CE], char name[E][STR]) {
    int e;
    char string[STR];
    for (e = 0; e < E; e++){
        do{
            printf("Ingresa el nombre del empleado (%d/%d): ", e+1, E);
            scanf(" %s", string);
            fflush(stdin);
        } while (strlen(string) > STR);
        strcpy(name[e], string);

        do{
            printf("Ingresa la categoria del empleado (1-%d): ", C);
            scanf("%d", &emp[e][0]);
        } while (emp[e][0] > 3 || emp[e][0] < 1);
        
        do{
            printf("Ingresa la antiguedad del empleado: ");
            scanf("%d", &emp[e][1]);
        } while (emp[e][1] < 0);
        system("cls");
    }
    
}

void empPorCat(int emp[E][CE], int categorias[C][3]) {
    int i, catAux;
    for (i = 0; i < C; i++){
        categorias[i][0] = 0;
    }
    
    for (i = 0; i < E; i++){
        catAux = emp[i][0];
        switch (catAux){
            case 1: categorias[0][0]++; break;
            case 2: categorias[1][0]++; break;
            case 3: categorias[2][0]++; break;
        }
    }
}

void sueldosPorCat(int emp[E][CE], int categorias[C][3]){
    int i, catAux, antiguedad;
    for (i = 0; i < C; i++){
        categorias[i][1] = 0;
    }

    for (i = 0; i < E; i++){
        catAux = emp[i][0];
        antiguedad = emp[i][1];
        switch (catAux){
            case 1: categorias[0][1] += 1500 + (antiguedad*100); break;
            case 2: categorias[1][1] += 2000 + (antiguedad*100); break;
            case 3: categorias[2][1] += 2500 + (antiguedad*100); break;
        }
    }
}

void calculoDeSueldo(int emp[E][CE]){
    int i, cat, age = 0;
    for (i = 0; i < E; i++){
        emp[i][2] = 0;
    }
    
    for (i = 0; i < E; i++){
        cat = emp[i][0];
        age = emp[i][1];
        
        switch (cat){
            case 1: emp[i][2] = 1500 + (age*100);break;
            case 2: emp[i][2] = 2000 + (age*100);break;
            case 3: emp[i][2] = 2500 + (age*100);break;
        }
    }
};

float sueldoPromedio(int emp[E][CE]){
    int i, sum = 0, prom = 0;
    for (i = 0; i < E; i++){
        sum = sum + emp[i][2];
    }
    prom = (float)sum/E;
    return prom;
}

int sueldoMaximo(int emp[E][CE], char bestSueldo[STR], char name[E][STR]) {
    int i, max = 0;

    for (i = 0; i < E; i++){
        if (emp[i][2] > max){
            max = emp[i][2];
            strcpy(bestSueldo, name[i]);
        }
    }
    return max;
}

void porcentajeSueldo(int categorias[C][3]){
    int i, totalSueldos = 0;
    for (i = 0; i < C; i++){
        categorias[i][2] = 0;
    }
    for (i = 0; i < C; i++){
        totalSueldos += categorias[i][1];
    }
    for (i = 0; i < C; i++){
        if (totalSueldos > 0){
            categorias[i][2] = (int)(((float)categorias[i][1] / totalSueldos) * 100);
        } else {
            categorias[i][2] = 0;
        }
    }
}

void output(int emp[E][CE], char name[E][STR], int categorias[C][3], float sueldoProm, char bestSueldo[STR], int sueldoMax) {
    int i;
    system("cls");
    printf("---Datos de los empleados--- \n");
    for (i = 0; i < E; i++){
        printf("%d - Nombre: %s - Categoria: %d - Antiguedad: %d Anios\n", i+1, name[i], emp[i][0], emp[i][1]);
    }
    printf("\n---Cantidad de empleados por categoria--- \n");
    for (i = 0; i < C; i++){
        printf("Categoria %d: %d\n", i+1, categorias[i][0]);
    }
    printf("\n---Total sueldos por categoria--- \n");
    for (i = 0; i < C; i++){
        printf("Categoria %d: $%d\n", i+1, categorias[i][1]);
    }
    printf("\n---El sueldo promedio de los empleados--- \n");
    printf("Promedio: $%.2f", sueldoProm);
    printf("\n\n---El sueldo maximo--- \n");
    printf("Pertenece a %s, cobrando $%d", bestSueldo, sueldoMax);
    printf("\n\n---El porcentual que reprenseta cada categoria--- \n");
    for (i = 0; i < C; i++){
        printf("Categoria %d: %%%d | ", i+1, categorias[i][2]);
    }
    
}