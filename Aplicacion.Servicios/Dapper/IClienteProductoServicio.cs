using Aplicacion.Beans;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.Dapper
{
     public interface IClienteProductoServicio
    {
        void PagarDeudaDaper(ClienteProductoBean clienterproducto);
        void PagarRevertirDaper(ClienteProductoBean clienterproducto);
    }
}
