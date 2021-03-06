﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace WebDeveloper.DataAccess
{
    public class AccesoBaseDatos<T> : IAccesoDatos<T> where T : class
    {
        public int Agregar(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Added;
                return dbContext.SaveChanges();
            }
        }

        public int Borrar(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Deleted;
                return dbContext.SaveChanges();
            }
        }

        public List<T> ObtenerLista()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Set<T>().ToList();
            }
        }

        public int Actualizar(T entity)
        {
            using (var dbContext = new WebContextDb())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                return dbContext.SaveChanges();
            }
        }

        public int Contar()
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Set<T>().Count();
            }
        }

    }
}
