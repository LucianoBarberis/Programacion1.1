using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Listas
{
    internal class ToDoList
    {
        static List<string> Tasks = new List<string>();
        public static void ShowMenuToDo()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║         Menu To-do List          ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Nueva Tarea                   ║");
                Console.WriteLine("║ 2. Eliminar Tarea                ║");
                Console.WriteLine("║ 0. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║         Lista de Tareas          ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Tasks.ForEach(x => Console.WriteLine("║   * " + x));
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        RemoveTask();
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
        private static void AddTask()
        {
            Console.Clear();
            string? Tarea;
            Console.WriteLine("Tarea a realizar: ");
            Tarea = Console.ReadLine();
            if (!string.IsNullOrEmpty(Tarea))
            {
                Tasks.Add(Tarea);
            }
        }

        private static void RemoveTask()
        {
            Console.Clear();
            string? TaskToDelete;
            Console.WriteLine("Tarea a eliminar");
            TaskToDelete = Console.ReadLine();
            if (!string.IsNullOrEmpty(TaskToDelete))
            {
                Tasks.Remove(TaskToDelete);
            }
        }

        public static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
