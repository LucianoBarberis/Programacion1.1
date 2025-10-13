using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjDictionary
{
    public partial class CatalogoForm : Form
    {
        Dictionary<string, string> Catalogo = new Dictionary<string, string>();
        public CatalogoForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name;
            string sku;

            if (string.IsNullOrEmpty(inpName.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(inpSku.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(inpSku.Text, out int n))
            {
                MessageBox.Show("Ingresa un SKU valido...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Catalogo.ContainsKey(inpSku.Text))
            {
                MessageBox.Show($"El producto {inpSku.Text} ya existe...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            name = inpName.Text;
            sku = inpSku.Text;

            Catalogo.Add(sku, name);
            lbCatalogo.DataSource = null;
            lbCatalogo.DataSource = Catalogo.ToList();
            inpName.Text = "";
            inpSku.Text = "";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SkuObjetivo;

            if(string.IsNullOrEmpty(inpSearch.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(inpSearch.Text, out int n))
            {
                MessageBox.Show("Ingresa un SKU valido...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SkuObjetivo = inpSearch.Text;

            if (Catalogo.ContainsKey(SkuObjetivo))
            {
                MessageBox.Show($"Produto encontrado: {Catalogo[SkuObjetivo]}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("No se encontraron productos...", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
