namespace WinForms1
{
    public partial class Ej01 : Form
    {
        public Ej01()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.inpAltura.Text.Length == 0 || this.inpPeso.Text.Length == 0)
                {
                    this.inpAltura.BackColor = Color.Yellow;
                    this.inpPeso.BackColor = Color.Yellow;
                    this.lblResult.Text = $"Error... Inputs vacios";
                }
                else
                {
                    float altura = float.Parse(this.inpAltura.Text);
                    int peso = int.Parse(this.inpPeso.Text);

                    if (altura <= 0 || peso <= 0)
                    {
                        this.inpAltura.BackColor = Color.Yellow;
                        this.inpPeso.BackColor = Color.Yellow;
                        this.lblResult.Text = $"Error... Valores < 0 ";
                    }
                    else
                    {
                        double imc = peso / (altura * altura);
                        this.inpAltura.BackColor = Color.White;
                        this.inpPeso.BackColor = Color.White;
                        this.lblResult.Text = $"Resultado: {imc:F2}";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No se pueden ingresar caracteres");
            }
        }
    }
}
