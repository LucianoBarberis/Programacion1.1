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
    public partial class EditorDeTextoForm : Form
    {
        LinkedList<string> Texto = new LinkedList<string>();
        LinkedListNode<string> posicionActual = null;

        public EditorDeTextoForm()
        {
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Texto.AddLast("Hola ");
            lblTexto.Text = null;
            while(posicionActual != null)
            {

            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {

        }
    }
}
