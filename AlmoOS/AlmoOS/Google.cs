using System;
using System.Windows.Forms;

namespace AlmoOS
{
    public partial class Google : AlmoOS.Herencia
    {
        // Variable para rastrear el estado de visibilidad del menú

        public Google()
        {
            InitializeComponent();
            // Establecer la posición del formulario
            this.StartPosition = FormStartPosition.Manual;

            // Suscribir al evento Activated
            this.Activated += Google_Activated;

            // Suscribir el método al evento Click del PictureBox de minimizar
            picBoxMinimizar.Click += picBoxMinimizar_Click;
        }

        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picBoxAtras_Click(object sender, EventArgs e)
        {
            webBroPaginaPricipal.GoBack();
        }

        private void pictBoxMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                panBarradeTareas.Show();
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                panBarradeTareas.Hide();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picBoxMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Método para asegurar que el formulario "Google" se mantenga dentro del formulario "Escritorio"
        public void MantenerDentroDelEscritorio(Form escritorioForm)
        {
            // Establecer el formulario "Google" como un formulario secundario del formulario "Escritorio"
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;

            // Establecer el contenedor del formulario "Google" como el formulario "Escritorio"
            escritorioForm.Controls.Add(this);
            this.Dock = DockStyle.Fill;

            // Asegurar que el formulario "Google" no sea más grande que el formulario "Escritorio"
            this.MaximumSize = escritorioForm.ClientSize;
        }

        // Manejador de eventos Activated
        private void Google_Activated(object sender, EventArgs e)
        {
            // Mantener el formulario "Google" dentro del formulario "Escritorio"
            MantenerDentroDelEscritorio(this.ParentForm);
        }
    }
}
