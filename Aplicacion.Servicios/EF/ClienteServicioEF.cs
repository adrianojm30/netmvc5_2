using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
    public class ClienteServicioEF: IClienteServicioEF
    {
        public ClienteServicioEF(PGDbContext context)
        {
            _clienteEF = new ClienteRepositorioEF(context);
        }
        public IClienteRepositorioEF _clienteEF { get; private set; }
        public List<ClienteBean> ObtenerCliente()
        {
            var resultado = _clienteEF.GetAll();
            List<ClienteBean> lista = new List<ClienteBean>();
            foreach (Cliente cliente in resultado)
            {
                ClienteBean clientebean = new ClienteBean();
                clientebean.Codigo = cliente.codigo;
                clientebean.Empresa = cliente.empresa;
                clientebean.Nombres = cliente.nombres;
                lista.Add(clientebean);
            }
            return lista;
        }
        public int GuardarCliente(ClienteBean clienteBean)
        {
            Cliente cliente = new Cliente
            {
              
               empresa=clienteBean.Empresa,
               nombres=clienteBean.Nombres
            };

            int id = _clienteEF.Insert(cliente);

            return id;
        }
        public bool ActualizarCliente(ClienteBean clienteBean)
        {
            Cliente cliente = new Cliente
            {
                codigo=clienteBean.Codigo,
                empresa=clienteBean.Empresa,
                nombres=clienteBean.Nombres
            };

            bool respuesta = _clienteEF.Update(cliente);

            return respuesta;
        }
        public ClienteBean ObtenerClientePorId(int id)
        {
            Cliente cliente = _clienteEF.GetEntityById(id);
            ClienteBean clienteBean = new ClienteBean
            {
                Codigo = cliente.codigo,
                Empresa = cliente.empresa,
                Nombres = cliente.nombres
            };
            return clienteBean;
        }

        public bool EliminarCliente(ClienteBean clienteBean)
        {
            Cliente cliente = new Cliente
            {
                codigo = clienteBean.Codigo
            };
            bool resultado = _clienteEF.Delete(cliente);
            return resultado;
        }
    }
}
