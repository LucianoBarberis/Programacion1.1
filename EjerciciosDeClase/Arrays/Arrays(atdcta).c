#include <stdio.h>
#include <stdlib.h>

int main() {
    int arr[4], i, j, a, pos, max, min;
    pos = 0;
    for  (i = 0; i < 4; i++){
        arr[i] = i + 1;
    }
    for (j = 0; j < 4; j++){
        printf("La pocicion %d del array vale %d \n", pos, arr[j]);
        pos = pos + 1;
    }
    printf("____________________________\n");
    pos = 0;
    for (a = 0; a < 4; a++){
        arr[a] = a + 5;
        printf("La pocicion %d del array vale %d \n", pos, arr[a]);
        pos = pos + 1;
    }
    printf("____________________________\n");
    for (i = 0; i < 4; i++){
        if (i == 0){
            max = arr[i];
            min = arr[i];
        }else {
            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
    }
    printf("Maximo: %d\n", max);
    printf("Minimo: %d\n", min);
    
    return 0;
}