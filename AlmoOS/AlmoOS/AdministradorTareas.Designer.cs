namespace AlmoOS
{
    partial class AdministradorTareas
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorTareas));
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslProcessCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnUpdateProcessList = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lst_id = new System.Windows.Forms.ListBox();
            this.lst_memoriafisica = new System.Windows.Forms.ListBox();
            this.lst_memoriavirtual = new System.Windows.Forms.ListBox();
            this.lst_CPU = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.picBoxMinimizar = new System.Windows.Forms.PictureBox();
            this.picBoxCerrar = new System.Windows.Forms.PictureBox();
            this.pictBoxMaximizar = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMaximizar)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProcesses
            // 
            this.lstProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.HorizontalScrollbar = true;
            this.lstProcesses.ItemHeight = 16;
            this.lstProcesses.Location = new System.Drawing.Point(45, 95);
            this.lstProcesses.Margin = new System.Windows.Forms.Padding(4);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.ScrollAlwaysVisible = true;
            this.lstProcesses.Size = new System.Drawing.Size(165, 404);
            this.lstProcesses.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslProcessCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 582);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1060, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslProcessCount
            // 
            this.tslProcessCount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tslProcessCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tslProcessCount.Name = "tslProcessCount";
            this.tslProcessCount.Size = new System.Drawing.Size(151, 20);
            this.tslProcessCount.Text = "toolStripStatusLabel1";
            // 
            // btnUpdateProcessList
            // 
            this.btnUpdateProcessList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUpdateProcessList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateProcessList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProcessList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProcessList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProcessList.Location = new System.Drawing.Point(45, 524);
            this.btnUpdateProcessList.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateProcessList.Name = "btnUpdateProcessList";
            this.btnUpdateProcessList.Size = new System.Drawing.Size(165, 35);
            this.btnUpdateProcessList.TabIndex = 2;
            this.btnUpdateProcessList.Text = "Actualizar";
            this.btnUpdateProcessList.UseVisualStyleBackColor = false;
            this.btnUpdateProcessList.Click += new System.EventHandler(this.btnUpdateProcessList_Click_1);
            // 
            // btnKill
            // 
            this.btnKill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnKill.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(231, 524);
            this.btnKill.Margin = new System.Windows.Forms.Padding(4);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(165, 35);
            this.btnKill.TabIndex = 3;
            this.btnKill.Text = "Detener";
            this.btnKill.UseVisualStyleBackColor = false;
            this.btnKill.Click += new System.EventHandler(this.btnKill_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(849, 524);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(653, 524);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 34);
            this.button2.TabIndex = 5;
            this.button2.Text = "Información";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lst_id
            // 
            this.lst_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lst_id.FormattingEnabled = true;
            this.lst_id.HorizontalScrollbar = true;
            this.lst_id.ItemHeight = 16;
            this.lst_id.Location = new System.Drawing.Point(241, 95);
            this.lst_id.Margin = new System.Windows.Forms.Padding(4);
            this.lst_id.Name = "lst_id";
            this.lst_id.ScrollAlwaysVisible = true;
            this.lst_id.Size = new System.Drawing.Size(165, 404);
            this.lst_id.TabIndex = 7;
            // 
            // lst_memoriafisica
            // 
            this.lst_memoriafisica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lst_memoriafisica.FormattingEnabled = true;
            this.lst_memoriafisica.HorizontalScrollbar = true;
            this.lst_memoriafisica.ItemHeight = 16;
            this.lst_memoriafisica.Location = new System.Drawing.Point(448, 95);
            this.lst_memoriafisica.Margin = new System.Windows.Forms.Padding(4);
            this.lst_memoriafisica.Name = "lst_memoriafisica";
            this.lst_memoriafisica.ScrollAlwaysVisible = true;
            this.lst_memoriafisica.Size = new System.Drawing.Size(165, 404);
            this.lst_memoriafisica.TabIndex = 8;
            // 
            // lst_memoriavirtual
            // 
            this.lst_memoriavirtual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lst_memoriavirtual.FormattingEnabled = true;
            this.lst_memoriavirtual.HorizontalScrollbar = true;
            this.lst_memoriavirtual.ItemHeight = 16;
            this.lst_memoriavirtual.Location = new System.Drawing.Point(653, 95);
            this.lst_memoriavirtual.Margin = new System.Windows.Forms.Padding(4);
            this.lst_memoriavirtual.Name = "lst_memoriavirtual";
            this.lst_memoriavirtual.ScrollAlwaysVisible = true;
            this.lst_memoriavirtual.Size = new System.Drawing.Size(165, 404);
            this.lst_memoriavirtual.TabIndex = 9;
            // 
            // lst_CPU
            // 
            this.lst_CPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lst_CPU.FormattingEnabled = true;
            this.lst_CPU.HorizontalScrollbar = true;
            this.lst_CPU.ItemHeight = 16;
            this.lst_CPU.Location = new System.Drawing.Point(849, 95);
            this.lst_CPU.Margin = new System.Windows.Forms.Padding(4);
            this.lst_CPU.Name = "lst_CPU";
            this.lst_CPU.ScrollAlwaysVisible = true;
            this.lst_CPU.Size = new System.Drawing.Size(165, 404);
            this.lst_CPU.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Procesos:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(236, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(443, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Memoria fisica :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(648, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Memoria Virtual:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(844, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "CPU:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.BarraSuperior);
            this.panel1.Controls.Add(this.lst_CPU);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lst_memoriavirtual);
            this.panel1.Controls.Add(this.btnUpdateProcessList);
            this.panel1.Controls.Add(this.lst_memoriafisica);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lst_id);
            this.panel1.Controls.Add(this.btnKill);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lstProcesses);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 608);
            this.panel1.TabIndex = 16;
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
            this.BarraSuperior.Size = new System.Drawing.Size(1060, 44);
            this.BarraSuperior.TabIndex = 16;
            // 
            // picBoxMinimizar
            // 
            this.picBoxMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBoxMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimizar.Image")));
            this.picBoxMinimizar.Location = new System.Drawing.Point(948, 8);
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
            this.picBoxCerrar.Location = new System.Drawing.Point(1016, 8);
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
            this.pictBoxMaximizar.Location = new System.Drawing.Point(982, 8);
            this.pictBoxMaximizar.Name = "pictBoxMaximizar";
            this.pictBoxMaximizar.Size = new System.Drawing.Size(28, 29);
            this.pictBoxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxMaximizar.TabIndex = 3;
            this.pictBoxMaximizar.TabStop = false;
            this.pictBoxMaximizar.Click += new System.EventHandler(this.pictBoxMaximizar_Click);
            // 
            // AdministradorTareas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1060, 608);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministradorTareas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Tareas";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxMaximizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslProcessCount;
        private System.Windows.Forms.Button btnUpdateProcessList;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lst_id;
        private System.Windows.Forms.ListBox lst_memoriafisica;
        private System.Windows.Forms.ListBox lst_memoriavirtual;
        private System.Windows.Forms.ListBox lst_CPU;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox picBoxMinimizar;
        private System.Windows.Forms.PictureBox picBoxCerrar;
        private System.Windows.Forms.PictureBox pictBoxMaximizar;
    }
}

