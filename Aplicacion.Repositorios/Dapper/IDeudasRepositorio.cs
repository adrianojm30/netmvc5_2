using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios.Dapper
{
    public interface IDeudasRepositorio
    {
        IEnumerable<object> ListDeudas(Cliente cl);
    }
}
