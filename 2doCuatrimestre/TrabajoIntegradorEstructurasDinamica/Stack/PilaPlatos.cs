using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.Stack
{
    internal class PilaPlatos
    {
        public static Stack<int> Platos = new Stack<int>();
        public static int plato = 0;
        public static void ShowMenuPlatos()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("╔═════════════════════════════════╗");
                Console.WriteLine("║          Pila de Platos         ║");
                Console.WriteLine("╠═════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Plato                ║");
                Console.WriteLine("║ 2. Quitar Plato                 ║");
                Console.WriteLine("║ 0. Salir                        ║");
                Console.WriteLine("╚═════════════════════════════════╝");
                foreach (var item in Platos)
                {
                    Console.WriteLine($"Plato {item}");
                }
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarPlato();
                        break;
                    case "2":
                        QuitarPlato();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        MenuPila.Pausa();
                        break;
                }
            } while (!salir);
        }
        private static void AgregarPlato() 
        {
            Platos.Push(plato);
            plato++;
        }
        private static void QuitarPlato() 
        {
            if(Platos.Count > 0)
            {
                Platos.Pop();
            }
        }
    }
}
