using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjQueue
{
    public partial class ColaDeImprecionForm : Form
    {
        Queue<string> ColaDeImprecion = new Queue<string>();
        int documentos = 1;
        public ColaDeImprecionForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ColaDeImprecion.Enqueue($"Documento nro. {documentos}");
            listBox1.DataSource = null;
            listBox1.DataSource = ColaDeImprecion.ToList();
            documentos++;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool imprimiendo = false;

            if(imprimiendo)
            {
                MessageBox.Show("Ya se esta imprimiendo un documento...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(ColaDeImprecion.Count == 0)
            {
                MessageBox.Show("No hay mas documentos para imprimir...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            imprimiendo = true;
            ColaDeImprecion.Dequeue();
            listBox1.DataSource = null;
            listBox1.DataSource = ColaDeImprecion.ToList();
            btnPrint.Enabled = !imprimiendo;
            for (var i = 0; i < 10; i++)
            {
                progressBar1.PerformStep();
                Thread.Sleep(200);
            }

            imprimiendo = false;
            progressBar1.Value = 0;
            btnPrint.Enabled = !imprimiendo;
        }
    }
}
