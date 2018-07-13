using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios
{
    public interface IRepositorioEF<T> where T : class
    {
        bool Delete(T entity);
        int Insert(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetEntityById(int id);
    }
}
