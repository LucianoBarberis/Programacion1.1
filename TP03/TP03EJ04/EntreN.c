#include <stdio.h>
#include <stdlib.h>

int main()
{
    float treinta, veinte, diez, mas;
    float porMas, porDiez, porVeinte, porTreinta;
    int index, input, cantidad;

    cantidad = 10;
    for (index = 0; index < cantidad; index++)
    {
        printf("Ingrese el num %d/%d: ", index, cantidad);
        scanf("%d", &input);
        if (input > 0)
        {
            if (input > 1 && input < 10)
            {
                diez += 1;
            }
            if (input > 10 && input < 20)
            {
                veinte += 1;
            }
            if (input > 20 && input < 10)
            {
                treinta += 1;
            }
            if (input >30)
            {
                mas += 1;
            }
        }
    }
    porDiez = diez/cantidad*100;
    porVeinte = veinte/cantidad*100;
    porTreinta = treinta/cantidad*100;
    porMas = mas/cantidad*100;
    
    printf("Porcentaje de +1/-10: %.2f \n", porDiez);
    printf("Porcentaje de +10/-20: %.2f \n", porVeinte);
    printf("Porcentaje de +20/-30: %.2f \n", porTreinta);
    printf("Porcentaje de +30: %.2f \n", porMas);
    return 0;
}
