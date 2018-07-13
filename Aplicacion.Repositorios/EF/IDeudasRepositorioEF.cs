using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios.EF
{
     public interface IDeudasRepositorioEF
    {
        IEnumerable<object> Consultar(Cliente cl);
    }
}
