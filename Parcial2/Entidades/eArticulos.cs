using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Parcial2.Entidades
{
    public class eArticulos
    {
        [Key]
        public int EntradaId { get; set; }
        public string Articulo{ get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        public eArticulos()
        {
            EntradaId = 0;
            Articulo = string.Empty;
            Fecha = DateTime.Now;
            Cantidad = 0;
        }
    }
}
