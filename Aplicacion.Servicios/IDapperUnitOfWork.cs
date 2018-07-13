using Aplicacion.Servicios.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios
{
     public interface IDapperUnitOfWork
    {
        IClienteProductoServicio ClienteProductoServicios { get; }
        IDeudasServicio DeudasServicios { get; }
        IUsuarioServicio UsuarioServicios { get; }
    }
}
