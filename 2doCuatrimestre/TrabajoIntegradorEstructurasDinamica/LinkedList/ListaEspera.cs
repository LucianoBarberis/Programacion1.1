using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.LinkedList
{
    internal class ListaEspera
    {
        private static LinkedList<string> listaEspera = new LinkedList<string>();

        public static void ShowMenuListaDeEspera()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║      Lista de Espera Restaurante  ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Cliente                ║");
                Console.WriteLine("║ 2. Sentar Próximo Cliente         ║");
                Console.WriteLine("║ 3. Cliente Abandona Lista         ║");
                Console.WriteLine("║ 4. Ver Lista de Espera            ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                MostrarListaActual();
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCliente();
                        break;
                    case "2":
                        SentarCliente();
                        break;
                    case "3":
                        AbandonarLista();
                        break;
                    case "4":
                        MostrarListaActual();
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

        private static void AgregarCliente()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();
            if (!string.IsNullOrEmpty(nombre))
            {
                listaEspera.AddLast(nombre);
                Console.WriteLine($"Cliente {nombre} agregado a la lista de espera.");
            }
            MenuLinkedList.Pausa();
        }

        private static void SentarCliente()
        {
            if (listaEspera.Count > 0)
            {
                string cliente = listaEspera.First.Value;
                listaEspera.RemoveFirst();
                Console.WriteLine($"Cliente {cliente} ha sido sentado.");
            }
            else
            {
                Console.WriteLine("No hay clientes en la lista de espera.");
            }
            MenuLinkedList.Pausa();
        }

        private static void AbandonarLista()
        {
            if (listaEspera.Count == 0)
            {
                Console.WriteLine("No hay clientes en la lista de espera.");
                MenuLinkedList.Pausa();
                return;
            }

            Console.Clear();
            MostrarListaActual();
            Console.WriteLine("\nIngrese el nombre del cliente que abandona la lista: ");
            string nombre = Console.ReadLine();

            if (!string.IsNullOrEmpty(nombre))
            {
                bool encontrado = false;
                LinkedListNode<string> nodoActual = listaEspera.First;
                while (nodoActual != null)
                {
                    if (nodoActual.Value.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                    {
                        listaEspera.Remove(nodoActual);
                        encontrado = true;
                        Console.WriteLine($"Cliente {nombre} ha abandonado la lista.");
                        break;
                    }
                    nodoActual = nodoActual.Next;
                }

                if (!encontrado)
                {
                    Console.WriteLine($"No se encontró al cliente {nombre} en la lista.");
                }
            }
            MenuLinkedList.Pausa();
        }

        private static void MostrarListaActual()
        {
            Console.WriteLine("\nLista de Espera Actual:");
            if (listaEspera.Count == 0)
            {
                Console.WriteLine("No hay clientes en espera");
                return;
            }

            int posicion = 1;
            foreach (string cliente in listaEspera)
            {
                Console.WriteLine($"{posicion}. {cliente}");
                posicion++;
            }
        }
    }
}