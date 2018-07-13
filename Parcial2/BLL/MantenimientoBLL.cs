using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Parcial2.Entidades;
using System.Linq.Expressions;
using System.Data.Entity;
using Parcial2.DALL;
using Parcial2.UI.Registro;

namespace Parcial2.BLL
{
    public class MantenimientoBLL
    {
        public static bool Guardar(Mantenimiento manteni)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.mantenimientos.Add(manteni) != null)
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

        public static bool Modificar(Mantenimiento manteni)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(manteni).State = EntityState.Modified;
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

        public static Mantenimiento Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Mantenimiento manteni = new Mantenimiento();

            try
            {
                manteni = contexto.mantenimientos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return manteni;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Mantenimiento manteni = new Mantenimiento();
            try
            {
                manteni = contexto.mantenimientos.Find(id);
                contexto.mantenimientos.Remove(manteni);
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

        public static List<Mantenimiento> GetList(Expression<Func<Mantenimiento, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Mantenimiento> manteni = new List<Mantenimiento>();

            try
            {
                manteni = contexto.mantenimientos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return manteni;
        }
        public static double CalcularImporte(double cantidad, double precio)
        {
            return precio * cantidad;
        }

     
        

    }

}




