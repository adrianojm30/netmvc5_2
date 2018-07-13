using Aplicacion.Beans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
    public interface IDeudasServicioEF
    {

        IEnumerable<object> ConsultaDeudas(ClienteBean clienteBean);
    }
}
