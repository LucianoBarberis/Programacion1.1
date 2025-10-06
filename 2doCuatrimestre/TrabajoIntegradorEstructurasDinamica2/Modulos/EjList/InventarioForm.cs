using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjList
{

    public partial class InventarioForm : Form
    {
        List<Producto> productos = new List<Producto>();

        public InventarioForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Nombre;
            int Cantidad;

            if (string.IsNullOrEmpty(inpAdd.Text))
            {
                MessageBox.Show("El item debe tener un nombre...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(inpCantidad.Text))
            {
                MessageBox.Show("El item debe tener una cantidad...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Cantidad = int.Parse(inpCantidad.Text);
            }catch
            {
                MessageBox.Show("El item debe tener una cantidad...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nombre = inpAdd.Text;

            Producto newProduct = new(Nombre, Cantidad);
            productos.Add(newProduct);

            lbItems.DataSource = null;
            lbItems.DataSource = productos;

            inpAdd.Text = null;
            inpCantidad.Text = null;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex == -1)
            {
                MessageBox.Show("Ningun elemento seleccionado...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            productos.RemoveAt(lbItems.SelectedIndex);
            lbItems.DataSource = null;
            lbItems.DataSource = productos;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string? productToSearch;
            Producto? productsSearchResult;

            productToSearch = inpSearch.Text;

            productsSearchResult = productos.Find(x => x.Name == productToSearch);

            if (productsSearchResult != null)
            {
                MessageBox.Show($"{productsSearchResult.Name} - {productsSearchResult.Quantity}", "Producto encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("No se encontraron productos", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }


    class Producto(string name, int quantity)
    {
        public string Name { get; set; } = name;
        public int Quantity { get; set; } = quantity;

        public override string ToString() 
        {
            return $"{Name} - {Quantity}";
        }
    }
}
