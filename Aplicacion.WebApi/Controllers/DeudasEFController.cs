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
    [RoutePrefix("DeudasEF")]
    public class DeudasEFController : ApiController
    {
        protected readonly IEFUnitOfWork _unit;
        public DeudasEFController(IEFUnitOfWork unit)
        {
            _unit = unit;
        }

        [HttpGet]
        [Route("ObtenerClientes/")]
        public IHttpActionResult ObtenerClientes()
        {
            return Ok(_unit.ClienteServicioEF.ObtenerCliente());
        }

        [HttpPost]
        [Route("GuardarClientes/")]
        public IHttpActionResult GuardarClientes([FromBody] ClienteBean clienteBean)
        {
            return Ok(_unit.ClienteServicioEF.GuardarCliente(clienteBean));
        }
        [HttpPut]
        [Route("ActualizarClientes")]
        public IHttpActionResult ActualizarProducto([FromBody] ClienteBean clienteBean)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);
            if (!_unit.ClienteServicioEF.ActualizarCliente(clienteBean)) return BadRequest("Incorrect id");
            return Ok(new { status = true });
        }
        [HttpGet]
        [Route("ObtenerClientePorId/{id}")]
        public IHttpActionResult ObtenerClientePorId(int id)
        {

            if (id <= 0) return BadRequest();
            return Ok(_unit.ClienteServicioEF.ObtenerClientePorId(id));
        }
        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult Delete(int id)
        {
            if (id <= 0) return BadRequest();
            var result = _unit.ClienteServicioEF.EliminarCliente(new ClienteBean { Codigo = id });
            return Ok(new { delete = true });
        }
        //agregamos
        [HttpGet]
        [Route("ConsultaDeuda/{persona}/{empresa}")]
        public IHttpActionResult ConsultaDeuda(int persona, int empresa)
        {
            ClienteBean obj = new ClienteBean
            {
                Codigo = persona,
                Empresa = empresa
            };

            return Ok(_unit.DeudasServicioEF.ConsultaDeudas(obj));
        }

        [HttpPost]
        [Route("PagarRevertir/")]
        public IHttpActionResult PagarRevertir([FromBody]  ClienteProductoBean clienteproducto)
        {

            _unit.ClienteProductoServicioEF.PagarRevertir(clienteproducto);
            return Ok();
        }
        [HttpGet]
        [Route("obtener/")]
        public IHttpActionResult ObtenerTodo()
        {


            return Ok(_unit.ClienteProductoServicioEF.ListaClienteProducto());
        }
        [HttpPost]
        [Route("PagarDeuda/")]
        public IHttpActionResult PagarDeuda([FromBody]  ClienteProductoBean clienteproducto)
        {
            _unit.ClienteProductoServicioEF.PagarDeuda(clienteproducto);
            return Ok();
        }

        
    }
}
