namespace PracticaDeFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int personas = 0;
            Console.WriteLine("Ingrese la cantidad de personas: ");
            personas = int.Parse(Console.ReadLine());

            int[] arr = new int[personas];
            string[] nombres = new string[personas];

            for (int i = 0; i < personas; i++)
            {
                do
                {
                    Console.WriteLine($"Ingrese el nombre de la persona {i+1}: ");
                    nombres[i] = Console.ReadLine();
                }while (string.IsNullOrWhiteSpace(nombres[i]));
                do
                {
                    Console.WriteLine($"Ingrese la edad de la persona {i + 1}: ");
                    arr[i] = int.Parse(Console.ReadLine());
                }
                while (arr[i] < 0);
            }

            int indice = 0;
            foreach (var nombre in nombres)
            {
                Console.WriteLine($"Lista de invitados {nombre} | Edad: {arr[indice]}");
                indice++;
            }
        }
    }
}
