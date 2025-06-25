#include <stdio.h>
#include <stdlib.h>
#define FILA 12
#define DATA 5
#define MOZO 6
#define COLM 3

/*
N° De Factura === Col 0
N° De Mozo === Col 1
N° De Mesa === Col 2
Cantidad de comensales === Col 3
Monto de la cuenta === Col 4
*/
void input(int arr[FILA][DATA]);
void personasPorMozo(int arr[FILA][DATA], int mozos[MOZO][COLM]);
int totalVentas(int arr[FILA][DATA]);
void porcentualMozo(int arr[FILA][DATA], float mozosPor[MOZO], int mozos[MOZO][COLM], int totalFact);
void sueldoMozo(int mozos[MOZO][COLM]);
void masTrabajo(int mozos[MOZO][COLM], int *max);
int highTicket(int arr[FILA][DATA]);
int mesaRecambio(int arr[FILA][DATA], int mesaRecam[FILA]);
void output(int mesas[FILA][DATA], int mozos[MOZO][COLM], float mozosPorcentual[MOZO], int cantFact, int total, int max, int highFact, int mesaRecam);

int main() {
    int mesas[FILA][DATA], mozos[MOZO][COLM], mesasRecam[FILA], i = 0, cantFact = 0;
    float mozosPorcentual[MOZO];
    int total = 0, max = 0, highFact = 0, recambio = 0;
    
    input(mesas);
    personasPorMozo(mesas, mozos);
    total = totalVentas(mesas);
    porcentualMozo(mesas, mozosPorcentual, mozos, total);
    sueldoMozo(mozos);
    masTrabajo(mozos, &max);
    i = 0;
    cantFact = 0;
    while(i < FILA && mesas[i][0] != 0) {
        cantFact++;
        i++;
    }
    highFact = highTicket(mesas);
    recambio = mesaRecambio(mesas, mesasRecam);
    output(mesas, mozos, mozosPorcentual, cantFact, total, max, highFact, recambio);
    return 0;
}

void input(int arr[FILA][DATA]) {
    int i, fact, salir = 0;
    
    for(i = 0; i < FILA; i++) {
        do {
            printf("Ingrese el Num de factura: ");
            scanf("%d", &fact);
            if(fact == 0) {
                salir = 1;
            }
            arr[i][0] = fact;
        } while(arr[i][0] < 0);

        if(salir == 1) {
            break;
        }

        do {
            printf("Ingrese el Num de mozo: ");
            scanf("%d", &arr[i][1]);
        } while(arr[i][1] > MOZO || arr[i][1] < 1);

        do {
            printf("Ingrese el Num de mesa: ");
            scanf("%d", &arr[i][2]);
        } while(arr[i][2] > 12 || arr[i][2] < 0);

        do {
            printf("Ingrese la cantidad de comensales por mesa: ");
            scanf("%d", &arr[i][3]);
        } while(arr[i][3] < 0);

        do {
            printf("Ingrese el monto total: $");
            scanf("%d", &arr[i][4]);
        } while(arr[i][4] < 0);
    }
}

void personasPorMozo(int arr[FILA][DATA], int mozos[MOZO][COLM]) {
    int i = 0;
    int nMozo, nPersonas;

    for(i = 0; i < MOZO; i++) {
        mozos[i][0] = 0;
    }

    i = 0;
    while(i < FILA && arr[i][0] != 0) {
        nMozo = arr[i][1];
        nPersonas = arr[i][3];

        mozos[nMozo - 1][0] += nPersonas;
        i++;
    }
}

int totalVentas(int arr[FILA][DATA]) {
	int total = 0, i = 0;
    do{
        total += arr[i][4];
        i++;
    } while (i < FILA && arr[i][0] != 0);
	return total;	
};

void porcentualMozo(int arr[FILA][DATA], float mozosPor[MOZO], int mozos[MOZO][COLM], int totalFact){
    int i = 0, nMozo;
    int monto;
    // Inicializar el acumulador de facturación de cada mozo
    for(i = 0; i < MOZO; i++) {
        mozos[i][1] = 0;
    }
    i = 0;
    while(i < FILA && arr[i][0] != 0) {
        nMozo = arr[i][1] - 1;
        monto = arr[i][4];
        mozos[nMozo][1] += monto;
        i++;
    }
    // Calcular el porcentaje de facturación de cada mozo
    for(i = 0; i < MOZO; i++) {
        if(totalFact > 0)
            mozosPor[i] = ((float)mozos[i][1] / totalFact) * 100;
        else
            mozosPor[i] = 0;
    }
}

void sueldoMozo(int mozos[MOZO][COLM]){
    int i;
    for(i = 0; i < MOZO; i++) {
        mozos[i][2] = 0;
        if(mozos[i][1] != 0){
            mozos[i][2] = mozos[i][1]*5/100;
        }
    }
};

void masTrabajo(int mozos[MOZO][COLM], int *max) {
    int i = 0;
    for (i = 0; i < MOZO; i++){
        if (mozos[i][0] > *max){
            *max = i + 1;
        }
    }
}

int highTicket(int arr[FILA][DATA]) {
    int i, count = 0;
    for (i = 0; i < FILA; i++){
        if (arr[i][0] == 0) break;
        if (arr[i][4] > 45){
            count++;
        }
    }
    return count;
}

int mesaRecambio(int arr[FILA][DATA], int mesaRecam[FILA]){
    int i, maxMesa = 0, maxRecam = 0;
    for ( i = 0; i < FILA; i++){
        mesaRecam[i] = 0;
    }
    
    for (i = 0; i < FILA && arr[i][0] != 0; i++){
        int numMesa = arr[i][2];
        if(numMesa >= 1 && numMesa <= FILA)
            mesaRecam[numMesa - 1]++;
    }
    for (i = 0; i < FILA; i++){
        if (mesaRecam[i] > maxRecam){
            maxRecam = mesaRecam[i];
            maxMesa = i + 1;
        }
    }
    return maxMesa;
}

void output(int mesas[FILA][DATA], int mozos[MOZO][COLM], float mozosPorcentual[MOZO], int cantFact, int total, int max, int highFact, int mesaRecam) {
    int i = 0;
    printf("\n ---Datos de todas las mesas---\n");
    while(i < FILA && mesas[i][0] != 0) {
        printf("N de factura: %d --- N de mozo: %d --- N de mesa: %d --- Comensales: %d --- Monto: $%d\n",
                mesas[i][0], mesas[i][1], mesas[i][2], mesas[i][3], mesas[i][4]);
        i++;
    }
    printf("\n");
    for(i = 0; i < MOZO; i++) {
        if(mozos[i][0] != 0){
            printf("N Mozo: %d --- Cantidad de comensales atendidos: %d \n", i + 1, mozos[i][0]);    
        }
    }
    printf("\n");
    printf("Cantidad de facturas: %d \n", cantFact);
    printf("Total de ventas: $%d\n", total);
    printf("\n");
    for(i = 0; i < MOZO; i++) {
        if(mozos[i][1] != 0){
            printf("N Mozo: %d --- Porcentaje Facturado: %.2f%% \n", i + 1, mozosPorcentual[i]);    
        }
    }
    for(i = 0; i < MOZO; i++) {
        if (mozos[i][2] != 0){
            printf("El 5%% de las ventas del mozo %d es: $%d\n", i+1, mozos[i][2]);
        }
    }
    printf("\nEl empleado que mas trabajo fue el N %d", max);
    printf("\nSe crearon %d facturas mayores a 45$", highFact);
    printf("\nLa mesa con mas recambio fue la N%d", mesaRecam);
}