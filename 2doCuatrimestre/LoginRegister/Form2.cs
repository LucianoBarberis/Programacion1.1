using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Form2 : Form
    {
        private string nombre;
        private string contra;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
            contra = textBox2.Text;
        }
        public string Name
        {
            get { return contra; }
        }
        public string Pass
        {
            get { return nombre; }
        }
    }
}
