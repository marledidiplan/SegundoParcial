using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parcial2.DALL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Parcial2.BLL
{
    public class RepositorioBase<T> : IDisposable, Repositorio<T> where T : class
    {

        internal Contexto _contexto;

       
        public RepositorioBase(Contexto contexto)
        {
            _contexto = contexto;
        }

        
        public bool Guardar(T entity)
        {
            bool paso = false;
            try
            {
                if (_contexto.Set<T>().Add(entity) != null)
                {
                    _contexto.SaveChanges();
                }
                _contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

       
        public virtual T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.Set<T>().Find(id);
                _contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return entity;
        }

       
        public bool Eliminar(int id)
        {
            bool paso = false;
            try
            {
                T entity = _contexto.Set<T>().Find(id);
                _contexto.Set<T>().Remove(entity);
                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                _contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

      

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            List<T> Lista = new List<T>();
            try
            {
                Lista = _contexto.Set<T>().Where(expression).ToList();
                _contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return Lista;
        }



        public virtual bool Modificar(T entity)
        {
            bool paso = false;
            try
            {
                _contexto.Entry(entity).State = EntityState.Modified;
                if (_contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                _contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public void Dispose()
        {
            _contexto.Dispose();
        }
    }
}
