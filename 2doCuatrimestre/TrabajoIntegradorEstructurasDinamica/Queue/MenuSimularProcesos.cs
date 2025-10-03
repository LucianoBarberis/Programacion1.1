using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Queue
{
    internal class MenuSimularProcesos
    {
        public static Queue<string> ProcessQueque = new Queue<string>();
        public static void ShowMenuProcesos()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║          Procesos del SO          ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Add Process                    ║");
                Console.WriteLine("║ 2. Finalizar Proceso              ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("Lista de Procesos:");
                Console.WriteLine("--------");
                foreach (var item in ProcessQueque)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("--------");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddProceso();
                        break;
                    case "2":
                        FinishProceso();
                        break;
                    case "0":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Presione cualquier tecla para continuar...");
                        MenuQueue.Pausa();
                        break;
                }
            } while (!salir);
        }
        public static void AddProceso()
        {
            Console.Clear();
            string? proceso;

            Console.WriteLine("Nuevo Proceso: ");
            proceso = Console.ReadLine();
            if (!string.IsNullOrEmpty(proceso))
            {
                ProcessQueque.Enqueue(proceso);
            }else
            {
                Console.WriteLine("Ejecuta un proceso valido...");
                MenuQueue.Pausa();
            }
        }

        public static void FinishProceso()
        {
            if (ProcessQueque.Count > 0)
            {
                ProcessQueque.Dequeue();
            }
        }
    }
}
