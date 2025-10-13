using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjStack
{
    public partial class ParentecisForm : Form
    {
        public ParentecisForm()
        {
            InitializeComponent();
        }

        private static bool EsBalanceado(string expresion)
        {
            Stack<char> pila = new Stack<char>();
            Dictionary<char, char> pares = new Dictionary<char, char>
            {
                { ')', '(' },
                { ']', '[' },
                { '}', '{' }
            };
            foreach (char c in expresion)
            {
                if (pares.Values.Contains(c))
                {
                    pila.Push(c);
                }
                else if (pares.ContainsKey(c))
                {
                    if (pila.Count == 0 || pila.Pop() != pares[c])
                        return false;
                }
            }
            return pila.Count == 0;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {   
            if (string.IsNullOrEmpty(inpExprecion.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (EsBalanceado(inpExprecion.Text))
            {
                MessageBox.Show("Expresion Balanceada!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Expresion Desbalanceda :/", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
