using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    internal class Nodo(int ValueProp)
    {
        public int Valor = ValueProp;
        public Nodo? Siguiente = null;
    }
}
