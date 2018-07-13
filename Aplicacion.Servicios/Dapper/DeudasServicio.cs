using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.Dapper
{
     public class DeudasServicio: IDeudasServicio
    {
        static readonly IDeudasRepositorio _deudasDaper = new DeudasRepositorio();

        public IEnumerable<object> ConsultaDeudasFinal(ClienteBean clienteBean)
        {

            Cliente cliente = new Cliente
            {
                codigo = clienteBean.Codigo,
                empresa = clienteBean.Empresa
            };
            var resultado = _deudasDaper.ListDeudas(cliente);

            return resultado;

        }
    }
}
