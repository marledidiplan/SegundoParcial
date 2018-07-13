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
    public class ArticulosBLL
    {
        public static bool Guardar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.artiP.Add(articulos) != null)
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

        public static bool Modificar(Articulos articulos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulos).State = EntityState.Modified;
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

        public static Articulos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();

            try
            {
                articulos = contexto.artiP.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Articulos articulos = new Articulos();
            try
            {
                articulos = contexto.artiP.Find(id);
                contexto.artiP.Remove(articulos);
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

        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Articulos> articulos = new List<Articulos>();

            try
            {
                articulos= contexto.artiP.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }

        public static float CalcularGanancia(float costo, float precio)
        {
            float resultado;
            resultado = precio - costo;
            resultado /= costo;
            resultado *= 100;
            return resultado;
            
        }
        

    }
}
