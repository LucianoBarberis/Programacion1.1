using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComEntreFormas
{
    public partial class Form3 : Form
    {
        private string texto;
        public Form3()
        {
            InitializeComponent();
        }
        public string Texto
        {
            get 
            { 
                return texto;
            }
            set
            {
                texto = value;
                textBox1.Text = texto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            texto = textBox1.Text;
            this.Close();
        }
    }
}
