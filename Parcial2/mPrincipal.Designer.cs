namespace Parcial2
{
    partial class mPrincipal
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
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEntradaAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rTalleresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rVehiculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroMantenimietoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaMantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rArticulosToolStripMenuItem,
            this.rEntradaAToolStripMenuItem,
            this.rTalleresToolStripMenuItem,
            this.rVehiculosToolStripMenuItem,
            this.registroMantenimietoToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // rArticulosToolStripMenuItem
            // 
            this.rArticulosToolStripMenuItem.Name = "rArticulosToolStripMenuItem";
            this.rArticulosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rArticulosToolStripMenuItem.Text = "rArticulos";
            this.rArticulosToolStripMenuItem.Click += new System.EventHandler(this.rArticulosToolStripMenuItem_Click);
            // 
            // rEntradaAToolStripMenuItem
            // 
            this.rEntradaAToolStripMenuItem.Name = "rEntradaAToolStripMenuItem";
            this.rEntradaAToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rEntradaAToolStripMenuItem.Text = "rEntradaA";
            this.rEntradaAToolStripMenuItem.Click += new System.EventHandler(this.rEntradaAToolStripMenuItem_Click);
            // 
            // rTalleresToolStripMenuItem
            // 
            this.rTalleresToolStripMenuItem.Name = "rTalleresToolStripMenuItem";
            this.rTalleresToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rTalleresToolStripMenuItem.Text = "rTalleres";
            this.rTalleresToolStripMenuItem.Click += new System.EventHandler(this.rTalleresToolStripMenuItem_Click);
            // 
            // rVehiculosToolStripMenuItem
            // 
            this.rVehiculosToolStripMenuItem.Name = "rVehiculosToolStripMenuItem";
            this.rVehiculosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.rVehiculosToolStripMenuItem.Text = "rVehiculos";
            this.rVehiculosToolStripMenuItem.Click += new System.EventHandler(this.rVehiculosToolStripMenuItem_Click);
            // 
            // registroMantenimietoToolStripMenuItem
            // 
            this.registroMantenimietoToolStripMenuItem.Name = "registroMantenimietoToolStripMenuItem";
            this.registroMantenimietoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.registroMantenimietoToolStripMenuItem.Text = "Registro Mantenimieto";
            this.registroMantenimietoToolStripMenuItem.Click += new System.EventHandler(this.registroMantenimietoToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaMantenimientoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultaMantenimientoToolStripMenuItem
            // 
            this.consultaMantenimientoToolStripMenuItem.Name = "consultaMantenimientoToolStripMenuItem";
            this.consultaMantenimientoToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 594);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mPrincipal";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEntradaAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rTalleresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rVehiculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroMantenimietoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem consultaMantenimientoToolStripMenuItem;
    }
}

