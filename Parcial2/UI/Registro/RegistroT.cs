using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial2.Entidades;
using Parcial2.BLL;
using Parcial2.DALL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial2.UI.Registro
{
    public partial class RegistroT : Form
    {
        public RegistroT()
        {
            InitializeComponent();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Talleres taller = new Talleres();
            taller = LlenaClase();
            bool paso = false;
            if(Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                if (IdtnumericUpDown.Value == 0)
                    paso = BLL.TalleresBLL.Guardar(taller);
                else
                    paso = BLL.TalleresBLL.Modificar(taller);

                if (paso)
                    MessageBox.Show("Guardado", "Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdtnumericUpDown.Value = 0;
            NombretextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdtnumericUpDown.Value);

            if (BLL.TalleresBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public Talleres LlenaClase()
        {
            Talleres taller = new Talleres();
            taller.TallerId = Convert.ToInt32(IdtnumericUpDown.Value);
            taller.Nombre = NombretextBox.Text;

            return taller;
        }
        public bool Validar()
        {
            bool Errores = false;
            if(String.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Nombre vacio");
                Errores = false;
            }
            return Errores;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdtnumericUpDown.Value);
            Talleres taller = BLL.TalleresBLL.Buscar(id);
            if(taller != null)
            {
                NombretextBox.Text = taller.Nombre;
            }
        }
    }
}
