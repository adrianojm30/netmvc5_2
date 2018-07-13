using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Aplicacion.Repositorios
{
    public class RepositorioEF<T> : IRepositorioEF<T> where T : class
    {



        protected readonly PGDbContext _context;
        public RepositorioEF(PGDbContext context)
        {
            _context = context;
        }
        public bool Delete(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetEntityById(int id)
        {
            return _context.Set<T>().Find(id);
        }


        public int Insert(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChanges();
        }

        public bool Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Detached;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

    }
}
