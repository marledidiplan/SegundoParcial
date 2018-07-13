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
        public static bool Guardar(eArticulos articuloEntrada)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.artic.Add(articuloEntrada) != null)
                {
                    
                    Articulos articulos = ArticulosBLL.Buscar(articuloEntrada.ArticuloId);
                    articulos.Inventario += articuloEntrada.Cantidad;
                    BLL.ArticulosBLL.Modificar(articulos);
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

        public static bool Modificar(eArticulos articuloEntrada)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {

                eArticulos articuloEn = eArticulosBLL.Buscar(articuloEntrada.EntradaId);
                int desigualdal = articuloEntrada.Cantidad - articuloEn.Cantidad;
                Articulos articulos = ArticulosBLL.Buscar(articuloEntrada.ArticuloId);
                articulos.Inventario += desigualdal;
                ArticulosBLL.Modificar(articulos);



                contexto.Entry(articuloEntrada).State = EntityState.Modified;
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
           
            try
            { 
                 eArticulos articuloEntrada = new eArticulos();
                articuloEntrada = contexto.artic.Find(id);
                Articulos articulos = ArticulosBLL.Buscar(articuloEntrada.ArticuloId);
                ArticulosBLL.Modificar(articulos);
                
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
            List<eArticulos> articuloEntrada  = new List<eArticulos>();

            try
            {
                articuloEntrada = contexto.artic.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articuloEntrada;
        }
    }
}
