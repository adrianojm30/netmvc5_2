using Aplicacion.Beans;
using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
    public interface IClienteServicioEF
    {
        
        List<ClienteBean> ObtenerCliente();
        int GuardarCliente(ClienteBean clienteBean);
        bool ActualizarCliente(ClienteBean clienteBean);
        ClienteBean ObtenerClientePorId(int id);
        bool EliminarCliente(ClienteBean clienteBean);
    }
}
