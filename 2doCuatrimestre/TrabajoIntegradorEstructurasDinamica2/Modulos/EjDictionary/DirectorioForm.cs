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
    public partial class DirectorioForm : Form
    {
        Dictionary<string, string> telefonos = new Dictionary<string, string>();

        public DirectorioForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpName.Text) || string.IsNullOrEmpty(inpTel.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            telefonos.Add(inpName.Text, inpTel.Text);

            lbContactos.DataSource = null;
            lbContactos.DataSource = telefonos.ToList();
            inpName.Text = "";
            inpTel.Text = "";
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InpSearch.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (telefonos.ContainsKey(InpSearch.Text))
            {
                MessageBox.Show($"Traduccion de {InpSearch.Text}: {telefonos[InpSearch.Text]}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontro la traduccion...", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InpSearch.Text = "";
        }
    }
}
