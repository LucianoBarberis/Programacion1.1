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
    public partial class TraduccionForm : Form
    {
        Dictionary<string, string> traducciones = new Dictionary<string, string>();
        public TraduccionForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpIngles.Text) || string.IsNullOrEmpty(inpEspañol.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            traducciones.Add(inpEspañol.Text, inpIngles.Text);

            lbTraducciones.DataSource = null;
            lbTraducciones.DataSource = traducciones.ToList();
            inpIngles.Text = "";
            inpEspañol.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(InpSearch.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (traducciones.ContainsKey(InpSearch.Text))
            {
                MessageBox.Show($"Traduccion de {InpSearch.Text}: {traducciones[InpSearch.Text]}", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se encontro la traduccion...", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            InpSearch.Text = "";
        }
    }
}
