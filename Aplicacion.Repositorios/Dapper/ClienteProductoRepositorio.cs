using Aplicacion.Models;
using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace Aplicacion.Repositorios.Dapper
{
    public class ClienteProductoRepositorio : IClienteProductoRepositorio
    {
        public string PagarDeuda(ClienteProducto entidad)
        {

            using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("in_recibo", entidad.codigo);
                parameters.Add("in_producto", entidad.producto);
                parameters.Add("in_cliente", entidad.cliente);


                var value = connection.Query<string>("esqmicriservempresa.fn_pagar_deuda", parameters, commandType: CommandType.StoredProcedure);

                connection.BeginTransaction().Commit();
                connection.Close();
                return value.ToString();
            }

        }

        public string PagarRevertir(ClienteProducto entidad)
        {

            using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("in_recibo", entidad.codigo);
                parameters.Add("in_producto", entidad.producto);
                parameters.Add("in_cliente", entidad.cliente);

                var value = connection.Query<string>("esqmicriservempresa.fn_pagar_revertir", parameters, commandType: CommandType.StoredProcedure);
                connection.BeginTransaction().Commit();
                connection.Close();
                return value.ToString();
            }

        }
    }
}
