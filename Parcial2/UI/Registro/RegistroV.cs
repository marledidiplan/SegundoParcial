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
    public partial class RegistroV : Form
    {
        public RegistroV()
        {
            InitializeComponent();
            TotalmtextBox.Text = "0";
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdvnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            TotalmtextBox.Clear();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Vehiculo vehi = new Vehiculo();
              vehi=  LlenaClase();
            bool paso = false;

            if(Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                if (IdvnumericUpDown.Value == 0)
                    paso = BLL.VehiculoBLL.Guardar(vehi);
                else
                    paso = BLL.VehiculoBLL.Modificar(vehi);

                if (paso)
                    MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
        }
        public Vehiculo LlenaClase()
        {
            Vehiculo vehi = new Vehiculo();
            vehi.VehiculoId = Convert.ToInt32(IdvnumericUpDown.Value);
            vehi.Descripcion = DescripciontextBox.Text;
           //  vehi.Mantenimiento = Convert.ToInt32(TotalmtextBox.Text);

            return vehi;
        }
        public bool Validar()
        {
            bool Errores = false;
            if(String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Descripcion Vacia");
                Errores = true;
            }
            return Errores;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdvnumericUpDown.Value);
            Vehiculo vehi = BLL.VehiculoBLL.Buscar(id);
            if (vehi != null)
            {
                DescripciontextBox.Text = vehi.Descripcion;
                TotalmtextBox.Text = vehi.Mantenimiento.ToString();
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdvnumericUpDown.Value);

            if (BLL.TalleresBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
