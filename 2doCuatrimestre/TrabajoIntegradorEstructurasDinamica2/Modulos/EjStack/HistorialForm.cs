using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjStack
{
    public partial class HistorialForm : Form
    {
        Stack<string> historial = new Stack<string>();
        string? actual = null;
        public HistorialForm()
        {
            InitializeComponent();
        }

        private void updateActualState()
        {
            if (actual != null)
            {
                lblActual.Text = actual;
                listBox1.SelectedItem = actual;
            }
            else
            {
                lblActual.Text = "Sin reproducción";
                listBox1.SelectedItem = null;
            }
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpURL.Text)) 
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!inpURL.Text.Contains("https://"))
            {
                inpURL.Text = "https://" + inpURL.Text;
            }

            if (!inpURL.Text.Contains(".com"))
            {
                inpURL.Text = inpURL.Text + ".com";
            }

            historial.Push(inpURL.Text);
            listBox1.DataSource = null;
            listBox1.DataSource = historial.ToList();
            actual = historial.First();
            updateActualState();

            inpURL.Text = "";
        }
        private void btnBack_Click(object sender, EventArgs e)
        {

            if (historial.Count == 1)
            {
                MessageBox.Show("No hay elementos en el historial", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            historial.Pop();
            listBox1.DataSource = null;
            listBox1.DataSource = historial.ToList();
            actual = historial.First();
            updateActualState();
        }
    }
}
