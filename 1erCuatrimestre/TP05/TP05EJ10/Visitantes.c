#include <stdio.h>
#include <stdlib.h>

// Prototipos de funciones
int solicitarTipoVisitante();
void registrarVisitante(int tipoVisitante, int* contAdultos, int* contNinos);
int sumarTotales(int adultos, int ninos);
void mostrarResultados(int adultos, int ninos, int total);

int main() {
    int tipoVisitante, contAdultos = 0, contNinos = 0, totalVisitantes;

    printf("-----------Contador de Visitantes en Evento Cultural-----------\n\n");
    do {
        tipoVisitante = solicitarTipoVisitante();
        if (tipoVisitante != -1) {
            registrarVisitante(tipoVisitante, &contAdultos, &contNinos);
        }
    } while (tipoVisitante != -1);

    totalVisitantes = sumarTotales(contAdultos, contNinos);
    mostrarResultados(contAdultos, contNinos, totalVisitantes);

    return 0;
}

int solicitarTipoVisitante() {
    int tipo;
    do {
        printf("Ingrese el tipo de visitante (1 para adulto, 0 para nino, -1 para terminar): ");
        scanf("%d", &tipo);
        if (tipo != 1 && tipo != 0 && tipo != -1) {
            printf("Error: Ingrese un valor valido (1, 0 o -1).\n");
        }
    } while (tipo != 1 && tipo != 0 && tipo != -1);
    return tipo;
}

void registrarVisitante(int tipoVisitante, int* contAdultos, int* contNinos) {
    if (tipoVisitante == 1) {
        (*contAdultos)++;
    } else if (tipoVisitante == 0) {
        (*contNinos)++;
    }
}

int sumarTotales(int adultos, int ninos) {
    return adultos + ninos;
}

void mostrarResultados(int adultos, int ninos, int total) {
    printf("\nResumen del Evento:\n");
    printf("Total de adultos: %d\n", adultos);
    printf("Total de ninos: %d\n", ninos);
    printf("Total general de visitantes: %d\n", total);
}