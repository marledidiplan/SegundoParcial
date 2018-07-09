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
   public class TalleresBLL
    {
        public static bool Guardar(Talleres taller)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.talleres.Add(taller) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Talleres taller)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(taller).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static Talleres Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Talleres taller = new Talleres();
            try
            {
                taller = contexto.talleres.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return taller;
        }

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();
            Talleres taller = new Talleres();
            try
            {
                taller = contexto.talleres.Find(id);
                contexto.talleres.Remove(taller);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static List<Talleres> GetList(Expression<Func<Talleres, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Talleres> taller = new List<Talleres>();

            try
            {
                taller = contexto.talleres.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return taller;
        }
    }
}
