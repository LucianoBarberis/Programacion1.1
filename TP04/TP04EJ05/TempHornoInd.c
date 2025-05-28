#include <stdio.h>

int main() {
    int maxTemp = 0, minTemp = 0, inputTemp, index = 0;

    while (1) {
        printf("Ingresa la temperatura actual del horno (1000 para salir): ");
        scanf("%d", &inputTemp);

        // Condición de salida
        if (inputTemp == 1000) {
            break;
        }

        if (index == 0) {
            minTemp = inputTemp;
            maxTemp = inputTemp;
        } else {
            if (inputTemp > maxTemp) {
                maxTemp = inputTemp;
            }

            if (inputTemp < minTemp) {
                minTemp = inputTemp;
            }
        }

        index++;

        printf("Temperatura máxima registrada: %d\n", maxTemp);
        printf("Temperatura mínima registrada: %d\n", minTemp);
    }

    return 0;
}