using System;
using System.Windows.Forms;

namespace AlmoOS
{
    public partial class TemaWin7 : Form
    {
        private bool menuVisible = false;
        private Google googleForm;
        private EstilosWindows estilosForm;

        public TemaWin7()
        {
            InitializeComponent();

            // Inicializar el temporizador
            timerHoraFecha.Interval = 1000; // Intervalo en milisegundos (1000 ms = 1 segundo)
            timerHoraFecha.Tick += TimerHoraFecha_Tick; // Asociar el evento Tick del temporizador con el método TimerHoraFecha_Tick
            timerHoraFecha.Start(); // Iniciar el temporizador
        }

        private void TimerHoraFecha_Tick(object sender, EventArgs e)
        {
            // Actualizar el contenido del Label con la hora actual
            labHoraFecha.Text = DateTime.Now.ToString("hh:mm tt"); // Formato HH:mm:ss para hora:minuto:segundo
        }

        private void picBoxApagar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBoxInicio_Click(object sender, EventArgs e)
        {
            // Alternar la visibilidad del menú
            if (menuVisible)
            {
                panMenu.Hide();
                menuVisible = false;
            }
            else
            {
                panMenu.Show();
                menuVisible = true;
            }
        }

        private void picBoxGoogleTareas_Click(object sender, EventArgs e)
        {
            abrirGoogle();
        }

        private void picBoxPersonalizacionTareas_Click(object sender, EventArgs e)
        {
            abrirPersonalizacion();
        }

        private void abrirPersonalizacion()
        {
            if (estilosForm == null || estilosForm.IsDisposed)
            {
                estilosForm = new EstilosWindows();
                estilosForm.MantenerDentroDelEscritorio(this);
            }
            else if (!estilosForm.Visible)
            {
                estilosForm.MantenerDentroDelEscritorio(this);
            }

            estilosForm.BringToFront();

            // Mostrar el formulario "Google"
            estilosForm.WindowState = FormWindowState.Maximized; // Establecer el formulario en estado maximizado
            estilosForm.StartPosition = FormStartPosition.CenterParent; // Ubicar el formulario en el centro del formulario "Escritorio"
            estilosForm.Show();

            panBarradeTareas.BringToFront();
            panMenu.BringToFront();
        }

        private void picBoxPersonalizacion_Click(object sender, EventArgs e)
        {
            abrirPersonalizacion();
        }

        private void labPersonalizacion_Click(object sender, EventArgs e)
        {
            abrirPersonalizacion();
        }

        private void picBoxGoogleMenu_Click(object sender, EventArgs e)
        {
            abrirGoogle();
        }

        private void labGoogle_Click(object sender, EventArgs e)
        {
            abrirGoogle();
        }

        private void abrirGoogle()
        {
            if (googleForm == null || googleForm.IsDisposed)
            {
                googleForm = new Google();
                googleForm.MantenerDentroDelEscritorio(this);
            }
            else if (!googleForm.Visible)
            {
                googleForm.MantenerDentroDelEscritorio(this);
            }

            googleForm.BringToFront();

            // Mostrar el formulario "Google"
            googleForm.WindowState = FormWindowState.Maximized; // Establecer el formulario en estado maximizado
            googleForm.StartPosition = FormStartPosition.CenterParent; // Ubicar el formulario en el centro del formulario "Escritorio"
            googleForm.Show();

            panBarradeTareas.BringToFront();
            panMenu.BringToFront();
        }

        private void picBoxFondo_Click(object sender, EventArgs e)
        {
            panMenu.Hide();
        }

        private void picBoxAdmTareas_Click(object sender, EventArgs e)
        {
            abrirAdministradorTareas();
        }

        private void picBoxRepMusicaTareas_Click(object sender, EventArgs e)
        {
            abrirReproductorMusica();
        }

        private void abrirReproductorMusica()
        {
            // Crear una instancia del formulario AdministradorTareas
            RepMusica formRepMusica = new RepMusica();

            // Mostrar el formulario
            formRepMusica.Show();
        }

        private void picBoxAdmTareasMenu_Click(object sender, EventArgs e)
        {
            abrirAdministradorTareas();
        }

        private void picBoxRepMusica_Click(object sender, EventArgs e)
        {
            abrirReproductorMusica();
        }

        private void labAdmTareasMenu_Click(object sender, EventArgs e)
        {
            abrirAdministradorTareas();
        }
        private void abrirAdministradorTareas()
        {
            // Crear una instancia del formulario AdministradorTareas
            AdministradorTareas formAdministradorTareas = new AdministradorTareas();

            // Mostrar el formulario
            formAdministradorTareas.Show();
        }

        private void labRepMusica_Click(object sender, EventArgs e)
        {
            abrirReproductorMusica();
        }

        private void panBarradeTareas_Paint(object sender, EventArgs e)
        {
            panMenu.Hide();
        }
    }
}
