using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Parcial2.Entidades
{
    public class Talleres
    {
        [Key]
        public int TallerId { get; set; }
        public string Nombre { get; set; }

        public Talleres()
        {
            TallerId = 0;
            Nombre = string.Empty;
        }
    }
}
