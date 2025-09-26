using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Cola
    {
        private int valor = 0;
        private Nodo? head = null;
        private Nodo? tail = null;

        public void Encolar()
        {
            Nodo NewNodo = new Nodo(valor);
            if (tail == null)
            {
                head = NewNodo;
            } else
            {
                tail.Siguiente = NewNodo;
            }
            tail = NewNodo;
            valor++;
        }

        public void DesEncolar()
        {
            if (head == null)
            {
                return;
            }
            head = head.Siguiente;
            if (head == null) 
            {
                tail = null;
            }
        }
        public void MostrarCola()
        {
            Nodo Actual = head;

            while (Actual != null) 
            {
                Console.WriteLine(Actual.Valor);
                Actual = Actual.Siguiente;
            }
        }
    }
}
