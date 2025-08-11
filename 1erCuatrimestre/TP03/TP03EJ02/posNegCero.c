#include <stdlib.h>
#include <stdio.h>

int main(){
    int c = 0, p = 0, n = 0, cantidad = 10, index, num;

    for (index = 0; index <= cantidad; index++)
    {
        printf("Escribe el num %d/%d: ", index, cantidad);
        scanf("%d", &num);
        if (num < 0){
            n += 1;
        }else if (num > 0){
            p += 1;
        }else {
            c += 1;
        }
    }
    printf("Negativos: %d\nPositivos: %d\nCeros: %d",n,p,c);
    return 0;
}
