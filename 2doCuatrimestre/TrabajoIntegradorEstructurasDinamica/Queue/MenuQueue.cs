using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorEstructurasDinamica.Listas;

namespace TrabajoIntegradorEstructurasDinamica.Queue
{
    internal class MenuQueue
    {
        public static void MostarMenuCola()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║       Ejercicios De la Fila       ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Cola de Impresión              ║");
                Console.WriteLine("║ 2. Simulador de Call Center       ║");
                Console.WriteLine("║ 3. Procesos en el SO              ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ColaImpresion.ShowMenuCola();
                        break;
                    case "2":
                        MenuCallCenter.ShowMenuCallCenter();
                        break;
                    case "3":
                        MenuSimularProcesos.ShowMenuProcesos();
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
