using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlmoOS
{
    public partial class RepMusica : Form
    {

        public RepMusica()
        {
            InitializeComponent();
        }

        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictBoxMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                //panBarradeTareas.Show();
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                //panBarradeTareas.Hide();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnElegirMusica_Click(object sender, EventArgs e)
        {
            // Para especificar la visualización del archivo en la ventana openFileDialog
            openFileDialog1.Filter = "|*.mp3; *.wav";

            // Para configurar el título de la ventana openFileDialog
            openFileDialog1.Title = "Por favor, ponga sus archivos de audio en suspensión.";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Le doy la ruta del archivo al reproductor de música y reproduce la canción.
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
            }
        }

        // Para cambiar el color del boton cuando sea presionado
        private void btnElegirMusica_MouseEnter(object sender, EventArgs e)
        {
            btnElegirMusica.BackColor = Color.FromArgb(255, 255, 128);
        }

        // Para cambiar el color del boton cuando sea presionado
        private void btnElegirMusica_MouseLeave(object sender, EventArgs e)
        {
            btnElegirMusica.BackColor = Color.FromArgb(255, 255, 192);
        }
    }
}
