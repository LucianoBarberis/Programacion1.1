using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Pila
    {
        private Nodo? Cabeza = null;

        public void Apilar(int value)
        {
            Nodo NewNodo = new Nodo(value);
            if (Cabeza == null)
            {
                Cabeza = NewNodo;
            }else
            {
                NewNodo.Siguiente = Cabeza;
                Cabeza = NewNodo;
            }
        }
        public void DesApilar()
        {
            if (Cabeza == null) return;
            Cabeza = Cabeza.Siguiente;
        }

        public void MostrarPila()
        {
            Nodo? Actual = Cabeza;
            while (Actual != null)
            {
                Console.WriteLine(Actual.Valor);
                Actual = Actual.Siguiente;
            }
        }
    }
}
