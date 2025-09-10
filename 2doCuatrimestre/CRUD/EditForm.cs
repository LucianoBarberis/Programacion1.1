using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class EditForm : Form
    {
        private string name;
        private string stock;
        private int price;

        public EditForm()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return name; }
            set { name = value;  tbName.Text = name; }
        }

        public string Stock
        {
            get { return stock; }
            set { stock = value; tbStock.Text = stock; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; tbPrice.Text = Convert.ToString(price); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
