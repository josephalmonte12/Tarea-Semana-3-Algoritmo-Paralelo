using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlmoOS
{
    public partial class EstilosWindows : AlmoOS.Herencia
    {
        private TemaUTESA temaUtesa;
        private TemaWin7 temaWin7;
        private TemaWinXP temaWinXP;
        private Escritorio escritorioForm;

       

        public EstilosWindows()
        {
            InitializeComponent();
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            TemaWinXP.Hide();
            TemaUTESA.Hide();
            TemaWin7.Hide();
            TemaOriginal.Hide();
            // Generar un color aleatorio
            Random rnd = new Random();
            Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            panMenu.BackColor = colorAleatorio;

        }

        private void btnTemas_Click(object sender, EventArgs e)
        {
            TemaWinXP.Show();
            TemaUTESA.Show();
            TemaWin7.Show();
            TemaOriginal.Show();
        }

        private void btnBarTareas_Click(object sender, EventArgs e)
        {
            TemaWinXP.Hide();
            TemaUTESA.Hide();
            TemaWin7.Hide();
            TemaOriginal.Hide();

            // Generar un color aleatorio
            Random rnd = new Random();
            Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            // Cambiar el color del panel
            panBarradeTareas.BackColor = colorAleatorio;
            labHoraFecha.BackColor = colorAleatorio;
        }

        private void btnColores_Click(object sender, EventArgs e)
        {
            cambiarColores();

            //TemaWinXP.Hide();
            //TemaUTESA.Hide();
            //TemaWin7.Hide();
            //TemaOriginal.Hide();

        }

        private void cambiarColores()
        {
           // Console.WriteLine("Valor utesa es ==> " + temaUTESASeleccionado);

            //if (temaUTESASeleccionado)
            //{
            //    // Generar un color aleatorio
                Random rnd = new Random();
                Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Console.WriteLine("Entre a utesa");
            // Cambiar el color del panel
            if (temaUtesa != null)
            {
                temaUtesa.panBarradeTareas.BackColor = colorAleatorio;
                temaUtesa.labHoraFecha.BackColor = colorAleatorio;
                temaUtesa.panMenu.BackColor = colorAleatorio;
            }    

                
            //}

            else if (temaWin7 !=null)
            {
            //    // Generar un color aleatorio
            //    Random rnd = new Random();
            //    Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                // Cambiar el color del panel
                temaWin7.panBarradeTareas.BackColor = colorAleatorio;
                temaWin7.labHoraFecha.BackColor = colorAleatorio;
                temaWin7.panMenu.BackColor = colorAleatorio;
            }

            else if (temaWinXP !=null)
            {
            //    // Generar un color aleatorio
            //    Random rnd = new Random();
            //    Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                // Cambiar el color del panel
                temaWinXP.panBarradeTareas.BackColor = colorAleatorio;
                temaWinXP.labHoraFecha.BackColor = colorAleatorio;
                temaWinXP.panMenu.BackColor = colorAleatorio;
            }

            else
            {
                //    // Generar un color aleatorio
                //    Random rnd = new Random();
                //    Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                // Cambiar el color del panel
                Console.WriteLine("Ninguno george");
                panBarradeTareas.BackColor = colorAleatorio;
                labHoraFecha.BackColor = colorAleatorio;
                panMenu.BackColor = colorAleatorio;
            }
            //if (temaWinXPSeleccionado)
            //{

            //}
            //if else (temaWin7Seleccionado){

            //}if else (temaUTESASeleccionado){

            //}
            //else {
            //    // Generar un color aleatorio
            //    Random rnd = new Random();
            //    Color colorAleatorio = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            //    // Cambiar el color del panel
            //    panBarradeTareas.BackColor = colorAleatorio;
            //    labHoraFecha.BackColor = colorAleatorio;
            //    panMenu.BackColor = colorAleatorio;
            //}

        }

        private void picBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void picBoxFondo_Click(object sender, EventArgs e)
        {

        }

        private void TemaWinXP_Click(object sender, EventArgs e)
        {
            temaWin7Seleccionado = false;
            temaUTESASeleccionado = false;
            temaWinXPSeleccionado = true;

            EstablecerTemaWinXP();
        }

        private void picBoxInicio_Click(object sender, EventArgs e)
        {
            panMenu.BringToFront();
        }

        private void TemaUTESA_Click(object sender, EventArgs e)
        {            
            temaWin7Seleccionado = false;
            temaUTESASeleccionado = true;
            temaWinXPSeleccionado = false;

            EstablecerTemaUTESA();
        }

        private void TemaOriginal_Click(object sender, EventArgs e)
        {            
            temaWin7Seleccionado = false;
            temaUTESASeleccionado = false;
            temaWinXPSeleccionado = false;

            EstablecerTemaOriginal();
        }

        private void TemaWin7_Click(object sender, EventArgs e)
        {            
            temaWin7Seleccionado = true;
            temaUTESASeleccionado = false;
            temaWinXPSeleccionado = false;

            EstablecerTemaWin7();
        }
        private void EstablecerTemaUTESA()
        {
            if (temaUtesa == null /*|| temaUtesa.IsDisposed*/)
            {
                temaUtesa = new TemaUTESA();
            }

            temaUtesa.BringToFront();

            // Mostrar el formulario "Google"
            temaUtesa.WindowState = FormWindowState.Maximized; // Establecer el formulario en estado maximizado
            temaUtesa.StartPosition = FormStartPosition.CenterParent; // Ubicar el formulario en el centro del formulario "Escritorio"
            temaUtesa.Show();
        }
        
        private void EstablecerTemaWin7()
        {
            if (temaWin7 == null || temaWin7.IsDisposed)
            {
                temaWin7 = new TemaWin7();
            }

            temaWin7.BringToFront();

            // Mostrar el formulario "Google"
            temaWin7.WindowState = FormWindowState.Maximized; // Establecer el formulario en estado maximizado
            temaWin7.StartPosition = FormStartPosition.CenterParent; // Ubicar el formulario en el centro del formulario "Escritorio"
            temaWin7.Show();
        }

        private void EstablecerTemaOriginal()
        {
            if (escritorioForm == null || escritorioForm.IsDisposed)
            {
                escritorioForm = new Escritorio();
            }

            escritorioForm.BringToFront();

            // Mostrar el formulario "Google"
            escritorioForm.WindowState = FormWindowState.Maximized; // Establecer el formulario en estado maximizado
            escritorioForm.StartPosition = FormStartPosition.CenterParent; // Ubicar el formulario en el centro del formulario "Escritorio"
            escritorioForm.Show();
        }

        private void EstablecerTemaWinXP()
        {
            if (temaWinXP == null || temaWinXP.IsDisposed)
            {
                temaWinXP = new TemaWinXP();
            }

            temaWinXP.BringToFront();

            // Mostrar el formulario "Google"
            temaWinXP.WindowState = FormWindowState.Maximized; // Establecer el formulario en estado maximizado
            temaWinXP.StartPosition = FormStartPosition.CenterParent; // Ubicar el formulario en el centro del formulario "Escritorio"
            temaWinXP.Show();
        }

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

        private void panEstilos_Paint(object sender, PaintEventArgs e)
        {
            panMenu.Hide();
        }

        private void panBarradeTareas_Paint(object sender, PaintEventArgs e)
        {
            panMenu.Hide();
        }
    }
}
