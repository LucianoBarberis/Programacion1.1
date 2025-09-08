namespace TP0201
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = name.Text;
            int precioBase = 0;
            string destino = "";

            try
            {
                precioBase = Convert.ToInt32(price.Text);
            }
            catch
            {
                MessageBox.Show("Erorr al convertir!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (precioBase <= 0 || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Error! Rellena todos los campos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if (rbtnCity.Checked)
                {
                    destino = rbtnCity.Text;
                }
                if (rbtnMontaña.Checked)
                {
                    destino = rbtnCity.Text;
                }
                if (rbtnPlaya.Checked)
                {
                    destino = rbtnPlaya.Text;
                }

                if (cbGuia.Checked)
                {
                    precioBase += 1000;
                }
                if (cbTraslados.Checked)
                {
                    precioBase += 1200;
                }
                if (cbComidas.Checked)
                {
                    precioBase += 1500;
                }

                textBox1.Text += $"Pasajero: {nombre}; Destino: {destino}; Precio: {precioBase} \r\n";
            }

        }
    }
}
