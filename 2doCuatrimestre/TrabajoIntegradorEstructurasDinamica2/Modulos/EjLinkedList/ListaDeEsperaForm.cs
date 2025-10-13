using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjLinkedList
{
    public partial class ListaDeEsperaForm : Form
    {
        LinkedList<string> ListaDeEspera = new LinkedList<string>();
        public ListaDeEsperaForm()
        {
            InitializeComponent();
        }

        private void UpdateLinkedList(ListBox lbox, LinkedList<string> linkdList)
        {
            lbox.DataSource = null;
            lbox.DataSource = linkdList.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(inpClientName.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListaDeEspera.AddLast(inpClientName.Text);
            UpdateLinkedList(lbListaDeEspera, ListaDeEspera);
            inpClientName.Text = "";
        }

        private void btnSitClient_Click(object sender, EventArgs e)
        {
            if(lbListaDeEspera.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cliente...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ListaDeEspera.RemoveFirst();
            UpdateLinkedList(lbListaDeEspera, ListaDeEspera);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ListaDeEspera.Count == 0)
            {
                MessageBox.Show("No hay clientes...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lbListaDeEspera.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un cliente...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            int objetivoIndex = lbListaDeEspera.SelectedIndex;
            string? objetivoValue = lbListaDeEspera.Items[objetivoIndex].ToString();

            ListaDeEspera.Remove(objetivoValue);
            UpdateLinkedList(lbListaDeEspera, ListaDeEspera);
        }
    }
}
