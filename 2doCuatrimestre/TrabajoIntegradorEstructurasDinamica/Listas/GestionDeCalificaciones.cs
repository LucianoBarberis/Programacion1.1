using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Listas
{
    internal class GestionDeCalificaciones
    {
        static List<decimal> calificaciones = new List<decimal>();
        public static void ShowMenuCalificaciones()
        {
            bool salir = false;


            do
            {
                decimal total = 0;
                decimal prom = 0;

                calificaciones.ForEach(calificacion =>
                {
                    total += calificacion;
                });


                if(total != 0)
                {
                    prom = total/calificaciones.Count;
                }

                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║     Gestion De Calificaciones      ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                Console.WriteLine("║ 1. Añadir Calificación             ║");
                Console.WriteLine("║ 2. Eliminar Calificación Alta/Baja ║");
                Console.WriteLine("║ 0. Salir                           ║");
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║      Lista de Calificaciones       ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                foreach (decimal p in calificaciones)
                {
                    Console.WriteLine("║  * " + p);
                }
                Console.WriteLine("╚════════════════════════════════════╝");
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║              Promedio              ║");
                Console.WriteLine("╠════════════════════════════════════╣");
                Console.WriteLine($"║              {prom.ToString("F2")}                ");
                Console.WriteLine("╚════════════════════════════════════╝");


                Console.WriteLine("\nSeleccione una opcion:");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        AddCalificacion();
                        break;
                    case "2":
                        DeleteCalificacion();
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

        static private void AddCalificacion()
        {
            decimal Calificacion = 0;

            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Calificacion: ");
                    Calificacion = Convert.ToDecimal(Console.ReadLine());
                }
                while (Calificacion > 10 || Calificacion < 0);
            }catch
            {
                Console.WriteLine("Ingresa una calificacion valida");
            }

            calificaciones.Add(Calificacion);

            
        }

        static private void DeleteCalificacion()
        {
            int opc = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("Eliminar calificacion Alta/Baja (1/0)");
                opc = Convert.ToInt32(Console.ReadLine());
            } while (opc != 1 && opc != 0);

            if ( opc == 1)
            {
                calificaciones.Remove(calificaciones.Max());
            } else
            {
                calificaciones.Remove(calificaciones.Min());
            }
        }

        static void Pausa()
        {
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
