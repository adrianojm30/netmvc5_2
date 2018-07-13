using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios.Dapper
{
     public  interface IClienteProductoRepositorio
    {
        string PagarDeuda(ClienteProducto entidad);
        string PagarRevertir(ClienteProducto entidad);
    }
}
