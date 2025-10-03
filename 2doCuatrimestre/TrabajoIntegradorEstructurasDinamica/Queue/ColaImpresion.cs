using System;
using System.Collections.Generic;
using System.Threading;

namespace TrabajoIntegradorEstructurasDinamica.Queue
{
    internal class ColaImpresion
    {
        private static Queue<string> colaDocumentos = new Queue<string>();
        private static bool imprimiendo = false;

        public static void ShowMenuCola()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║      Cola de Impresión            ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Documento              ║");
                Console.WriteLine("║ 2. Imprimir Siguiente             ║");
                Console.WriteLine("║ 3. Ver Cola de Impresión          ║");
                Console.WriteLine("║ 4. Imprimir Todo                  ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                MostrarColaActual();
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarDocumento();
                        break;
                    case "2":
                        ImprimirSiguiente();
                        break;
                    case "3":
                        MostrarColaActual();
                        MenuQueue.Pausa();
                        break;
                    case "4":
                        ImprimirTodo();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        MenuQueue.Pausa();
                        break;
                }
            } while (!salir);
        }

        private static void AgregarDocumento()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del documento: ");
            string documento = Console.ReadLine();
            
            if (!string.IsNullOrEmpty(documento))
            {
                colaDocumentos.Enqueue(documento);
                Console.WriteLine($"Documento '{documento}' agregado a la cola de impresión.");
            }
            MenuQueue.Pausa();
        }

        private static void ImprimirSiguiente()
        {
            if (colaDocumentos.Count > 0 && !imprimiendo)
            {
                imprimiendo = true;
                string documento = colaDocumentos.Dequeue();
                Console.WriteLine($"\nImprimiendo: {documento}");
                Console.Write("Progreso: ");
                
                for (int i = 0; i <= 10; i++)
                {
                    Console.Write($"{i * 10}% ");
                    Thread.Sleep(200); // Simula el tiempo de impresión
                }
                
                Console.WriteLine("\nDocumento impreso exitosamente!");
                imprimiendo = false;
            }
            else if (imprimiendo)
            {
                Console.WriteLine("\nYa hay un documento en proceso de impresión.");
            }
            else
            {
                Console.WriteLine("\nNo hay documentos en la cola de impresión.");
            }
            MenuQueue.Pausa();
        }

        private static void ImprimirTodo()
        {
            if (colaDocumentos.Count == 0)
            {
                Console.WriteLine("\nNo hay documentos en la cola de impresión.");
                MenuQueue.Pausa();
                return;
            }

            Console.WriteLine("\nIniciando impresión de todos los documentos...");
            
            while (colaDocumentos.Count > 0)
            {
                ImprimirSiguiente();
            }

            Console.WriteLine("\nTodos los documentos han sido impresos.");
            MenuQueue.Pausa();
        }

        private static void MostrarColaActual()
        {
            Console.WriteLine("\nDocumentos en Cola:");
            Console.WriteLine("-------------------");
            if (colaDocumentos.Count == 0)
            {
                Console.WriteLine("No hay documentos en cola");
                return;
            }

            int posicion = 1;
            foreach (string documento in colaDocumentos)
            {
                Console.WriteLine($"{posicion}. {documento}");
                posicion++;
            }
            Console.WriteLine($"\nTotal de documentos en cola: {colaDocumentos.Count}");
        }
    }
}