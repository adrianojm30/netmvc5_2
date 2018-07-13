using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios.EF
{
    public interface IClienteProductoRespositorioEF : IRepositorioEF<ClienteProducto>
    {
        void PagarRevertir(ClienteProducto entidad);
        void PagarDeuda(ClienteProducto entidad);
        IEnumerable<ClienteProducto> GetAll();
    }
}
