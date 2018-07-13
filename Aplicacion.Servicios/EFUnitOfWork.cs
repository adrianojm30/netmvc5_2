using Aplicacion.Models;
using Aplicacion.Repositorios.EF;
using Aplicacion.Servicios.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
    public class EFUnitOfWork:IEFUnitOfWork
    {
        public EFUnitOfWork(PGDbContext context)
        {
            ClienteServicioEF = new ClienteServicioEF(context);
            ClienteProductoServicioEF = new ClienteProductoServicioEF(context);
            DeudasServicioEF = new DeudasServicioEF(context);
            UsuarioServicioEF = new UsuarioServicioEF(context);

        }
        public IClienteServicioEF ClienteServicioEF { get; private set; }
        public IClienteProductoServicioEF ClienteProductoServicioEF { get; private set; }
        public IDeudasServicioEF DeudasServicioEF { get; private set; }
        public IUsuarioServicioEF UsuarioServicioEF { get; private set; }

    }
}
