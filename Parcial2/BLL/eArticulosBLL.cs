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
    public class eArticulosBLL
    {
        public static bool Guardar(eArticulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.artic.Add(articulo) != null)
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

        public static bool Modificar(eArticulos articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
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

        public static eArticulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            eArticulos articulo = new eArticulos();

            try
            {
                articulo = contexto.artic.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            eArticulos articulo = new eArticulos();
            try
            {
                articulo = contexto.artic.Find(id);
                contexto.artic.Remove(articulo);
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

        public static List<eArticulos> GetList(Expression<Func<eArticulos, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<eArticulos> articulo = new List<eArticulos>();

            try
            {
                articulo = contexto.artic.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }
    }
}
