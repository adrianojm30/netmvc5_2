using Aplicacion.Beans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.Dapper
{
     public interface IDeudasServicio
    {
        IEnumerable<object> ConsultaDeudasFinal(ClienteBean clienteBean);
    }
}
