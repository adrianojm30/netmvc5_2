using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
    public class ClienteProductoServicioEF: IClienteProductoServicioEF
    {
        public ClienteProductoServicioEF(PGDbContext context)
        {
            _clienteProductoEF = new ClienteProductoRespositorioEF(context);
        }
        public IClienteProductoRespositorioEF _clienteProductoEF { get; private set; }

        public List<ClienteProductoBean> ListaClienteProducto()
        {
            var resultado = _clienteProductoEF.GetAll();
            List<ClienteProductoBean> lista = new List<ClienteProductoBean>();

            foreach (ClienteProducto clienteproducto in resultado)
            {
                ClienteProductoBean clienteproductobean = new ClienteProductoBean();
                clienteproductobean.Cliente = clienteproducto.cliente;
                clienteproductobean.Codigo = clienteproducto.codigo;
                clienteproductobean.Estado = clienteproducto.estado;
                clienteproductobean.Monto = clienteproducto.monto;
                clienteproductobean.Producto = clienteproducto.producto;
                lista.Add(clienteproductobean);
            }
            return lista;
        }

        public void PagarDeuda(ClienteProductoBean clienterproducto)
        {
            ClienteProducto cli = new ClienteProducto
            {
                codigo = clienterproducto.Codigo,
                cliente = clienterproducto.Cliente,
                producto = clienterproducto.Producto

            };

            _clienteProductoEF.PagarDeuda(cli);
        }

        public void PagarRevertir(ClienteProductoBean clienterproducto)
        {
            ClienteProducto cli = new ClienteProducto
            {
                codigo = clienterproducto.Codigo,
                cliente = clienterproducto.Cliente,
                producto = clienterproducto.Producto

            };

            _clienteProductoEF.PagarRevertir(cli);
        }
    }
}
