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
    public partial class ProcesosSOForm : Form
    {
        Queue<string> procesos = new Queue<string>();
        int proceso = 0;
        public ProcesosSOForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            procesos.Enqueue("Proceso Numero: " + proceso.ToString());
            lbProcesos.DataSource = null;
            lbProcesos.DataSource = procesos.ToList();
            proceso++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(procesos.Count == 0)
            {
                MessageBox.Show("No hay procesos a ejecutar", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            procesos.Dequeue();
            lbProcesos.DataSource = null;
            lbProcesos.DataSource = procesos.ToList();
        }
    }
}
