namespace RepasoFinal
{
    internal class Program
    {
        const int PAC = 3;
        const int PRU = 5;

        static void Main(string[] args)
        {
            int[,] resultados = new int[PAC, PRU] {
                {10, 15, 45, 20, 10},  // Dentro de los rangos
                {12, 22, 50, 30, 8},   // Dentro de los rangos
                {2, 35, 66, 45, 35}    // Extremos válidos (mínimos o máximos)
            };

            int[] maxResults = new int[PRU] {15, 25, 60 , 35, 25 };
            int[] minResults = new int[PRU] {5, 10, 20, 10, 5 };

            // CargarResultados(resultados);
            detectValorAlto(resultados, maxResults);
            detectValorMinimo(resultados, minResults);
        }

        static void CargarResultados(int[,] resultados)
        {
            for (int i = 0; i < PAC; i++)
            {
                Console.WriteLine($"--- Ingreso de resultados del paciente {i + 1} ---");
                for (int j = 0; j < PRU; j++)
                {
                    int resultado;
                    do
                    {
                        Console.WriteLine($"Ingrese el resultado de la prueba {j + 1}: ");
                        resultado = int.Parse(Console.ReadLine());
                    } while (resultado < 0);
                    resultados[i, j] = resultado;
                }
            }
        }

        static void DetectValorAlto(int[,] resultados, int[] maximos)
        {    
            int pacValorAltos = 0;

            Console.WriteLine("--- Valores altos detectados ---");

            for (int i = 0;i < PAC; i++)
            {
                for (int j = 0; j < PRU; j++)
                {
                    if (resultados[i,j] > maximos[j])
                    {
                        pacValorAltos++;
                    }
                }
            }
            Console.WriteLine($"Los valores altos detectados fueron: {pacValorAltos}");
        }

        static void DetectValorMinimo(int[,] resultados, int[] minimos) 
        {
            int pacValorBajo = 0;

            Console.WriteLine("--- Valores minimos detectados ---");
            for (int i = 0; i < PAC; i++)
            {
                for (int j = 0; j < PRU; j++)
                {
                    if (resultados[i, j] > minimos[j])
                    {
                        pacValorBajo++;
                    }
                }
            }
            Console.WriteLine($"Los valores bajos detectados fueron: {pacValorBajo}");
        }

        static void ResultadosAnormales(int[,] resultados, int[] maximos, int[] minimos)
        {
            Console.WriteLine("--- Resultados Anormales ---");
        }

        static void CalcPromEspecifca()
        {
            Console.WriteLine("--- Promedio prueba especifica ---");
        }

    }
}
