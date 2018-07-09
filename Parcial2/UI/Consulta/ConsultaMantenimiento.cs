using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;
using Parcial2.Entidades;
using Parcial2.BLL;


namespace Parcial2.UI.Consulta
{
    public partial class ConsultaMantenimiento : Form
    {
        public ConsultaMantenimiento()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Expression<Func<Mantenimiento, bool>> Filtro = m => true;
            int id;

            switch (FiltrocomboBox.DataSource)
            {
                case 0: id = Convert.ToInt32(CriteriotextBox.Text);
                    Filtro = m => m.IdMantenimiento == id;
                    break;

                case 1: Filtro = m=> m.Fecha.Equals(CriteriotextBox.Text)
                 && (m.Fecha >= DesdedateTimePicker.Value && m.Fecha <= HastadateTimePicker.Value);
                    break;
                case 2: Filtro = m => m.Itbis.Equals(CriteriotextBox.Text)
                 && (m.Fecha >= DesdedateTimePicker.Value && m.Fecha <= HastadateTimePicker.Value);
                    break;
                case 3: Filtro = m=> m.SubTotal.Equals(CriteriotextBox.Text)
                 && (m.Fecha >= DesdedateTimePicker.Value && m.Fecha <= HastadateTimePicker.Value);
                    break;
                case 4: Filtro = m=> m.Total.Equals(CriteriotextBox.Text)
                 && (m.Fecha >= DesdedateTimePicker.Value && m.Fecha <= HastadateTimePicker.Value);
                    break;


            }
            ConsultadataGridView.DataSource = MantenimientoBLL.GetList(Filtro);
        }
    }
}
