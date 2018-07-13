using Aplicacion.Beans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
    public interface IClienteProductoServicioEF
    {
        List<ClienteProductoBean> ListaClienteProducto();
        void PagarDeuda(ClienteProductoBean clienterproducto);
        void PagarRevertir(ClienteProductoBean clienterproducto);
    }
}
