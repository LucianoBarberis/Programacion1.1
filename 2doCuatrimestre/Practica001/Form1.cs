namespace Practica001
{
    public partial class Form1 : Form
    {

        public string[] tasks = new string[50];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una tarea para borrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una tarea para editar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Creamos la instancia del form2 y le pasamos el valor de la tarea a editar
                Form2 editTask = new Form2();
                editTask.Tarea = listBox1.SelectedItem?.ToString() ?? string.Empty;
                editTask.ShowDialog();

                tasks[listBox1.SelectedIndex] = editTask.Tarea;
                listBox1.Items[listBox1.SelectedIndex] = editTask.Tarea;
            }
        }
    }
}
