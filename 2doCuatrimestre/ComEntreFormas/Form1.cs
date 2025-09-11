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
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Rellene todos los campos");
            }else
            {
                Llegada form2 = new Llegada();
                form2.Msg = textBox1.Text;
                form2.ShowDialog();
                textBox1.Text = form2.Msg;
            }
        }
    }
}
