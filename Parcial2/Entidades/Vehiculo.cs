using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Parcial2.Entidades
{
   public class Vehiculo
    {
        public int VehiculoId { get; set; }
        public string Descripcion { get; set; }
        public int Mantenimiento { get; set; }

        public virtual List<MantenimientoDetalle> Detalles { get; set; }

        public Vehiculo()
        {
            this.Detalles = new List<MantenimientoDetalle>();
        }
        public void AnadirDetalle(int mantenimientoId, string vehiculoss, string taller, string servicio, int cantidad, int precio, int importe, int total)
        {
            this.Detalles.Add(new MantenimientoDetalle(mantenimientoId, vehiculoss,  taller, servicio, cantidad, precio, importe, total));
        }

    }
}
