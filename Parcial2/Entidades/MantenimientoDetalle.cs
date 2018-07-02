using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Parcial2.Entidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parcial2.Entidades
{
   public class MantenimientoDetalle
    {
        [Key]
        public int MantenimientoId { get; set; }
        public DateTime Fecha { get; set; }
        public string Vehiculos { get; set; }
        public string Taller { get; set; }
        public string Servicios { get; set; }
        public int Cantidad { get; set; }
        public int Precio { get; set; }
        public int Importe { get; set; }
        public int Total { get; set; }


        [ForeignKey("vehiculoId")]
        public virtual Vehiculo Vehiculo { get; set; }

        public MantenimientoDetalle()
        {

            MantenimientoId = 0;
            Fecha = DateTime.Now;
            Vehiculos = string.Empty;
            Taller = string.Empty;
            Servicios = string.Empty;
            Cantidad = 0;
            Precio = 0;
            Importe = 0;
            Total = 0;
        }
        public MantenimientoDetalle( int mantenimientoId, string vehiculoss,string taller, string servicio, int cantidad, int precio, int importe, int total)
        {
            this.MantenimientoId = mantenimientoId;
            this.Vehiculos = vehiculoss;
            this.Taller = taller;
            this.Servicios = servicio;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe = importe;
            this.Total = total;
        }
    }
}
