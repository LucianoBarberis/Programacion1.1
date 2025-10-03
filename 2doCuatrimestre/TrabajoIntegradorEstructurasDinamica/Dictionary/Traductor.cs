using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Dictionary
{
    internal class Traductor
    {
        static Dictionary<string, string> traducciones = new Dictionary<string, string>();
        public static void ShowMenuTraductor()
        {
            bool salir = false;

            do
            {

                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║          Menu Traductor          ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Añadir Traduccion             ║");
                Console.WriteLine("║ 2. Buscar Traduccion             ║");
                Console.WriteLine("║ 0. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║      Traducciones Guardadas      ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                foreach (KeyValuePair<string, string> par in traducciones)
                {
                    Console.WriteLine($"║ {par.Key} -> {par.Value}");
                }
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddTraduccion();
                        break;
                    case "2":
                        SearchTraduccion();
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

        private static void SearchTraduccion()
        {
            string searchResults;
            string wordToSearch;

            Console.WriteLine("Busqueda: ");
            wordToSearch = Console.ReadLine();

            if(traducciones.TryGetValue(wordToSearch, out searchResults))
            {
                Console.WriteLine($"La traduccion para {wordToSearch} es {searchResults}");
            }else
            {
                Console.WriteLine("No se encontraron resultados para la traduccion...");
            }
            Pausa();
        }

        private static void AddTraduccion()
        {
            string wordSpanish;
            string wordEnglish;

            do
            {
                Console.Clear();
                Console.WriteLine("Palabra en Español: ");
                wordSpanish = Console.ReadLine();
                Console.WriteLine("Palabra en Ingles: ");
                wordEnglish = Console.ReadLine();
            } while (string.IsNullOrEmpty(wordEnglish) || string.IsNullOrEmpty(wordSpanish)); 
            
            traducciones.Add(wordSpanish, wordEnglish); 
        }
        public static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
