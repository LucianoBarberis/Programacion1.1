using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrabajoIntegradorEstructurasDinamica2.Modulos.EjLinkedList
{
    public partial class PlaylistMusicaForm : Form
    {
        LinkedList<string> musicList = new LinkedList<string>();
        LinkedListNode<string> cancionActual = null;
        public PlaylistMusicaForm()
        {
            InitializeComponent();
        }

        private void updateActualState()
        {
            if (cancionActual != null)
            {
                lblActual.Text = cancionActual.Value;
                lbPlaylist.SelectedItem = cancionActual.Value;
            }
            else
            {
                lblActual.Text = "Sin reproducción";
                lbPlaylist.SelectedItem = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(inpSong.Text))
            {
                MessageBox.Show("Rellena todos los campos...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            musicList.AddLast(inpSong.Text);
            lbPlaylist.DataSource = null;
            lbPlaylist.DataSource = musicList.ToList();

            if (cancionActual == null)
            {
                cancionActual = musicList.Last;
                updateActualState();
            }

            inpSong.Text = "";
        }

        private void nextSong_Click(object sender, EventArgs e)
        {
            if(musicList.Count == 0)
            {
                MessageBox.Show("No hay canciones...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cancionActual == null)
            {
                return;
            }

            if (cancionActual.Next != null)
            {
                cancionActual = cancionActual.Next;
                updateActualState();
            }else
            {
                cancionActual = musicList.First;
                updateActualState();
            }
        }

        private void prevSong_Click(object sender, EventArgs e)
        {
            if (musicList.Count == 0)
            {
                MessageBox.Show("No hay canciones...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cancionActual.Previous != null)
            {
                cancionActual = cancionActual.Previous;
                updateActualState();
            }
            else
            {
                cancionActual = musicList.Last;
                updateActualState();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbPlaylist.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una cancion...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string cancionAEliminar = lbPlaylist.SelectedItem.ToString();
            var nodoAEliminar = musicList.Find(cancionAEliminar);

            if (cancionActual == nodoAEliminar)
            {
                if (nodoAEliminar?.Next != null)
                    cancionActual = nodoAEliminar.Next;
                else if (nodoAEliminar?.Previous != null)
                    cancionActual = nodoAEliminar.Previous;
                else
                    cancionActual = null;
            }

            if (nodoAEliminar != null)
                musicList.Remove(nodoAEliminar);

            lbPlaylist.DataSource = null;
            lbPlaylist.DataSource = musicList.ToList();

            updateActualState();
        }
    }
}
