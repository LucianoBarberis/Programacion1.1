using System;
using System.Collections.Generic;

namespace PruebaListasDinamicas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejemplo de Arreglos Estáticos ===");
            // Arreglo estático - Tamaño fijo definido en la declaración
            int[] arregloEstatico = new int[5];
            
            // Llenar el arreglo estático
            for (int i = 0; i < arregloEstatico.Length; i++)
            {
                arregloEstatico[i] = i + 1;
            }

            Console.WriteLine("Arreglo estático:");
            foreach (int numero in arregloEstatico)
            {
                Console.Write($"{numero} ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("=== Ejemplo de Arreglos Dinámicos (List<T>) ===");
            // Lista dinámica - Puede cambiar de tamaño en tiempo de ejecución
            List<int> listaDinamica = new List<int>();

            // Agregar elementos a la lista dinámica
            Console.WriteLine("Agregando elementos a la lista dinámica:");
            for (int i = 1; i <= 3; i++)
            {
                listaDinamica.Add(i);
                Console.WriteLine($"Agregado: {i} - Tamaño actual: {listaDinamica.Count}");
            }

            Console.WriteLine("\nAgregando más elementos:");
            listaDinamica.Add(4);
            listaDinamica.Add(5);
            
            Console.WriteLine("Lista dinámica actual:");
            foreach (int numero in listaDinamica)
            {
                Console.Write($"{numero} ");
            }

            // Demostrar operaciones adicionales con lista dinámica
            Console.WriteLine("\n\nOperaciones con lista dinámica:");
            Console.WriteLine($"Cantidad de elementos: {listaDinamica.Count}");
            
            // Remover un elemento
            listaDinamica.Remove(3);
            Console.WriteLine("\nDespués de remover el número 3:");
            foreach (int numero in listaDinamica)
            {
                Console.Write($"{numero} ");
            }

            // Insertar un elemento en una posición específica
            listaDinamica.Insert(2, 10);
            Console.WriteLine("\n\nDespués de insertar 10 en la posición 2:");
            foreach (int numero in listaDinamica)
            {
                Console.Write($"{numero} ");
            }

            // Ejemplo de lista enlazada
            Console.WriteLine("\n\n=== Ejemplo de Lista Enlazada (LinkedList<T>) ===");
            LinkedList<int> listaEnlazada = new LinkedList<int>();

            // Agregar elementos al inicio y al final
            listaEnlazada.AddLast(1);
            listaEnlazada.AddLast(2);
            listaEnlazada.AddLast(3);
            listaEnlazada.AddFirst(0);

            Console.WriteLine("Lista enlazada actual:");
            foreach (int numero in listaEnlazada)
            {
                Console.Write($"{numero} ");
            }

            // Eliminar un elemento
            listaEnlazada.Remove(2);
            Console.WriteLine("\nDespués de eliminar el número 2:");
            foreach (int numero in listaEnlazada)
            {
                Console.Write($"{numero} ");
            }

            // Insertar después de un nodo específico
            LinkedListNode<int> nodo = listaEnlazada.Find(1);
            if (nodo != null)
            {
                listaEnlazada.AddAfter(nodo, 5);
            }
            Console.WriteLine("\nDespués de insertar 5 después del 1:");
            foreach (int numero in listaEnlazada)
            {
                Console.Write($"{numero} ");
            }

            Console.WriteLine("\n\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}