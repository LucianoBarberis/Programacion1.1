using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoIntegradorEstructurasDinamica.Listas;

namespace TrabajoIntegradorEstructurasDinamica.LinkedList
{
    internal class MenuLinkedList
    {
        public static void MostarMenuListaEnlazada()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║   Ejercicios De Listas Enlazadas  ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Lista de Espera en Restaurante ║");
                Console.WriteLine("║ 2. Editor de Texto                ║");
                Console.WriteLine("║ 3. Reproducción de Música         ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ListaEspera.ShowMenuListaDeEspera();
                        break;
                    case "2":
                        TextEditor.ShowMenuTextEditor();
                        break;
                    case "3":
                        ReproductorMusica.ShowMenuReproductor();
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
