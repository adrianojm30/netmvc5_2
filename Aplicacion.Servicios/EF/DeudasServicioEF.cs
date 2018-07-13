using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
      public class DeudasServicioEF: IDeudasServicioEF
    {
        public DeudasServicioEF(PGDbContext context)
        {
            _deudasEF = new DeudasRepositorioEF(context);
        }
        public IDeudasRepositorioEF _deudasEF { get; private set; }
        public IEnumerable<object> ConsultaDeudas(ClienteBean clienteBean)
        {

            Cliente cliente = new Cliente
            {
                codigo = clienteBean.Codigo,
                empresa = clienteBean.Empresa
            };
            var resultado = _deudasEF.Consultar(cliente);

            return resultado;

        }
    }
}
