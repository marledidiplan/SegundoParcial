using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial2.BLL;
using Parcial2.Entidades;
using Parcial2.DALL;
using System.Linq.Expressions;
using System.Data.Entity;
using System.Threading.Tasks;



namespace Parcial2.UI.Registro
{
    public partial class RegistroM : Form
    {
        public RegistroM()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void ProximodateTimePicker_ValueChanged(object sender, EventArgs e)
        {


        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Mantenimiento manteni = LlenaClase();
            bool paso = true;

            if (Errores())
            {
                MessageBox.Show("Revisar todos los campos", "Validadon",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (IdmnumericUpDown.Value == 0)
                paso = BLL.MantenimientoBLL.Guardar(manteni);
            else
                paso = BLL.MantenimientoBLL.Guardar(LlenaClase());

            if (paso)
            {
                Nuevobutton.PerformClick();
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Fallo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public void LlenarCampos(Mantenimiento manteni)
        {
            IdmnumericUpDown.Value = manteni.IdMantenimiento;
            FechamdateTimePicker.Value = manteni.Fecha;
            ItbistextBox.Text = manteni.Itbis.ToString();
            SttextBox.Text = manteni.SubTotal.ToString();
            TotaltextBox.Text = manteni.Total.ToString();

            dataGridView.DataSource = manteni.Detalles;
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["MantenimientoId"].Visible = false;
        }

        private bool Errores()
        {
            bool Errores = false;

            if(String.IsNullOrWhiteSpace(CantidadmtextBox.Text))
            {
                errorProvider.SetError(CantidadmtextBox, "Cantidad Vacia");
                Errores = true;
            }
            if(String.IsNullOrWhiteSpace(SttextBox.Text))
            {
                errorProvider.SetError(SttextBox, "Sub-Total Vacio");
                Errores = true;
            }
            if(String.IsNullOrWhiteSpace(ItbistextBox.Text))
            {
                errorProvider.SetError(ItbistextBox, "Itbis Vacio");
                Errores = true;
            }
            if(dataGridView.RowCount ==0)
            {
                errorProvider.SetError(dataGridView, "Anadir Articulos , OBLIGATORIO");
                Errores = true;

            }
            return Errores;
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            List<MantenimientoDetalle> mantenidetalle = new List<MantenimientoDetalle>();
            if (dataGridView.DataSource != null)
            {
                mantenidetalle = (List<MantenimientoDetalle>)dataGridView.DataSource;
            }
            mantenidetalle.Add(
                new MantenimientoDetalle(
                    id: 0,
                    mantenimientoId: (int)IdmnumericUpDown.Value,
                    vehiculoId: (int)VehiculomcomboBox.SelectedValue,
                    tallerId: (int)TallermcomboBox.SelectedValue,
                    articuloId: (int)ArticuloMcomboBox.SelectedValue,
                    articulo: ArticuloMcomboBox.Text,
                   cantidad: (float)Convert.ToSingle(CantidadmtextBox.Text),
                    precio: (float)Convert.ToSingle(PreciomtextBox.Text),
                    importe: (float)Convert.ToSingle(ImporteMtextBox.Text)
                    ));
            dataGridView.DataSource = null;
            dataGridView.DataSource = mantenidetalle;
            CalcularValoresArticulos();

        }
       

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if(dataGridView.Rows.Count > 0 && dataGridView.CurrentRow != null)
            {
                List<MantenimientoDetalle> manteniDetalle = new List<MantenimientoDetalle>();
                manteniDetalle.RemoveAt(dataGridView.CurrentRow.Index);
                dataGridView.DataSource = null;
                dataGridView.DataSource = manteniDetalle;

            }
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Vehiculo> vRepositorio = new RepositorioBase<Vehiculo>(new Contexto());
            RepositorioBase<Talleres> tRepositorio = new RepositorioBase<Talleres>(new Contexto());
            RepositorioBase<Articulos> aRepositorio = new RepositorioBase<Articulos>(new Contexto());

            VehiculomcomboBox.DataSource = vRepositorio.GetList(m => true);
            VehiculomcomboBox.ValueMember = "VehiculoId";
            VehiculomcomboBox.DisplayMember = "Descripcion";

            ArticuloMcomboBox.DataSource = aRepositorio.GetList(m => true);
            ArticuloMcomboBox.ValueMember = "ArticuloId";
            ArticuloMcomboBox.DisplayMember = "Descripcion";

            TallermcomboBox.DataSource = tRepositorio.GetList(m => true);
            TallermcomboBox.ValueMember = "TallerId";
            TallermcomboBox.DisplayMember = "Nombre";
        }


        private Mantenimiento LlenaClase()
        {
            Mantenimiento manteni = new Mantenimiento();

            manteni.IdMantenimiento = Convert.ToInt32(IdmnumericUpDown.Value);
            manteni.Fecha = FechamdateTimePicker.Value;


            foreach (DataGridViewRow item in dataGridView.Rows)
            {

                manteni.AnadirDetalle
                    (
                    ToInt(item.Cells["id"].Value),
                     ToInt(item.Cells["mantenimientoId"].Value),
                     ToInt(item.Cells["vehiculoId"].Value),
                      ToInt(item.Cells["tallerId"].Value),
                       ToInt(item.Cells["articuloId"].Value),
                       item.Cells["articulo"].ToString(),
                     ToInt(item.Cells["cantidad"].Value),
                     ToInt(item.Cells["precio"].Value),
                    ToInt(item.Cells["importe"].Value)



                  );
            }

            return manteni;
        }

        public void precio()
        {
            List<Articulos> articulos = ArticulosBLL.GetList(m => m.Descripcion == ArticuloMcomboBox.Text);
            foreach (var item in articulos)
            {
                PreciomtextBox.Text = item.Precio.ToString();
            }
        }

        private void CantidadmtextBox_TextChanged(object sender, EventArgs e)
        {
            precio();
            ImporteMtextBox.Text = MantenimientoBLL.CalcularImporte(Convert.ToInt32(CantidadmtextBox.Text), Convert.ToInt32(PreciomtextBox.Text)).ToString();

        }

        private void ArticuloMcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            precio();
        }

        public void Citbis()
        {
            //List<Articulos> articulos = ArticulosBLL.GetList(m => m.Descripcion == ArticuloMcomboBox.Text);
            List<Mantenimiento> manteni = new List<Mantenimiento>();
            foreach (var item in manteni)
            {
                ItbistextBox.Text = item.Itbis.ToString();

            }
        }
       
       /* public void Ctotal()
        {
           List<Mantenimiento> manteni = (List<Mantenimiento>)dataGridView.DataSource;

                
                //BLL.MantenimientoBLL.CalcularTotal(DataGridViewRow item in dataGridView.Rows);
           
            foreach (var item in manteni)
            {
                TotaltextBox = item
            }

        }*/

        public void CalcularValoresArticulos()
        {
            Mantenimiento manteni = new Mantenimiento();
            double subTotal=0;
            foreach (var item in manteni.Detalles)
            {
                subTotal = item.Importe;
            }
            SttextBox.Text = subTotal.ToString();
            double itbis= subTotal * 0.18;
            ItbistextBox.Text = itbis.ToString();

            
            double total = subTotal + itbis;
            TotaltextBox.Text = total.ToString();
            dataGridView.DataSource = manteni.Detalles;

           
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            IdmnumericUpDown.Value = 0;
            ArticuloMcomboBox.SelectedIndex = 0;
            FechamdateTimePicker.Value = DateTime.Now;
            PreciomtextBox.Clear();
            CantidadmtextBox.Clear();
            SttextBox.Clear();
            ItbistextBox.Clear();
            TotaltextBox.Clear();
            dataGridView.DataSource = null;


        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(IdmnumericUpDown.Value);
            Mantenimiento manteni = new Mantenimiento();

            if (BLL.MantenimientoBLL.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
