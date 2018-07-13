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
    public partial class RegistroE : Form
    {
        public RegistroE()
        {
            InitializeComponent();
            LlenaComBobox();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            eArticulos articulo;
            bool paso = false;
            if (Validar())
            {
                MessageBox.Show("Favor revisar todos los campos", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            articulo = LlenaClase();

            if (IdenumericUpDown.Value == 0)

                    paso = BLL.eArticulosBLL.Guardar(articulo);
                else
                    paso = BLL.eArticulosBLL.Modificar(LlenaClase());


                if (paso)
                    MessageBox.Show("Guardado", "Con Exito!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo Guardar", "Error!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Linventario();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdenumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            CantidadtextBox.Clear();


        }
        public eArticulos LlenaClase()
        {
            eArticulos articulo = new eArticulos();
            articulo.EntradaId = Convert.ToInt32(IdenumericUpDown.Value);
            articulo.Fecha = FechadateTimePicker.Value;
            articulo.ArticuloId = Convert.ToInt32(ArticomboBox.SelectedValue);
            articulo.Cantidad = Convert.ToInt32(CantidadtextBox.Text);

            return articulo;
        }

        public bool Validar()
        {
            bool Errores = false;
            if(String.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                errorProvider.SetError(CantidadtextBox, "No debes dejar la Cantidad vacia");
                    Errores = false;
            }
            return Errores;
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdenumericUpDown.Value);

            if (BLL.eArticulosBLL.Eliminar(id))

                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //else
            //    MessageBox.Show("No existe", "Operacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdenumericUpDown.Value);
            eArticulos articulo = eArticulosBLL.Buscar(id);
            if (articulo != null)
            {
                ArticomboBox.Text = articulo.ArticuloId.ToString();
                FechadateTimePicker.Value = articulo.Fecha;
                CantidadtextBox.Text = articulo.Cantidad.ToString();
            }
            else
                MessageBox.Show("No hay Ningun Dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LlenaComBobox()
        {
            RepositorioBase<Articulos> Repositorio = new RepositorioBase<Articulos>(new Contexto());

            ArticomboBox.DataSource = Repositorio.GetList(c => true);
            ArticomboBox.ValueMember = "ArticuloId";
            ArticomboBox.DisplayMember = "Descripcion";
        }
       /* public void Linventario()
        {
            eArticulos artiEntrada = new eArticulos();
            artiEntrada = LlenaClase();
            foreach (var item in ArticulosBLL.GetList(m=> m.Descripcion == artiEntrada.ArticuloId ))
            {
                item.Inventario += artiEntrada.Cantidad;
                ArticulosBLL.Modificar(item);

            }
        }*/

        private void CantidadtextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
