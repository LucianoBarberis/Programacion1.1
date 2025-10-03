using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Listas
{
    internal class GestionDeinventario
    {
        static List<Producto> lista = new List<Producto>();
        public static void ShowMenuInventario()
        {
            bool salir = false;

            do
            {
                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║       Gestion De Inventario      ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Añadir un nuevo producto      ║");
                Console.WriteLine("║ 2. Eliminar un producto          ║");
                Console.WriteLine("║ 3. Buscar Producto               ║");
                Console.WriteLine("║ 0. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║        Lista de Productos        ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                foreach (Producto p in lista)
                {
                    Console.WriteLine("║ " + p);
                }
                Console.WriteLine("╚══════════════════════════════════╝");
                

                Console.WriteLine("\nSeleccione una opcion:");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddProduct();
                        break;
                    case "2": 
                        DeleteProduct();
                        break;
                    case "3":
                        SearchProduct();
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

        private static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el Nombre: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad: ");
            int quantity = 0;
            try
            {
                quantity = Convert.ToInt32(Console.ReadLine());
            }catch
            {
                Console.WriteLine("Ingrese un numero valido...");
                Pausa();
            }

            Producto producto = new Producto();

            producto.quantity = quantity;
            producto.name = name;
            
            lista.Add(producto);
        }

        private static void DeleteProduct()
        {
            string? name;
            
            Console.Clear();
            Console.WriteLine("Nombre del producto a eliminar: ");
            name = Console.ReadLine();
            try
            {
                lista.RemoveAt(lista.FindIndex(x => x.name == name));
            }catch
            {
                Console.WriteLine("El producto que intentas eliminar no existe...");
                Pausa();
            }
        }

        private static void SearchProduct()
        {
            string? productToSearch;

            Console.Clear();
            Console.WriteLine("Buscar: ");
            productToSearch = Console.ReadLine();
            List<Producto> searchResults = new List<Producto>();

            if (!string.IsNullOrEmpty(productToSearch))
            {
                searchResults = lista.FindAll(x => x.name == productToSearch);
            }
            Console.WriteLine("╔══════════════════════════════════╗");
            Console.WriteLine("║     Resultados de la Busqueda    ║");
            Console.WriteLine("╠══════════════════════════════════╣");
            if (searchResults.Count == 0)
            {
                Console.WriteLine("║   No se encontraron resultados   ║");
            }
            else
            {
                foreach (Producto p in searchResults)
                {
                    Console.WriteLine($"║ Nombre: {p.name}, Cantidad: {p.quantity}");
                }
            }
            Console.WriteLine("╚══════════════════════════════════╝");
            Pausa();
        }

        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
