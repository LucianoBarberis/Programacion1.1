using System;
using System.Collections.Generic;

namespace TrabajoIntegradorEstructurasDinamica.Stack
{
    internal class PilaParentesis
    {
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
                Console.WriteLine("║ 0. Salir                          ║");
                Console.WriteLine("╚═══════════════════════════════════╝");
                Console.WriteLine("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        VerificarExpresion();
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
    }
}
