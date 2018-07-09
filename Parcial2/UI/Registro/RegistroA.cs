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
    public partial class RegistroA : Form
    {
        public RegistroA()
        {
            InitializeComponent();
            InvetextBox.Text = "0";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            //GananciatextBox.Text = ArticulosBLL.CalcularGanancia(Convert.ToInt32(CostotextBox.Text), Convert.ToInt32(PreciotextBox.Text)).ToString();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();
            bool paso = false;
            
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            articulo = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = BLL.ArticulosBLL.Guardar(articulo);

            else
                paso = BLL.ArticulosBLL.Modificar(LlenaClase());

            if (paso)
                MessageBox.Show("Guardado", "Con Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo Guardar", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public Articulos LlenaClase()
        {
            Articulos articulo = new Articulos();
            articulo.ArticuloId = Convert.ToInt32(IdnumericUpDown.Value);
            articulo.Descripcion = DescripciontextBox.Text;
            articulo.Precio = Convert.ToInt32(PreciotextBox.Text);
            articulo.Costo = Convert.ToInt32( CostotextBox.Text);
            articulo.Ganancia= Convert.ToInt32(GananciatextBox.Text);

            return articulo;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Clear();
            PreciotextBox.Clear();
            CostotextBox.Clear();
            GananciatextBox.Clear();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdnumericUpDown.Value);

            if (BLL.ArticulosBLL.Eliminar(id))
                MessageBox.Show("Eliminado!", "Con Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else
                MessageBox.Show("No se elimino", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool Validar()
        {
            bool HayErrores = false;

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox, "Descripcion Vacio");
                HayErrores = true;
            }
            if (PreciotextBox.Text == String.Empty)
            {
                errorProvider.SetError(PreciotextBox, "Precio Vacio");
                HayErrores = true;
            }
            if (CostotextBox.Text == String.Empty)
            {
                errorProvider.SetError(CostotextBox, "Costo Vacio");
                HayErrores = true;
            }
            
            return HayErrores;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
          
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                Articulos articulo = BLL.ArticulosBLL.Buscar(id);
                if (articulo != null)
                {
                    DescripciontextBox.Text = articulo.Descripcion;
                    PreciotextBox.Text = articulo.Precio.ToString();
                    CostotextBox.Text = articulo.Costo.ToString();
                    GananciatextBox.Text = articulo.Ganancia.ToString();
                    InvetextBox.Text = articulo.Inventario.ToString();

                   
           
                }
        }
       

        private void PreciotextBox_TextChanged(object sender, EventArgs e)
        {
            float costo = ToFloat(CostotextBox.Text);
            float precio = ToFloat(PreciotextBox.Text);
            GananciatextBox.Text = ArticulosBLL.CalcularGanancia(costo, precio).ToString();
           
           

        }

        private void InvetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CostotextBox_TextChanged(object sender, EventArgs e)
        {
            //CostotextBox.Text = ArticulosBLL.CalcularC(Convert.ToInt32(PreciotextBox.Text), Convert.ToInt32(GananciatextBox.Text)).ToString();
        }
        private float ToFloat(object valor)
        {
            float retorno = 0;
            float.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void RegistroA_Load(object sender, EventArgs e)
        {

        }
    }
}
