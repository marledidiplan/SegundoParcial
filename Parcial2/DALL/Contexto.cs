using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Parcial2.Entidades;

namespace Parcial2.DALL
{
    public class Contexto : DbContext
    {
        public DbSet<Vehiculo> vehiculo { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }
}
