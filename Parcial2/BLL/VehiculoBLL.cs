﻿using System;
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
        public static bool Guardar(Vehiculo vehi)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if(contexto.vehiculo.Add(vehi) !=null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Vehiculo vehi)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(vehi).State = EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
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
        public  static Vehiculo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Vehiculo vehi= new Vehiculo();
            
            try
            {
                vehi = contexto.vehiculo.Find(id);
                contexto.Dispose();
            }
            catch(Exception)
            {
                throw;
            }
            return vehi;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Vehiculo vehi = new Vehiculo();
            try
            {
                vehi = contexto.vehiculo.Find(id);
                contexto.vehiculo.Remove(vehi);
                if(contexto.SaveChanges() >0)
                {
                    paso = true;
                }
            }
            catch(Exception)
            {
                throw;
            }
            return paso;
        }
        
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
