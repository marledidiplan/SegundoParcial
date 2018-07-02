using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;
using Parcial2.Entidades;
using Parcial2.DALL;

namespace Parcial2.BLL
{
    public class VehiculoDetalleBLL
    {
        public static bool Guardar(Vehiculo vehiculoD)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.vehiculo.Add(vehiculoD) != null)
                {
                    contexto.SaveChanges();
                    paso = true;

                }
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        
    }
}
