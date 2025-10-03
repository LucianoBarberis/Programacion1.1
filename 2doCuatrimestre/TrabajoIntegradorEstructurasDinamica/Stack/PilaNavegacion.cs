using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.Stack
{
    internal class PilaNavegacion
    {
        private static Stack<string> historial = new Stack<string>();
        private static string paginaActual = null;

        public static void ShowMenuNavegacion()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║          Pila Navegacion          ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Ir a una nueva pagina          ║");
                Console.WriteLine("║ 2. Volver pagina anterior         ║");
                Console.WriteLine("║ 3. Ver historial                  ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                Console.WriteLine($"\nPágina actual: {(paginaActual ?? "Ninguna")}");
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        IrNuevaPagina();
                        break;
                    case "2":
                        VolverAtras();
                        break;
                    case "3":
                        VerHistorial();
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
        private static void IrNuevaPagina()
        {
            Console.Write("Ingrese la URL o nombre de la nueva página: ");
            string nuevaPagina = Console.ReadLine();
            if (!string.IsNullOrEmpty(paginaActual))
            {
                historial.Push(paginaActual);
            }
            paginaActual = nuevaPagina;
            Console.WriteLine($"Navegando a: {paginaActual}");
            MenuPila.Pausa();
        }
        private static void VolverAtras()
        {
            if (historial.Count > 0)
            {
                paginaActual = historial.Pop();
                Console.WriteLine($"Volviste a: {paginaActual}");
            }
            else
            {
                Console.WriteLine("No hay páginas anteriores en el historial.");
            }
            MenuPila.Pausa();
        }
        private static void VerHistorial()
        {
            Console.WriteLine("\nHistorial de navegación:");
            if (historial.Count == 0)
            {
                Console.WriteLine("No hay historial.");
            }
            else
            {
                foreach (var pagina in historial)
                {
                    Console.WriteLine(pagina);
                }
            }
            MenuPila.Pausa();
        }
    }
}
