
namespace AlmoOS
{
    partial class RepMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepMusica));
            this.panMusica = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnElegirMusica = new System.Windows.Forms.Button();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.picBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panMusica.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panMusica
            // 
            this.panMusica.BackColor = System.Drawing.Color.DimGray;
            this.panMusica.Controls.Add(this.axWindowsMediaPlayer1);
            this.panMusica.Controls.Add(this.btnElegirMusica);
            this.panMusica.Controls.Add(this.BarraSuperior);
            this.panMusica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMusica.Location = new System.Drawing.Point(0, 0);
            this.panMusica.Name = "panMusica";
            this.panMusica.Size = new System.Drawing.Size(782, 550);
            this.panMusica.TabIndex = 0;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 37);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(776, 361);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // btnElegirMusica
            // 
            this.btnElegirMusica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnElegirMusica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirMusica.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnElegirMusica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirMusica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirMusica.Location = new System.Drawing.Point(0, 490);
            this.btnElegirMusica.Margin = new System.Windows.Forms.Padding(4);
            this.btnElegirMusica.Name = "btnElegirMusica";
            this.btnElegirMusica.Size = new System.Drawing.Size(782, 60);
            this.btnElegirMusica.TabIndex = 10;
            this.btnElegirMusica.Text = "Elegir canción";
            this.btnElegirMusica.UseVisualStyleBackColor = false;
            this.btnElegirMusica.Click += new System.EventHandler(this.btnElegirMusica_Click);
            this.btnElegirMusica.MouseEnter += new System.EventHandler(this.btnElegirMusica_MouseEnter);
            this.btnElegirMusica.MouseLeave += new System.EventHandler(this.btnElegirMusica_MouseLeave);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BarraSuperior.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BarraSuperior.Controls.Add(this.picBoxMinimizar);
            this.BarraSuperior.Controls.Add(this.picBoxCerrar);
            this.BarraSuperior.Controls.Add(this.pictBoxMaximizar);
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(782, 44);
            this.BarraSuperior.TabIndex = 7;
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(670, 8);
            this.picBoxMinimizar.Name = "picBoxMinimizar";
            this.picBoxMinimizar.Size = new System.Drawing.Size(28, 29);
            this.picBoxMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxMinimizar.TabIndex = 4;
            this.picBoxMinimizar.TabStop = false;
            this.picBoxMinimizar.Click += new System.EventHandler(this.picBoxMinimizar_Click);
            // 
            // picBoxCerrar
            // 
            this.picBoxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxCerrar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCerrar.Image")));
            this.picBoxCerrar.Location = new System.Drawing.Point(738, 8);
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
            this.pictBoxMaximizar.Location = new System.Drawing.Point(704, 8);
            this.pictBoxMaximizar.Name = "pictBoxMaximizar";
            this.pictBoxMaximizar.Size = new System.Drawing.Size(28, 29);
            this.pictBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxMaximizar.TabIndex = 3;
            this.pictBoxMaximizar.TabStop = false;
            this.pictBoxMaximizar.Click += new System.EventHandler(this.pictBoxMaximizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RepMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 550);
            this.Controls.Add(this.panMusica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepMusica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reproductor de musica";
            this.panMusica.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMaximizar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panMusica;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.PictureBox picBoxCerrar;
        private System.Windows.Forms.PictureBox pictBoxMaximizar;
        private System.Windows.Forms.Button btnElegirMusica;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}