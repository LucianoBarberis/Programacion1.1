#include <stdio.h>

int main() {
    int opc = 1, inputNum;
    int ceros = 0, positivos = 0, negativos = 0;
    int sumPos = 0, sumNeg = 0;
    float promP = 0, promN = 0;

    while (opc != 0) {
        printf("Ingrese el número: ");
        scanf("%d", &inputNum);

        if (inputNum > 0) {
            positivos++;
            sumPos += inputNum;
        }

        if (inputNum < 0) {
            negativos++;
            sumNeg += inputNum;
        }

        if (inputNum == 0) {
            ceros++;
        }

        if (positivos != 0) {
            promP = (float)sumPos / positivos;
        }

        if (negativos != 0) {
            promN = (float)sumNeg / negativos;
        }

        printf("Promedio de Positivos: %.2f\n", promP);
        printf("Promedio de Negativos: %.2f\n", promN);
        printf("Ceros: %d\n", ceros);

        printf("¿Desea continuar? (1 = Sí, 0 = No): ");
        scanf("%d", &opc);
    }

    return 0;
}