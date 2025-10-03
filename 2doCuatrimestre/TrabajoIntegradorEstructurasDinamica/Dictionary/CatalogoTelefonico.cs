using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Dictionary
{
    internal class CatalogoTelefonico
    {
        static Dictionary<string, string> CatalogoTel = new Dictionary<string, string>();
        public static void ShowMenuDirectorio()
        {
            bool salir = false;

            do
            {

                Console.Clear();
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║        Menu de Contactos         ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                Console.WriteLine("║ 1. Añadir Contacto               ║");
                Console.WriteLine("║ 2. Buscar Contacto               ║");
                Console.WriteLine("║ 3. Eliminar Contacto             ║");
                Console.WriteLine("║ 0. Salir                         ║");
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("╔══════════════════════════════════╗");
                Console.WriteLine("║       Contactos Guardados        ║");
                Console.WriteLine("╠══════════════════════════════════╣");
                foreach (KeyValuePair<string, string> par in CatalogoTel)
                {
                    Console.WriteLine($"║ {par.Key}: {par.Value}");
                }
                Console.WriteLine("╚══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddContacto();
                        break;
                    case "2":
                        SearchContacto();
                        break;
                    case "3":
                        DeleteContacto();
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

        private static void AddContacto()
        {
            string? TelNameContact;
            string? TelNumber;

            do
            {
                Console.Clear();
                Console.WriteLine("Nombre del Contacto: ");
                TelNameContact = Console.ReadLine();
                Console.WriteLine("Numero de telefono: ");
                TelNumber = Console.ReadLine();
            } while (string.IsNullOrEmpty(TelNameContact) || string.IsNullOrEmpty(TelNumber));

            if(!string.IsNullOrEmpty(TelNameContact) && !string.IsNullOrEmpty(TelNumber))
            {
                CatalogoTel.Add(TelNameContact, TelNumber);
            }
        }

        private static void SearchContacto()
        {
            string? ContactToSearch;

            do
            {
                Console.Clear();
                Console.WriteLine("Busqueda: ");
                ContactToSearch = Console.ReadLine();
            } while (string.IsNullOrEmpty(ContactToSearch));

            if (CatalogoTel.ContainsKey(ContactToSearch)) {
                Console.WriteLine($"Resultado para {ContactToSearch}: {CatalogoTel[ContactToSearch]}");
            }else
            {
                Console.WriteLine("No se encontraron resultados para " + ContactToSearch);
            }
            Pausa();
        }

        private static void DeleteContacto()
        {
            string? ContactToDelete;

            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del contacto a eliminar: ");
                ContactToDelete = Console.ReadLine();
            } while (string.IsNullOrEmpty(ContactToDelete));

            if (CatalogoTel.ContainsKey(ContactToDelete))
            {
                CatalogoTel.Remove(ContactToDelete);
                Console.WriteLine($"El contacto {ContactToDelete} ha sido eliminado exitosamente.");
            }
            else
            {
                Console.WriteLine($"No se encontró el contacto {ContactToDelete}");
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
