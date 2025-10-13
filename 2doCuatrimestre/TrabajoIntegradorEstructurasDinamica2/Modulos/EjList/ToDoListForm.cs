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
    public partial class ToDoListForm : Form
    {
        List<string> Tareas = new List<string>();
        public ToDoListForm()
        {
            InitializeComponent();
        }

        public static void UpdateStringList(List<string> lista, ListBox lbox)
        {
            lbox.DataSource = null;
            lbox.DataSource = lista;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpAdd.Text)) 
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tareas.Add(inpAdd.Text);

            UpdateStringList(Tareas, lbTasks);

            inpAdd.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Ningun elemento seleccionado...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Tareas.RemoveAt(lbTasks.SelectedIndex);
            UpdateStringList(Tareas, lbTasks);
        }
    }
}
