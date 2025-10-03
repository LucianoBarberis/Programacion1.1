using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Dictionary
{
    internal class CatalogoProductos
    {
        static Dictionary<string, string> CatalogoProd = new Dictionary<string, string>();
        public static void ShowMenuProductos()
        {
            bool salir = false;

            do
            {

                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║        Menu del Catalogo         ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Añadir Producto               ║");
                Console.WriteLine("║ 2. Buscar Producto               ║");
                Console.WriteLine("║ 3. Eliminar Producto             ║");
                Console.WriteLine("║ 0. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║      Catalogo de Productos       ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                foreach (KeyValuePair<string, string> par in CatalogoProd)
                {
                    Console.WriteLine($"║ {par.Key}: {par.Value}");
                }
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddProducto();
                        break;
                    case "2":
                        SearchProducto();
                        break;
                    case "3":
                        DeleteProducto();
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

        private static void AddProducto()
        {
            string? ProductName;
            string? SKUNumbre;

            do
            {
                Console.Clear();
                Console.WriteLine("Nombre del Producto: ");
                ProductName = Console.ReadLine();
                Console.WriteLine("Numero SKU: ");
                SKUNumbre = Console.ReadLine();
            } while (string.IsNullOrEmpty(ProductName) || string.IsNullOrEmpty(SKUNumbre));

            if (!string.IsNullOrEmpty(ProductName) && !string.IsNullOrEmpty(SKUNumbre))
            {
                CatalogoProd.Add(ProductName, SKUNumbre);
            }
        }
        private static void SearchProducto()
        {
            string? ProductToSearch;

            do
            {
                Console.Clear();
                Console.WriteLine("Busqueda: ");
                ProductToSearch = Console.ReadLine();
            } while (string.IsNullOrEmpty(ProductToSearch));

            if (CatalogoProd.ContainsKey(ProductToSearch))
            {
                Console.WriteLine($"Resultado para {ProductToSearch}: {CatalogoProd[ProductToSearch]}");
            }
            else
            {
                Console.WriteLine("No se encontraron resultados para " + ProductToSearch);
            }
            Pausa();
        }
        private static void DeleteProducto()
        {
            string? ProductToDelete;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del contacto a eliminar: ");
                ProductToDelete = Console.ReadLine();
            } while (string.IsNullOrEmpty(ProductToDelete));

            if (CatalogoProd.ContainsKey(ProductToDelete))
            {
                CatalogoProd.Remove(ProductToDelete);
                Console.WriteLine($"El contacto {ProductToDelete} ha sido eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine($"No se encontró el contacto {ProductToDelete}");
            }
            Pausa();
        }

        public static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
