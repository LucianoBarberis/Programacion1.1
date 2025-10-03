using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.LinkedList
{
    internal class TextEditor
    {
        private static LinkedList<string> historialAcciones = new LinkedList<string>();
        private static LinkedListNode<string> posicionActual = null;
        private static string textoActual = "";

        public static void ShowMenuTextEditor()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║         Editor de Texto           ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Escribir Texto                 ║");
                Console.WriteLine("║ 2. Deshacer (Undo)                ║");
                Console.WriteLine("║ 3. Rehacer (Redo)                 ║");
                Console.WriteLine("║ 4. Ver Texto Actual               ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                MostrarTextoActual();
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        EscribirTexto();
                        break;
                    case "2":
                        Deshacer();
                        break;
                    case "3":
                        Rehacer();
                        break;
                    case "4":
                        MostrarTextoActual();
                        MenuLinkedList.Pausa();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        MenuLinkedList.Pausa();
                        break;
                }
            } while (!salir);
        }

        private static void EscribirTexto()
        {
            Console.Clear();
            Console.WriteLine("Texto actual: " + textoActual);
            Console.WriteLine("\nEscriba el texto a agregar: ");
            string nuevoTexto = Console.ReadLine();

            if (!string.IsNullOrEmpty(nuevoTexto))
            {
                // Si estamos en medio del historial, eliminar todo lo que está adelante
                if (posicionActual != null && posicionActual != historialAcciones.Last)
                {
                    while (historialAcciones.Last != posicionActual)
                    {
                        historialAcciones.RemoveLast();
                    }
                }

                textoActual += (textoActual.Length > 0 ? " " : "") + nuevoTexto;
                historialAcciones.AddLast(textoActual);
                posicionActual = historialAcciones.Last;
                Console.WriteLine("\nTexto agregado correctamente.");
            }
            MenuLinkedList.Pausa();
        }

        private static void Deshacer()
        {
            if (posicionActual != null && posicionActual != historialAcciones.First)
            {
                posicionActual = posicionActual.Previous;
                textoActual = posicionActual.Value;
                Console.WriteLine("Acción deshecha.");
            }
            else
            {
                Console.WriteLine("No hay más acciones para deshacer.");
            }
            MenuLinkedList.Pausa();
        }

        private static void Rehacer()
        {
            if (posicionActual != null && posicionActual.Next != null)
            {
                posicionActual = posicionActual.Next;
                textoActual = posicionActual.Value;
                Console.WriteLine("Acción rehecha.");
            }
            else
            {
                Console.WriteLine("No hay más acciones para rehacer.");
            }
            MenuLinkedList.Pausa();
        }

        private static void MostrarTextoActual()
        {
            Console.WriteLine("\nTexto Actual:");
            Console.WriteLine("-------------");
            Console.WriteLine(textoActual);
            Console.WriteLine("-------------");
        }
    }
}