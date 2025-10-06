using System.Diagnostics;

namespace TrabajoIntegradorEstructurasDinamica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Luciano Barberis", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestiónDeInventarioDeTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.EjList.InventarioForm inventario = new();

            inventario.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://lucianobarberis.com.ar/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
            }
        }
    }
}
