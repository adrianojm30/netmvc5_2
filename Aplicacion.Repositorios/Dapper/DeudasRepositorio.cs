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
    public class DeudasRepositorio : IDeudasRepositorio
    {
        public IEnumerable<object> ListDeudas(Cliente cl)
        {

            using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("in_persona", cl.codigo);
                parameters.Add("in_empresa", cl.empresa);

                connection.BeginTransaction();

                var resultado = connection.Query<object>("esqmicriservempresa.fn_consulta_deudas", parameters, commandType: CommandType.StoredProcedure);

                connection.Close();
                return resultado;
            }
        }
    }
}
