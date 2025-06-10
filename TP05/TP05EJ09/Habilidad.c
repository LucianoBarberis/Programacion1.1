#include <stdio.h>
#include <stdlib.h>

// Prototipos de funciones
int solicitarPuntuacion();
int evaluarHabilidad(int puntuacion);
void actualizarContadoresHabilidad(int evaluacion, int* contMejorar, int* contCompetente, int* contAvanzado);
void mostrarResultados(int contMejorar, int contCompetente, int contAvanzado);

int main() {
    int puntuacion, evaluacion;
    int contMejorar = 0, contCompetente = 0, contAvanzado = 0;

    printf("-----------Evaluador de Progreso en Habilidades de Idioma-----------\n\n");
    do {
        puntuacion = solicitarPuntuacion();
        if (puntuacion != -1) {
            evaluacion = evaluarHabilidad(puntuacion);
            actualizarContadoresHabilidad(evaluacion, &contMejorar, &contCompetente, &contAvanzado);
        }
    } while (puntuacion != -1);

    mostrarResultados(contMejorar, contCompetente, contAvanzado);
    return 0;
}

int solicitarPuntuacion() {
    int puntuacion;
    do {
        printf("Ingrese la puntuacion de la habilidad (0-100, -1 para terminar): ");
        scanf("%d", &puntuacion);
        if ((puntuacion < 0 || puntuacion > 100) && puntuacion != -1) {
            printf("Error: Ingrese un valor valido entre 0 y 100, o -1 para terminar.\n");
        }
    } while ((puntuacion < 0 || puntuacion > 100) && puntuacion != -1);
    return puntuacion;
}

int evaluarHabilidad(int puntuacion) {
    if (puntuacion > 85) return 3;       // Avanzado
    if (puntuacion >= 60) return 2;      // Competente
    return 1;                            // Necesita Mejorar
}

void actualizarContadoresHabilidad(int evaluacion, int* contMejorar, int* contCompetente, int* contAvanzado) {
    switch (evaluacion) {
        case 3: (*contAvanzado)++; break;
        case 2: (*contCompetente)++; break;
        case 1: (*contMejorar)++; break;
    }
}

void mostrarResultados(int contMejorar, int contCompetente, int contAvanzado) {
    printf("\nResumen de Evaluaciones:\n");
    printf("Necesita Mejorar: %d\n", contMejorar);
    printf("Competente: %d\n", contCompetente);
    printf("Avanzado: %d\n", contAvanzado);
}