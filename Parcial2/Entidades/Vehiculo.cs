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
        public double Mantenimiento { get; set; }

        public Vehiculo()
        {
            VehiculoId = 0;
            Descripcion = string.Empty;
            Mantenimiento = 0;
        }
    }
}
