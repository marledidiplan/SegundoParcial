namespace Parcial2.UI.Registro
{
    partial class RegistroA
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
            this.components = new System.ComponentModel.Container();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CostotextBox = new System.Windows.Forms.TextBox();
            this.GananciatextBox = new System.Windows.Forms.TextBox();
            this.InvetextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(102, 27);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(99, 20);
            this.IdnumericUpDown.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Articulos Id";
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(113, 175);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(59, 20);
            this.PreciotextBox.TabIndex = 28;
            this.PreciotextBox.TextChanged += new System.EventHandler(this.PreciotextBox_TextChanged);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(83, 75);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(202, 42);
            this.DescripciontextBox.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "% Ganancia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Inventario";
            // 
            // CostotextBox
            // 
            this.CostotextBox.Location = new System.Drawing.Point(113, 142);
            this.CostotextBox.Name = "CostotextBox";
            this.CostotextBox.Size = new System.Drawing.Size(59, 20);
            this.CostotextBox.TabIndex = 32;
            this.CostotextBox.TextChanged += new System.EventHandler(this.CostotextBox_TextChanged);
            // 
            // GananciatextBox
            // 
            this.GananciatextBox.Location = new System.Drawing.Point(258, 139);
            this.GananciatextBox.Name = "GananciatextBox";
            this.GananciatextBox.Size = new System.Drawing.Size(59, 20);
            this.GananciatextBox.TabIndex = 33;
            this.GananciatextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // InvetextBox
            // 
            this.InvetextBox.Location = new System.Drawing.Point(258, 178);
            this.InvetextBox.Name = "InvetextBox";
            this.InvetextBox.ReadOnly = true;
            this.InvetextBox.Size = new System.Drawing.Size(59, 20);
            this.InvetextBox.TabIndex = 34;
            this.InvetextBox.TextChanged += new System.EventHandler(this.InvetextBox_TextChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial2.Properties.Resources.Search_25px;
            this.Buscarbutton.Location = new System.Drawing.Point(217, 18);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(51, 34);
            this.Buscarbutton.TabIndex = 10;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial2.Properties.Resources.Trash_Can_48px;
            this.Eliminarbutton.Location = new System.Drawing.Point(260, 248);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(104, 46);
            this.Eliminarbutton.TabIndex = 9;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial2.Properties.Resources.File_48px;
            this.Nuevobutton.Location = new System.Drawing.Point(26, 253);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(92, 46);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial2.Properties.Resources.Save_48px;
            this.Guardarbutton.Location = new System.Drawing.Point(141, 253);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(92, 46);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // RegistroA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(370, 326);
            this.Controls.Add(this.InvetextBox);
            this.Controls.Add(this.GananciatextBox);
            this.Controls.Add(this.CostotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Guardarbutton);
            this.Name = "RegistroA";
            this.Text = "Registro Articulo";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.RegistroA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CostotextBox;
        private System.Windows.Forms.TextBox GananciatextBox;
        private System.Windows.Forms.TextBox InvetextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}