using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas
{
    internal class Nodo(int value)
    {
        public int Valor = value;
        public Nodo? Siguiente = null;
    }
}
