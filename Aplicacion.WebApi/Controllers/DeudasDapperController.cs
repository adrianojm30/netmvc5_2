using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Aplicacion.WebApi.Controllers
{
    [RoutePrefix("DeudasDapper")]
    public class DeudasDapperController : ApiController
    {
        private readonly IDapperUnitOfWork _unit;


        public DeudasDapperController(IDapperUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpPost]
        [Route("PagarDeuda/")]
        public IHttpActionResult PagarDeuda([FromBody]  ClienteProductoBean clienteproducto)
        {
            _unit.ClienteProductoServicios.PagarDeudaDaper(clienteproducto);
            return Ok();
        }
        [HttpPut]
        [Route("PagarRevertir/")]
        public IHttpActionResult PagarRevertir([FromBody]  ClienteProductoBean clienteproducto)
        {

            _unit.ClienteProductoServicios.PagarRevertirDaper(clienteproducto);
            return Ok();
        }

        [HttpGet]
        [Route("ConsultaDeudas/{persona}/{empresa}")]
        public IHttpActionResult ConsultarDeudas(int persona, int empresa)
        {
            ClienteBean clienteBean = new ClienteBean
            {
                Codigo = persona,
                Empresa = empresa
            };
            
            return Ok(_unit.DeudasServicios.ConsultaDeudasFinal(clienteBean));
        }

       
    }
}
