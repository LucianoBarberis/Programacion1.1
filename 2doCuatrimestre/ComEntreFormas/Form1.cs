namespace ComEntreFormas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(selectMetodo.SelectedIndex == -1)
            {
                return;
            }
            else if(selectMetodo.SelectedIndex == 0)
            {
                Form2 form = new Form2(textBox1.Text);
                form.ShowDialog();
            } 
            else if(selectMetodo.SelectedIndex == 1)
            {
                Form3 form2 = new Form3();
                form2.Texto = textBox1.Text;
                form2.ShowDialog();
                textBox1.Text = form2.Texto;
            }

        }
    }
}
