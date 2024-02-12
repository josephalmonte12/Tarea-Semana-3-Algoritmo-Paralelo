
namespace AlmoOS
{
    partial class Google
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Google));
            this.picBoxAtras = new System.Windows.Forms.PictureBox();
            this.picBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.webBroPaginaPricipal = new System.Windows.Forms.WebBrowser();
            this.panBarradeTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGoogleTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panMenu
            // 
            this.panMenu.Location = new System.Drawing.Point(0, 106);
            // 
            // panBarradeTareas
            // 
            this.panBarradeTareas.Location = new System.Drawing.Point(0, 733);
            this.panBarradeTareas.Size = new System.Drawing.Size(1389, 57);
            this.panBarradeTareas.Visible = false;
            // 
            // picBoxFondo
            // 
            this.picBoxFondo.Size = new System.Drawing.Size(1389, 790);
            // 
            // labHoraFecha
            // 
            this.labHoraFecha.Location = new System.Drawing.Point(1332, 21);
            this.labHoraFecha.Size = new System.Drawing.Size(91, 20);
            this.labHoraFecha.Text = "07:49 p. m.";
            // 
            // picBoxAtras
            // 
            this.picBoxAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxAtras.Image = ((System.Drawing.Image)(resources.GetObject("picBoxAtras.Image")));
            this.picBoxAtras.Location = new System.Drawing.Point(12, 8);
            this.picBoxAtras.Name = "picBoxAtras";
            this.picBoxAtras.Size = new System.Drawing.Size(28, 29);
            this.picBoxAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAtras.TabIndex = 0;
            this.picBoxAtras.TabStop = false;
            this.picBoxAtras.Click += new System.EventHandler(this.picBoxAtras_Click);
            // 
            // picBoxCerrar
            // 
            this.picBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCerrar.Image")));
            this.picBoxCerrar.Location = new System.Drawing.Point(1350, 8);
            this.picBoxCerrar.Name = "picBoxCerrar";
            this.picBoxCerrar.Size = new System.Drawing.Size(27, 29);
            this.picBoxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCerrar.TabIndex = 1;
            this.picBoxCerrar.TabStop = false;
            this.picBoxCerrar.Click += new System.EventHandler(this.picBoxCerrar_Click);
            // 
            // pictBoxMaximizar
            // 
            this.pictBoxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictBoxMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictBoxMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pictBoxMaximizar.Image")));
            this.pictBoxMaximizar.Location = new System.Drawing.Point(1316, 8);
            this.pictBoxMaximizar.Name = "pictBoxMaximizar";
            this.pictBoxMaximizar.Size = new System.Drawing.Size(28, 29);
            this.pictBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxMaximizar.TabIndex = 3;
            this.pictBoxMaximizar.TabStop = false;
            this.pictBoxMaximizar.Click += new System.EventHandler(this.pictBoxMaximizar_Click);
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(1282, 8);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(28, 29);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxMinimizar.TabIndex = 4;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraSuperior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BarraSuperior.Controls.Add(this.picBoxAtras);
            this.BarraSuperior.Controls.Add(this.picBoxMinimizar);
            this.BarraSuperior.Controls.Add(this.picBoxCerrar);
            this.BarraSuperior.Controls.Add(this.pictBoxMaximizar);
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1394, 44);
            this.BarraSuperior.TabIndex = 6;
            // 
            // webBroPaginaPricipal
            // 
            this.webBroPaginaPricipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBroPaginaPricipal.Location = new System.Drawing.Point(2, 43);
            this.webBroPaginaPricipal.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBroPaginaPricipal.Name = "webBroPaginaPricipal";
            this.webBroPaginaPricipal.Size = new System.Drawing.Size(1389, 746);
            this.webBroPaginaPricipal.TabIndex = 5;
            this.webBroPaginaPricipal.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            // 
            // Google
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 790);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.webBroPaginaPricipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Google";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.picBoxFondo, 0);
            this.Controls.SetChildIndex(this.webBroPaginaPricipal, 0);
            this.Controls.SetChildIndex(this.panBarradeTareas, 0);
            this.Controls.SetChildIndex(this.BarraSuperior, 0);
            this.Controls.SetChildIndex(this.panMenu, 0);
            this.panBarradeTareas.ResumeLayout(false);
            this.panBarradeTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGoogleTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAtras;
        private System.Windows.Forms.PictureBox picBoxCerrar;
        private System.Windows.Forms.PictureBox pictBoxMaximizar;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.WebBrowser webBroPaginaPricipal;
    }
}