using Aplicacion.Repositorios.EF;
using Aplicacion.Servicios.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
     public interface IEFUnitOfWork
    {
        IClienteServicioEF ClienteServicioEF { get; }
         IClienteProductoServicioEF ClienteProductoServicioEF { get;  }
         IDeudasServicioEF DeudasServicioEF { get;  }
        IUsuarioServicioEF UsuarioServicioEF { get;  }
    }
}
