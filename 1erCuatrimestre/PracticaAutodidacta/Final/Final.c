#include <stdio.h>
#include <stdlib.h>

/*
Ejemplo de final:  ElectroSoft S.R.L. es una empresa dedicada a la venta de dispositivos 
electrónicos. Para llevar un control detallado de sus ventas, desean implementar un 
sistema en C que les permita registrar y analizar las unidades vendidas de sus principales 
5 productos a lo largo de los 7 días de la semana.
Se requiere desarrollar un programa en C que utilice una matriz bidimensional para almacenar 
esta información. El programa deberá implementar las siguientes funcionalidades a través de funciones:
1.	ingresar_ventas(): Esta función permitirá al usuario ingresar la cantidad de unidades 
vendidas para cada uno de los 5 productos durante cada uno de los 7 días de la semana.
Los datos se almacenarán en la matriz de ventas, donde las filas representarán los 
productos y las columnas representarán los días de la semana. El alumno deberá considerar 
qué parámetros son necesarios para que esta función pueda acceder y modificar la matriz de 
ventas.
Luego de la función de ingreso de datos, se deberán implementar las siguientes 4 funciones
para realizar diversos análisis. Para cada una, el alumno deberá determinar qué parámetros 
necesita la función para cumplir su objetivo:
2.	calcular_total_ventas_producto(): Esta función deberá calcular y retornar el total de 
unidades vendidas de un producto específico a lo largo de toda la semana.
3.	encontrar_dia_maxima_venta_general(): Esta función deberá determinar y mostrar el día 
de la semana (indicando su índice, por ejemplo, 0 para el primer día, 1 para el segundo, 
etc.) en el que se registró la mayor cantidad total de ventas (sumando las ventas de todos 
los productos en ese día). Además, deberá retornar el total de ventas de ese día.
4.	calcular_promedio_ventas_semanal(): Esta función calculará y mostrará el promedio de 
ventas por producto a lo largo de toda la semana. Para cada producto, se deberá calcular 
el total de ventas semanales y luego dividirlo por el número de días (7).
5.	buscar_producto_minima_venta_dia(): Esta función deberá encontrar y mostrar el índice 
del producto que tuvo la menor cantidad de ventas en un día específico de la semana, así 
como la cantidad de unidades vendidas. En caso de haber varios productos con la misma 
mínima venta, se puede mostrar cualquiera de ellos.
6. Crea un funcion que encuentre y muestre el primer dia en el cual se vendieron la 
cantidad de productos seleccionadas por el usuario
7. Ordenar los dias de mayor a menos segun ventas
*/

#define DIA 7
#define PROD 5

void input(int ventasProp[DIA][PROD]);
void tableSells(int ventasProp[DIA][PROD]);
int totalVentasProd(int ventasProp[DIA][PROD]);
void maxVentasDia(int ventasProp[DIA][PROD]);
void promedioVentas(int ventasProp[DIA][PROD]);
void minVentasDia(int ventasProp[DIA][PROD]);
void busquedaDeVentas(int ventasProp[DIA][PROD]);
void ordenamiento(int ventasProp[DIA][PROD]);

int main() {
    int d, p;
    int ventas[DIA][PROD];

    //? Funcion 1
    input(ventas);
    
    //? Funcion 2
    printf("El total de ventas fue de %d unidades\n", totalVentasProd(ventas));
    
    //? Funcion 3
    maxVentasDia(ventas);

    //? Funcion 4
    promedioVentas(ventas);

    //? Funcion 5
    minVentasDia(ventas);

    //? Busqueda
    busquedaDeVentas(ventas);

    //? Tabla representativa del la matriz ventas
    printf("\nENTER PARA VER LA TABLA DE VENTAS...");
    tableSells(ventas);
    return 0;
}

void input(int ventasProp[DIA][PROD]){
    int d, p;
    printf("--- Ingreso de Datos ---\n");
    for (d = 0; d < DIA; d++){
        for (p = 0; p < PROD; p++){
            printf("Ingrese las ventas del dia %d del producto %d: ", d+1, p+1);
            scanf("%d", &ventasProp[d][p]);
        }
        if (d+1 < 7){
            printf("\nENTER PARA INGRESAR LOS DATOS DEL DIA %d...", d+2);
            getchar();
            getchar();
        }
        system("clear");
    }
}

int totalVentasProd(int ventasProp[DIA][PROD]){
    printf("\nENTER PARA VER EL TOTAL DE VENTAS DE UN PRODUCTO...");
    getchar();
    getchar();
    system("clear");

    int d,p;
    int prod = 1;
    int sumador = 0;
    
    printf("--- Total de ventas de un producto ---\n");
    do{
        if (prod > 5 || prod < 1){
            printf("ERROR El PRODUCTO DEBE SER VALIDO!\n");
        }
        printf("Selecciona el producto para calcular el total de ventas (1-5): ");
        scanf("%d", &prod);
    } while (prod > 5 || prod < 1);
    
    for (d = 0; d < DIA; d++){
        sumador += ventasProp[d][prod-1];
    }

    return sumador;
}

void maxVentasDia(int ventasProp[DIA][PROD]){
    printf("\nENTER PARA VER EL DIA CON MAS VENTAS...");
    getchar();
    getchar();
    system("clear");

    int d,p;
    int diaMax = 0, ventasMax = 0;
    int sumadorAux = 0;

    for (d = 0; d < DIA; d++){
        sumadorAux = 0;
        for (p = 0; p < PROD; p++){
            sumadorAux += ventasProp[d][p];
        }
        if(sumadorAux >= ventasMax){
            diaMax = d;
            ventasMax = sumadorAux;
        }
    }
    printf("El indice del dia con mas ventas es el %d con %d ventas\n", diaMax, ventasMax);
}

void promedioVentas(int ventasProp[DIA][PROD]){
    printf("\nENTER PARA VER EL PROMEDIO DE VENTAS DE CADA PRODUCTO...");
    getchar();
    system("clear");

    int d, p;
    float ventasPorProd[PROD] = {0};

    for (p = 0; p < PROD; p++){
        for (d = 0; d < DIA; d++){
            ventasPorProd[p] += ventasProp[d][p];
        }
        ventasPorProd[p] = (ventasPorProd[p]/7);
    }

    printf("--- Tabla De Promedios Por Producto ---\n");
    printf("|PROMEDIO|PRODUCT|\n");
    printf("------------------\n");
    for (p = 0; p < PROD; p++){
        printf("|%.2f\t |%d \t|\n", ventasPorProd[p], p+1);
    }
}

void minVentasDia(int ventasProp[DIA][PROD]) {
    printf("\nENTER PARA VER EL MINIMO DE VENTAS DE UN PRODUCTO EN UN DIA...");
    getchar();
    system("clear");
    int p;
    int diaSelected = 1;
    int minProd = 0, minIndex = 0;

    do{
        if (diaSelected > 7 || diaSelected < 1){
            printf("ERROR, El DIA DEBE SER VALIDO!\n");
        }
        printf("Selecciona el dia para ver el producto menos vendido (1-7): ");
        scanf("%d", &diaSelected);
    } while (diaSelected > 7 || diaSelected < 1);
    
    for (p = 0; p < PROD; p++){
        if (p == 0){
            minIndex = p;
            minProd = ventasProp[diaSelected][p];
        }else{
            if (ventasProp[diaSelected][p] < minProd){
                minProd = ventasProp[diaSelected][p];
                minIndex = p;
            }
        }
    }
    printf("\nEl producto menos vendido en el dia %d fue el producto %d con %d ventas.\n", diaSelected, minIndex+1, minProd);
}

void busquedaDeVentas(int ventasProp[DIA][PROD]) {
    printf("\nENTER PARA BUSCAR EL PRIMER DIA QUE SE VENDIERON ... UNIDADES...");
    getchar();
    getchar();
    system("clear");

    int objtive = 0;
    int flag = 0;
    int day = -1;
    int sumador = 0;
    int d , p;
    do{
        printf("Escribe el numero de ventas que quieras buscar: ");
        scanf("%d", &objtive);
    } while (objtive < 0);
    
    for (d = 0; d < DIA; d++){
        int sumador = 0;
        for (p = 0; p < PROD; p++){
            sumador += ventasProp[d][p];
        }
        if (sumador == objtive && flag == 0){
            flag = 1;
            day = d+1;
        }
    }
    if (day == -1){
        printf("No hay ningun dia en el que se halla vendido %d unidades", objtive);
    }else {
        printf("El primer dia en el cual se vendieron %d fue %d", objtive, day);
    }
}

void ordenamiento(int ventasProp[DIA][PROD]){
    int d, p, i, j;
    int aux;
    int ventasTotales[DIA] = {0};

    for (d = 0; d < DIA; d++){
        for ( p = 0; p < PROD; p++){
            ventasTotales[d] += ventasProp[d][p];
        }
    }
    
    for (i = 0; i < DIA; i++){
        for (j = 0; j < DIA - 1; j++){
            if (ventasTotales[j] > ventasTotales[j+1]){
                aux = ventasTotales[j];
                ventasTotales[j] = ventasTotales[j+1];
                ventasTotales[j+1] = aux;
            }
        }
    }
    
}

void tableSells(int ventasProp[DIA][PROD]){
    int d, p;

    getchar();
    getchar();
    system("clear");

    printf("--- Tabla De Ventas ---\n");
    printf("|INDEX\t|DIA\t|PROD1\t|PROD2\t|PROD3\t|PROD4\t|PROD5\t|\n");
    printf("-------------------------------------------------------\n");
    for (d = 0; d < DIA; d++){
        printf("|%d\t|%d\t|",d ,d+1);
        for (p = 0; p < PROD; p++){
            printf("%d\t|", ventasProp[d][p]);
        }
        printf("\n");
    }
}