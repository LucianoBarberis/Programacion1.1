namespace TrabajoIntegradorEstructurasDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════════════╗");
                Console.WriteLine("║      Problemas por Tipo de Estructura    ║");
                Console.WriteLine("╠══════════════════════════════════════════╣");
                Console.WriteLine("║ 1. List                                  ║");
                Console.WriteLine("║ 2. LinkedList                            ║");
                Console.WriteLine("║ 3. Stack                                 ║");
                Console.WriteLine("║ 4. Queue                                 ║");
                Console.WriteLine("║ 5. Dictionary                            ║");
                Console.WriteLine("║ 0. Salir                                 ║");
                Console.WriteLine("╚══════════════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1": 
                        Listas.MenuLista.MostarMenuLista();
                        break;
                    case "2": 
                        LinkedList.MenuLinkedList.MostarMenuListaEnlazada(); 
                        break;
                    case "3":
                        Stack.MenuPila.MostarMenuPila();
                        break;
                    case "4":
                        Queue.MenuQueue.MostarMenuCola();
                        break;
                    case "5":
                        Dictionary.MenuDiccionario.MostarMenuDiccionario();
                        break;
                    case "0": salir = true;
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Presione cualquier tecla para continuar...");
                        Pausa();
                        break;
                }
            } while (!salir);
        }
        public static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
