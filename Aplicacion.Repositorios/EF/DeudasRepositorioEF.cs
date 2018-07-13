using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Aplicacion.Repositorios.EF
{
    public class DeudasRepositorioEF : IDeudasRepositorioEF
    {
        PGDbContext _context;
        public DeudasRepositorioEF(PGDbContext context)
        {
            _context = context;
        }

        public IEnumerable<object> Consultar(Cliente cl)
        {
            var resultado = (from cliente in _context.Clientes
                             join clienteproducto in _context.ClientesProductos on cliente.codigo equals clienteproducto.cliente
                             join producto in _context.Productos on clienteproducto.producto equals producto.codigo
                             where cliente.codigo == cl.codigo && cliente.empresa == cl.empresa

                             select new
                             {
                                 cliente = cliente.codigo,
                                 cliente.nombres,
                                 producto = producto.codigo,
                                 producto.descripcion,
                                 producto.precio,
                                 recibo = clienteproducto.codigo,
                                 deuda = clienteproducto.monto,
                                 clienteproducto.estado
                             });

            return resultado.ToList();
        }
    }
}
