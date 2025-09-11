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
    public partial class Llegada : Form
    {
        private string msg = string.Empty;

        public Llegada()
        {
            InitializeComponent();
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; textBox1.Text = msg; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Rellene todos los campos");
            }
            else
            {
                msg = textBox1.Text;
                this.Close();
            }
        }
    }
}
