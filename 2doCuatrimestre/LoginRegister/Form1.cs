using System.Diagnostics.Eventing.Reader;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        private string[,] users = new string[40,2];
        private int currentUser = 1; // Empieza en 1 si ya hay un usuario inicial

        public Form1()
        {
            InitializeComponent();
            users[0,0] = "Luciano";
            users[0,1] = "1234";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 register = new Form2();
            if (register.ShowDialog() == DialogResult.OK)
            {
                string nuevoNombre = register.Name;
                string nuevaContra = register.Pass;
                if (currentUser < 40)
                {
                    users[currentUser, 0] = nuevoNombre;
                    users[currentUser, 1] = nuevaContra;
                    currentUser++;
                    MessageBox.Show("Usuario registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Límite de usuarios alcanzado.");
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }

            bool userFound = false;
            for (int i = 0; i < currentUser; i++)
            {
                if (users[i, 0] == name.Text && users[i, 1] == pass.Text)
                {
                    userFound = true;
                    break;
                }
            }

            if (userFound)
            {
                MessageBox.Show("Entrando al Sistema", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
