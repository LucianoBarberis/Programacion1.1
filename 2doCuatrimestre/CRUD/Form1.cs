namespace CRUD
{
    public partial class Form1 : Form
    {
        int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbStock.Text) || string.IsNullOrEmpty(tbPrice.Text))
                {
                    MessageBox.Show("Asegurate de llenar todos los campos!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    listBox1.Items.Add($"{id} | {tbName.Text} | {tbStock.Text} | {tbPrice.Text}");
                    id++;
                }
            }
            catch
            {
                MessageBox.Show("Error al intentar convertir!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecciona un indice", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                EditForm editForm = new EditForm();


                editForm.ShowDialog();

                listBox1.Items.RemoveAt((int)listBox1.SelectedIndex);
                listBox1.Items.Add($"{tbName.Text} --- {editForm.Stock} --- {editForm.Price}");
            }
            else
            {
                MessageBox.Show("Selecciona un indice", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
