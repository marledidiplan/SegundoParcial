using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace Parcial2.Entidades
{
    public class Mantenimiento
    {
        [Key]
        public int IdMantenimiento { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaProxima { get; set; }
        public double Total { get; set; }
        public double SubTotal { get; set; }
        public double Itbis { get; set; }

        public virtual List<MantenimientoDetalle> Detalles { get; set; }

        public Mantenimiento()
        {
            this.Detalles = new List<MantenimientoDetalle>();
        }
        public void AnadirDetalle(int id, int mantenimientoId, int vehiculoId, int tallerId, int articuloId, string articulo, float cantidad, float precio, float importe)
        {
            this.Detalles.Add(new MantenimientoDetalle(id,mantenimientoId, vehiculoId, tallerId, articuloId, articulo, cantidad, precio, importe));


        }
    }
}
