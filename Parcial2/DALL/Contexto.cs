using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Parcial2.DALL
{
    public class Contexto : DbContext
    {

        public Contexto() : base("ConStr")
        {

        }
    }
}
