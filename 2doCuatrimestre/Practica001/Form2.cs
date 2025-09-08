using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica001
{
    public partial class Form2 : Form
    {
        private string tarea;
        public Form2(string taskToEdit)
        {
            InitializeComponent();
            textBox1.Text = taskToEdit;
        }

        public string Tarea
        {
            get { return tarea; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("El campo no puede estar vacío");
                return;
            }
            else
            {
                tarea = textBox1.Text;
                this.Close();
            }
        }


    }
}
