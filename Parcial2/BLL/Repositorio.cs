using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Parcial2.BLL;

namespace Parcial2.BLL
{
   public interface Repositorio<T>  where T : class
    {
        List<T> GetList(Expression<Func<T, bool>> expression);
            T Buscar(int id);
        bool Guardar(T entity);
        bool Modificar(T entity);
        bool Eliminar(int id);
    }
}
