using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vendedor> empleados = new List<Vendedor>();
            Vendedor pj01 = new Vendedor(1, "JuanPePe");
            Vendedor pj02 = new Vendedor(2, "Jose");

            empleados.Add(pj01);
            empleados.Add(pj02);

            pj01.NewSell(1250000);
            pj01.NewSell(2300000);
            pj02.NewSell(4200000);
            pj01.NewSell(1150000);

            foreach(Vendedor pj in empleados)
            {
                pj.DatosVentas();
            }
        }
    }

    interface IUsuarios
    {
        int Id {  get; }
        string Name {  get; }
    }

    class Vendedor : IUsuarios
    {
        public int Id { get; }
        public string Name { get; set; }
        private int Ventas;
        private double Ingresos;

        public Vendedor(int id, string name)
        {
            Id = id;
            Name = name;
            Ventas = 0;
            Ingresos = 0;
        }

        public void NewSell(double ValorVentaProp)
        {
            Ventas++;
            Ingresos += ValorVentaProp;
        }

        public void DatosVentas()
        {
            Console.WriteLine($"---Datos de {Name}---");
            Console.WriteLine($"Total de ventas: {Ventas}; Total de ingresos: {Ingresos}");
        }
    }
}
