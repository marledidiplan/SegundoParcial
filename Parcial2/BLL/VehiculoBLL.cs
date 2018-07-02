using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parcial2.Entidades;
using System.Linq.Expressions;
using System.Data.Entity;
using Parcial2.DALL;

namespace Parcial2.BLL
{
    public class VehiculoBLL
    {

       public static List<Vehiculo>  GetList(Expression<Func<Vehiculo, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                vehiculos = contexto.vehiculo.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return vehiculos;
        }
    }
}
