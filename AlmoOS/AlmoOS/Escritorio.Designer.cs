
namespace AlmoOS
{
    partial class Escritorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escritorio));
            this.panBarradeTareas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGoogleTareas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // labHoraFecha
            // 
            this.labHoraFecha.Size = new System.Drawing.Size(91, 20);
            this.labHoraFecha.Text = "08:28 p. m.";
            // 
            // Escritorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 743);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Escritorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escritorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panBarradeTareas.ResumeLayout(false);
            this.panBarradeTareas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGoogleTareas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}