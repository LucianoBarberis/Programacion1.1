using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.LinkedList
{
    internal class ReproductorMusica
    {
        private static LinkedList<string> playlist = new LinkedList<string>();
        private static LinkedListNode<string> cancionActual = null;

        public static void ShowMenuReproductor()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║      Reproductor de Musica        ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Agregar Cancion                ║");
                Console.WriteLine("║ 2. Reproducir Siguiente           ║");
                Console.WriteLine("║ 3. Reproducir Anterior            ║");
                Console.WriteLine("║ 4. Eliminar Cancion               ║");
                Console.WriteLine("║ 5. Mostrar Playlist               ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");

                MostrarPlaylist();
                MostrarCancionActual();
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AgregarCancion();
                        break;
                    case "2":
                        ReproducirSiguiente();
                        break;
                    case "3":
                        ReproducirAnterior();
                        break;
                    case "4":
                        EliminarCancion();
                        break;
                    case "5":
                        MostrarPlaylist();
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

        private static void AgregarCancion()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de la canción: ");
            string cancion = Console.ReadLine();
            if (!string.IsNullOrEmpty(cancion))
            {
                playlist.AddLast(cancion);
                if (cancionActual == null)
                {
                    cancionActual = playlist.Last;
                }
                Console.WriteLine($"Canción '{cancion}' agregada a la playlist.");
            }
            MenuLinkedList.Pausa();
        }

        private static void ReproducirSiguiente()
        {
            if (cancionActual != null && cancionActual.Next != null)
            {
                cancionActual = cancionActual.Next;
                Console.WriteLine($"Reproduciendo: {cancionActual.Value}");
            }
            else if (playlist.Count > 0)
            {
                cancionActual = playlist.First;
                Console.WriteLine($"Volviendo al inicio: {cancionActual.Value}");
            }
            else
            {
                Console.WriteLine("No hay canciones en la playlist.");
            }
            MenuLinkedList.Pausa();
        }

        private static void ReproducirAnterior()
        {
            if (cancionActual != null && cancionActual.Previous != null)
            {
                cancionActual = cancionActual.Previous;
                Console.WriteLine($"Reproduciendo: {cancionActual.Value}");
            }
            else if (playlist.Count > 0)
            {
                cancionActual = playlist.Last;
                Console.WriteLine($"Saltando al final: {cancionActual.Value}");
            }
            else
            {
                Console.WriteLine("No hay canciones en la playlist.");
            }
            MenuLinkedList.Pausa();
        }

        private static void EliminarCancion()
        {
            if (playlist.Count == 0)
            {
                Console.WriteLine("No hay canciones en la playlist.");
                MenuLinkedList.Pausa();
                return;
            }

            Console.Clear();
            MostrarPlaylist();
            Console.WriteLine("\nIngrese el nombre de la canción a eliminar: ");
            string cancion = Console.ReadLine();

            if (!string.IsNullOrEmpty(cancion))
            {
                LinkedListNode<string> nodoActual = playlist.First;
                while (nodoActual != null)
                {
                    if (nodoActual.Value.Equals(cancion, StringComparison.OrdinalIgnoreCase))
                    {
                        if (nodoActual == cancionActual)
                        {
                            cancionActual = nodoActual.Next ?? playlist.First;
                        }
                        playlist.Remove(nodoActual);
                        Console.WriteLine($"Canción '{cancion}' eliminada de la playlist.");
                        break;
                    }
                    nodoActual = nodoActual.Next;
                }
            }
            MenuLinkedList.Pausa();
        }

        private static void MostrarPlaylist()
        {
            Console.WriteLine("\nLista de Reproducción:");
            if (playlist.Count == 0)
            {
                Console.WriteLine("La playlist está vacía");
                return;
            }

            int posicion = 1;
            foreach (string cancion in playlist)
            {
                Console.WriteLine($"{posicion}. {cancion}");
                posicion++;
            }
        }

        private static void MostrarCancionActual()
        {
            if (cancionActual != null)
            {
                Console.WriteLine($"\nReproduciendo ahora: {cancionActual.Value}");
            }
        }
    }
}