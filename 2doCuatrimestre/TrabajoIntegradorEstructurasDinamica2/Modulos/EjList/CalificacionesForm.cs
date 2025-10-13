using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjList
{
    public partial class CalificacionesForm : Form
    {
        List<decimal> Calificaciones = new List<decimal>();

        public CalificacionesForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal Calificacion;
            if (string.IsNullOrEmpty(inpAdd.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Calificacion = Convert.ToDecimal(inpAdd.Text);
            }
            catch
            {
                MessageBox.Show("Ingresa un numero valido", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Calificacion > 10 || Calificacion < 0)
            {
                MessageBox.Show("Ingresa una calificacion valida (0 al 10)", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Calificaciones.Add(Calificacion);

            lbCalifi.DataSource = null;
            lbCalifi.DataSource = Calificaciones;

            inpAdd.Text = "";
        }

        private void btnDeleteHigh_Click(object sender, EventArgs e)
        {
            if (Calificaciones.Count == 0)
            {
                MessageBox.Show("No hay calificaciones a eliminar...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal CaliMayor;
            CaliMayor = Calificaciones.Max();

            Calificaciones.Remove(CaliMayor);

            lbCalifi.DataSource = null;
            lbCalifi.DataSource = Calificaciones;
        }

        private void btnDeleteMinor_Click(object sender, EventArgs e)
        {
            if (Calificaciones.Count == 0)
            {
                MessageBox.Show("No hay calificaciones a eliminar...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal CaliMenor;
            CaliMenor = Calificaciones.Min();

            Calificaciones.Remove(CaliMenor);

            lbCalifi.DataSource = null;
            lbCalifi.DataSource = Calificaciones;
        }
    }
}
