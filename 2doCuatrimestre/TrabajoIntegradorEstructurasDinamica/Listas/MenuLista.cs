using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Listas
{
    internal class MenuLista
    {
        public static void MostarMenuLista() 
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║       Ejercicios De Listas       ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Gestion de Inventario         ║");
                Console.WriteLine("║ 2. To-Do List                    ║");
                Console.WriteLine("║ 3. Gestión de Calificaciones     ║");
                Console.WriteLine("║ 0. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        GestionDeinventario.ShowMenuInventario();
                        break;
                    case "2":
                        ToDoList.ShowMenuToDo();
                        break;
                    case "3":
                        GestionDeCalificaciones.ShowMenuCalificaciones();
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
