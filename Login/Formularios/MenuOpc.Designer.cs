namespace Login.Formularios
{
    partial class MenuOpc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuDeOpcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeMaterialRecicladoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDePuntosIndividualesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingDeVisualizacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeOpcionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(590, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuDeOpcionesToolStripMenuItem
            // 
            this.menuDeOpcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeMaterialRecicladoToolStripMenuItem,
            this.consultaDePuntosIndividualesToolStripMenuItem,
            this.rankingDeVisualizacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuDeOpcionesToolStripMenuItem.Name = "menuDeOpcionesToolStripMenuItem";
            this.menuDeOpcionesToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.menuDeOpcionesToolStripMenuItem.Text = "Menu de opciones";
            this.menuDeOpcionesToolStripMenuItem.Click += new System.EventHandler(this.menuDeOpcionesToolStripMenuItem_Click);
            // 
            // registroDeMaterialRecicladoToolStripMenuItem
            // 
            this.registroDeMaterialRecicladoToolStripMenuItem.Name = "registroDeMaterialRecicladoToolStripMenuItem";
            this.registroDeMaterialRecicladoToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.registroDeMaterialRecicladoToolStripMenuItem.Text = "Registro de material reciclado";
            this.registroDeMaterialRecicladoToolStripMenuItem.Click += new System.EventHandler(this.registroDeMaterialRecicladoToolStripMenuItem_Click);
            // 
            // consultaDePuntosIndividualesToolStripMenuItem
            // 
            this.consultaDePuntosIndividualesToolStripMenuItem.Name = "consultaDePuntosIndividualesToolStripMenuItem";
            this.consultaDePuntosIndividualesToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.consultaDePuntosIndividualesToolStripMenuItem.Text = "Consulta de puntos individuales";
            this.consultaDePuntosIndividualesToolStripMenuItem.Click += new System.EventHandler(this.consultaDePuntosIndividualesToolStripMenuItem_Click);
            // 
            // rankingDeVisualizacionToolStripMenuItem
            // 
            this.rankingDeVisualizacionToolStripMenuItem.Name = "rankingDeVisualizacionToolStripMenuItem";
            this.rankingDeVisualizacionToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.rankingDeVisualizacionToolStripMenuItem.Text = "Ranking de visualizacion";
            this.rankingDeVisualizacionToolStripMenuItem.Click += new System.EventHandler(this.rankingDeVisualizacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(302, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Login.Properties.Resources.RECICLAJE;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(128, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 159);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MenuOpc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(590, 290);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuOpc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de opciones";
            this.Load += new System.EventHandler(this.MenuOpc_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuDeOpcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeMaterialRecicladoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDePuntosIndividualesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingDeVisualizacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}