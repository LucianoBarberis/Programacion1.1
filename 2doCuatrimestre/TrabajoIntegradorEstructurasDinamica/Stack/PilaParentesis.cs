using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.Stack
{
    internal class PilaParentesis
    {
        private static List<string> historialExpresiones = new List<string>();

        public static void ShowMenuParentesis()
        {
            bool salir = false;
            do
            {
                Console.Clear();
                Console.WriteLine("╔═══════════════════════════════════╗");
                Console.WriteLine("║     Paréntesis Balanceados        ║");
                Console.WriteLine("╠═══════════════════════════════════╣");
                Console.WriteLine("║ 1. Verificar Expresión            ║");
                Console.WriteLine("║ 2. Mostrar Ejemplo                ║");
                Console.WriteLine("║ 3. Ver Historial                  ║");
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        VerificarExpresion();
                        break;
                    case "2":
                        MostrarEjemplo();
                        break;
                    case "3":
                        VerHistorial();
                        break;
                    case "0":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione cualquier tecla para continuar...");
                        MenuPila.Pausa();
                        break;
                }
            } while (!salir);
        }
        private static void VerificarExpresion()
        {
            Console.Write("Ingrese la expresión a verificar: ");
            string expresion = Console.ReadLine();
            bool balanceado = EsBalanceado(expresion);
            historialExpresiones.Add($"{expresion} => {(balanceado ? "Balanceado" : "No balanceado")}");
            Console.WriteLine(balanceado ? "La expresión está balanceada." : "La expresión NO está balanceada.");
            MenuPila.Pausa();
        }
        private static bool EsBalanceado(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            Dictionary<char, char> pares = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
            foreach (char c in expresion)
            {
                if (pares.Values.Contains(c))
                {
                    pila.Push(c);
                }
                else if (pares.ContainsKey(c))
                {
                    if (pila.Count == 0 || pila.Pop() != pares[c])
                        return false;
                }
            }
            return pila.Count == 0;
        }
        private static void MostrarEjemplo()
        {
            Console.WriteLine("Ejemplo balanceado: (a+b)*[c-{d/e}]");
            Console.WriteLine("Ejemplo NO balanceado: (a+b]*{c-d)");
            Console.WriteLine("Ejemplo balanceado: {[()]}");
            Console.WriteLine("Ejemplo NO balanceado: {[()]}]");
            MenuPila.Pausa();
        }
        private static void VerHistorial()
        {
            Console.WriteLine("\nHistorial de expresiones verificadas:");
            if (historialExpresiones.Count == 0)
            {
                Console.WriteLine("No hay historial.");
            }
            else
            {
                foreach (var item in historialExpresiones)
                {
                    Console.WriteLine(item);
                }
            }
            MenuPila.Pausa();
        }
    }
}
