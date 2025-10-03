using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Queue
{
    internal class MenuCallCenter
    {
        static Queue<string> CallQueque = new Queue<string>();

        public static void ShowMenuCallCenter()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║         Cola de Llamadas          ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Add Process                    ║");
                Console.WriteLine("║ 2. Finalizar Proceso              ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("Lista de Llamadas:");
                Console.WriteLine("--------");
                foreach (var item in CallQueque)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("--------");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddCall();
                        break;
                    case "2":
                        AttendCall();
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
        public static void AddCall()
        {
            Console.Clear();
            string? telNumber;

            Console.WriteLine("Nuevo Proceso: ");
            telNumber = Console.ReadLine();
            if (!string.IsNullOrEmpty(telNumber))
            {
                CallQueque.Enqueue(telNumber);
            }
            else
            {
                Console.WriteLine("Ejecuta un proceso valido...");
                MenuQueue.Pausa();
            }
        }
        public static void AttendCall()
        {
            if (CallQueque.Count > 0)
            {
                CallQueque.Dequeue();
            }
        }
    }
}
