using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.Dapper
{
    public class ClienteProductoServicio : IClienteProductoServicio
    {
        public readonly IClienteProductoRepositorio _clienteDaper = new ClienteProductoRepositorio();

        public void PagarDeudaDaper(ClienteProductoBean clienterproducto)
        {
            ClienteProducto cli = new ClienteProducto
            {
                codigo = clienterproducto.Codigo,
                cliente = clienterproducto.Cliente,
                producto = clienterproducto.Producto

            };

            _clienteDaper.PagarDeuda(cli);
        }

        public void PagarRevertirDaper(ClienteProductoBean clienterproducto)
        {
            ClienteProducto cli = new ClienteProducto
            {
                codigo = clienterproducto.Codigo,
                cliente = clienterproducto.Cliente,
                producto = clienterproducto.Producto

            };

            _clienteDaper.PagarRevertir(cli);
        }
    }
}
