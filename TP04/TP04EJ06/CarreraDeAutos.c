#include <stdio.h>
#include <stdlib.h>

int main() {
    int opc, nAuto, hora, min, seg, ms;
    int winner, wHora, wMin, wSeg, wMs;
    int loser, lHora, lMin, lSeg, lMs;
    int index = 0;

    do {
        printf("1. Anadir auto\n");
        printf("0. Ver resultados\n");
        printf("Ingrese opcion: ");
        scanf("%d", &opc);
        system("cls");

        if (opc == 1) {
            printf("Auto N: ");
            scanf("%d", &nAuto);

            printf("Hora: ");
            scanf("%d", &hora);

            do {
                printf("Minuto: ");
                scanf("%d", &min);
            } while (min >= 59 || min <= 0);

            do {
                printf("Segundo: ");
                scanf("%d", &seg);
            } while (seg >= 59 || seg <= 0);

            do {
                printf("Milesimas: ");
                scanf("%d", &ms);
                system("cls");
            } while (ms >= 100 || ms <= 0);

            if (index == 0) {
                winner = nAuto;
                wHora = hora; wMin = min; wSeg = seg; wMs = ms;

                loser = nAuto;
                lHora = hora; lMin = min; lSeg = seg; lMs = ms;
            } else {
                if ((hora < wHora) || 
                    (hora == wHora && min < wMin) || 
                    (hora == wHora && min == wMin && seg < wSeg) || 
                    (hora == wHora && min == wMin && seg == wSeg && ms < wMs)) {
                    winner = nAuto;
                    wHora = hora; wMin = min; wSeg = seg; wMs = ms;
                }

                if ((hora > lHora) || 
                    (hora == lHora && min > lMin) || 
                    (hora == lHora && min == lMin && seg > lSeg) || 
                    (hora == lHora && min == lMin && seg == lSeg && ms > lMs)) {
                    loser = nAuto;
                    lHora = hora; lMin = min; lSeg = seg; lMs = ms;
                }
            }

            index++;
        }

    } while (opc != 0);

    printf("Ganador: Auto %d con tiempo %02d:%02d:%02d.%02d\n", winner, wHora, wMin, wSeg, wMs);
    printf("Ultimo: Auto %d con tiempo %02d:%02d:%02d.%02d\n", loser, lHora, lMin, lSeg, lMs);

    return 0;
}
