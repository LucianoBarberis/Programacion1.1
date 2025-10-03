using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorEstructurasDinamica.Listas;

namespace TrabajoIntegradorEstructurasDinamica.Dictionary
{
    internal class MenuDiccionario
    {
        public static void MostarMenuDiccionario()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║     Ejercicios De Diccionario     ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Directorio Telefónico          ║");
                Console.WriteLine("║ 2. Catálogo de Productos          ║");
                Console.WriteLine("║ 3. Traductor de Idiomas           ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CatalogoTelefonico.ShowMenuDirectorio();
                        break;
                    case "2":
                        //ShowMenuProductos();
                        break;
                    case "3":
                        Traductor.ShowMenuTraductor();
                        break;
                    case "0":
                        salir = true;
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
