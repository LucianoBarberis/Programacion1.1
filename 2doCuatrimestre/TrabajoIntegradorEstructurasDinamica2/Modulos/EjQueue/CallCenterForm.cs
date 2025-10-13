using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjQueue
{
    public partial class CallCenterForm : Form
    {
        System.Timers.Timer temporizador = new System.Timers.Timer();
        Queue<string> llamadas = new Queue<string>();
        Random random = new Random();

        public CallCenterForm()
        {
            InitializeComponent();

            temporizador.Interval = 2000;
            temporizador.Elapsed += (sender, eventArgs) =>
            {
                string TelNro = $"+54 9 {random.Next(1111, 9999)} {random.Next(10, 99)} {random.Next(1111, 9999)}";
                llamadas.Enqueue(TelNro);
                lbCalls.DataSource = null;
                lbCalls.DataSource = llamadas.ToList();
            };
            temporizador.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (llamadas.Count == 0) 
            {
                MessageBox.Show("No hay llamadas entrantes...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            llamadas.Dequeue();
            lbCalls.DataSource = null;
            lbCalls.DataSource = llamadas.ToList();
        }
    }
}
