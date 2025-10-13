using System.Diagnostics;
using TrabajoIntegradorEstructurasDinamica2.Modulos.EjList;
using TrabajoIntegradorEstructurasDinamica2.Modulos.EjLinkedList;
using TrabajoIntegradorEstructurasDinamica2.Modulos.EjStack;
using TrabajoIntegradorEstructurasDinamica2.Modulos.EjQueue;
using TrabajoIntegradorEstructurasDinamica2.Modulos.EjDictionary;

namespace TrabajoIntegradorEstructurasDinamica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollado por Luciano Barberis", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gestiónDeInventarioDeTiendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InventarioForm inventario = new();
            inventario.ShowDialog();
        }
        private void listaDeTareasPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToDoListForm ToDoForm = new();
            ToDoForm.ShowDialog();
        }

        private void registroDeCalificacionesDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalificacionesForm calificacionesForm = new();
            calificacionesForm.ShowDialog();
        }
        private void gestiónDeListaDeEsperaEnRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaDeEsperaForm listaDeEsperaForm = new ListaDeEsperaForm();
            listaDeEsperaForm.ShowDialog();
        }
        private void historialDeUnEditorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditorDeTextoForm editorDeTextoForm = new EditorDeTextoForm();
            editorDeTextoForm.ShowDialog();
        }
        private void listaDeReproducciónDeMúsicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaylistMusicaForm playlistMusicaForm = new PlaylistMusicaForm();
            playlistMusicaForm.ShowDialog();
        }
        private void simuladorDePilaDePlatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PilaDePlatosForm pilaDePlatosForm = new PilaDePlatosForm();
            pilaDePlatosForm.ShowDialog();
        }
        private void verificadorDeParéntesisBalanceadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParentecisForm parentecisForm = new ParentecisForm();
            parentecisForm.ShowDialog();
        }
        private void historialDeNavegaciónWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialForm historialForm = new HistorialForm();
            historialForm.ShowDialog();
        }
        private void colaDeImpresiónDeDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColaDeImprecionForm colaDeImprecionForm = new ColaDeImprecionForm();
            colaDeImprecionForm.ShowDialog();
        }
        private void simuladorDeCallCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallCenterForm callCenterForm = new CallCenterForm();
            callCenterForm.ShowDialog();
        }
        private void procesosEnElSistemaOperativoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcesosSOForm procesosSOForm = new ProcesosSOForm();
            procesosSOForm.ShowDialog();
        }
        private void directorioTelefónicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirectorioForm directorioForm = new DirectorioForm();
            directorioForm.ShowDialog();
        }

        private void catálogoDeProductosPorCódigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoForm catalogoForm = new CatalogoForm();
            catalogoForm.ShowDialog();
        }

        private void traductorDeIdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraduccionForm traduccionForm = new TraduccionForm();
            traduccionForm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://lucianobarberis.com.ar/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
            }
        }
    }
}
