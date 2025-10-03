using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorEstructurasDinamica.Listas;

namespace TrabajoIntegradorEstructurasDinamica.Stack
{
    internal class MenuPila
    {
        public static void MostarMenuPila()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║       Ejercicios De la Pila       ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Pila de Platos                 ║");
                Console.WriteLine("║ 2. Paréntesis Balanceados         ║");
                Console.WriteLine("║ 3. Historial de Navegación        ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        PilaPlatos.ShowMenuPlatos();
                        break;
                    case "2":
                        PilaParentesis.ShowMenuParentesis();
                        break;
                    case "3":
                        PilaNavegacion.ShowMenuNavegacion();
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
