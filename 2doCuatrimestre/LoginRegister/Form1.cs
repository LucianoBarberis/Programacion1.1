using System.Diagnostics.Eventing.Reader;

namespace LoginRegister
{
    public partial class Form1 : Form
    {
        private string[,] users = new string[40,2];

        public Form1()
        {
            InitializeComponent();
            users[0,0] = "Luciano";
            users[0,1] = "1234";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 register = new Form2();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool userExist = false;
            if (name.Text == "" || pass.Text == "")
            {
                MessageBox.Show("Rellena todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                for (int i = 0; i < 40; i++)
                {
                    if (users[i, 0] == name.Text)
                    {
                        userExist = true; break;
                    }
                    else 
                    {
                        MessageBox.Show("Usuario no registrado!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);break;
                    }
                }
            }
            if(userExist == true)
            {
                for (int i = 0; i < 40; i++)
                {
                    if (users[i, 1] == pass.Text) 
                    {
                        MessageBox.Show("Entrando al Sistema", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                    }
                }
            }
        }
        private void newUser()
        {
            Form2 register = new Form2();

            register.ShowDialog();
            
        }
    }
}
