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
    public partial class PilaDePlatosForm : Form
    {
        Stack<string> platos = new Stack<string>();
        int nroDePlatos = 0;
        public PilaDePlatosForm()
        {
            InitializeComponent();
        }

        private void updateStack(Stack<string> platosProp, ListBox lbox)
        {
            lbox.DataSource = null;
            lbox.DataSource = platosProp.ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            platos.Push($"Plato nro: {nroDePlatos}");
            nroDePlatos++;
            updateStack(platos, lbPlatos);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (platos.Count == 0) 
            {
                return;
            }

            platos.Pop();
            nroDePlatos--;
            updateStack(platos, lbPlatos);
        }
    }
}
