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
        public int Id { get; set; }
        public int MantenimientoId { get; set; }
       
        public int ArticuloId { get; set; }
        public string Articulo { get; set; }
        public int TallerId { get; set; }
        public int VehiculoId { get; set; }
        public int EntradaId { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
        public float Importe { get; set; }
        


        [ForeignKey("VehiculoId")]
        public virtual Vehiculo Vehiculo { get; set; }

        [ForeignKey("ArticuloId")]
        public virtual Articulos Articulos { get; set; }

        [ForeignKey("TallerId")]
        public virtual Talleres talllere { get; set; }

        public MantenimientoDetalle()
        {
            Id = 0;
            MantenimientoId = 0;
            TallerId = 0;
            ArticuloId = 0;
            Articulo = string.Empty;
            EntradaId = 0;
            Cantidad = 0;
            Precio = 0;
            
        }
        public MantenimientoDetalle( int id,int mantenimientoId, int vehiculoId, int tallerId,  int articuloId , string articulo, int cantidad, float precio, float importe )
        {
            this.Id = id;
            this.MantenimientoId = mantenimientoId;
            this.VehiculoId = vehiculoId;
            this.TallerId = tallerId;
            this.ArticuloId = articuloId;
            this.Articulo = articulo;
            this.Cantidad = cantidad;
            this.Precio = precio;
            this.Importe = importe;
        }
    }
}
