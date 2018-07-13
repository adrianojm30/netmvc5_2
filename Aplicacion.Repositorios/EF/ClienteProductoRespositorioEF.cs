using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Aplicacion.Repositorios.EF
{
    public class ClienteProductoRespositorioEF : RepositorioEF<ClienteProducto>, IClienteProductoRespositorioEF
    {

        public ClienteProductoRespositorioEF(PGDbContext context) : base(context)
        {

        }
        public void PagarDeuda(ClienteProducto entidad)
        {
            //,entidad.cliente,entidad.producto
            var resultado = _context.ClientesProductos.Where(m => m.codigo == entidad.codigo && m.cliente == entidad.cliente && m.producto == entidad.producto).SingleOrDefault();
            if (resultado == null)
            {
                return;
            }

            resultado.estado = "1";
            _context.Entry(resultado).State = EntityState.Detached;
            _context.Entry(resultado).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void PagarRevertir(ClienteProducto entidad)
        {
            var resultado = _context.ClientesProductos.Where(m => m.codigo == entidad.codigo && m.cliente == entidad.cliente && m.producto == entidad.producto).SingleOrDefault();
            if (resultado == null)
            {
                return;
            }
            resultado.estado = "0";
            _context.Entry(resultado).State = EntityState.Detached;
            _context.Entry(resultado).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
