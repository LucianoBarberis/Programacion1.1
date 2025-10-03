using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoIntegradorEstructurasDinamica.Listas
{
    internal class Producto
    {
        public string? name;
        public int quantity;

        public override string ToString()
        {
            return $"{name} | Cantidad: {quantity}";
        }
    }
}
