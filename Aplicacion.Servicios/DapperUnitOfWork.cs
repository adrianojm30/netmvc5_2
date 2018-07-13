using Aplicacion.Servicios.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
    public class DapperUnitOfWork : IDapperUnitOfWork
    {
        public DapperUnitOfWork()
        {
            ClienteProductoServicios = new ClienteProductoServicio();
            DeudasServicios = new DeudasServicio();
            UsuarioServicios = new UsuarioServicio();
        }
        public IClienteProductoServicio ClienteProductoServicios { get; private set; }
        public IDeudasServicio DeudasServicios { get; private set; }
        public IUsuarioServicio UsuarioServicios { get; private set; }
    }
}
