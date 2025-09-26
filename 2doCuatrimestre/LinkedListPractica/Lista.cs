using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPractica
{
    internal class Lista
    {
        private Nodo? cabeza = null;

        public void AddNodo(int valor)
        {
            Nodo? newNodo = new Nodo(valor);
            if (cabeza == null) 
            {
                cabeza = newNodo;
            }else
            {
                Nodo? PocisionActual = cabeza;
                while (PocisionActual.next != null)
                {
                    PocisionActual = PocisionActual.next; 
                }
                PocisionActual.next = newNodo;
            }
        }

        public void PrintNodo()
        {
            Nodo? PocisionActual = cabeza;

            while (PocisionActual != null)
            {
                Console.WriteLine(PocisionActual.valor);
                PocisionActual = PocisionActual.next;
            } 
        }

        public bool BuscarNodo(int valor)
        {
            Nodo? PocisionActual = cabeza;
            while (PocisionActual != null) 
            {
                if(PocisionActual.valor == valor)
                    return true;
                PocisionActual = PocisionActual.next;
            }
            return false;
        }

        public void insertarDespuesDe(int valorExistente, int valorNuevo)
        {
            Nodo? Actual = cabeza;
            while(Actual != null && Actual.valor != valorExistente)
            {
                Actual = Actual.next;
            }

            if(Actual != null)
            {
                Nodo? newNodo = new Nodo(valorNuevo);
                newNodo.next = Actual.next;
                Actual.next = newNodo;
            }
        }

        public void deleteNodo(int valor2Delete)
        {
            if (cabeza == null) return;

            if(cabeza.valor == valor2Delete)
            {
                cabeza = cabeza.next;
            }

            Nodo? Actual = cabeza;
            while (Actual.next != null && Actual.next.valor != valor2Delete)
            {
                Actual = Actual.next;
            }

            if(Actual.next != null)
            {
                Actual.next = Actual.next.next;
            }
        }
    }
}
