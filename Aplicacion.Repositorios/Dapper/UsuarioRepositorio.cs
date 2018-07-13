using Aplicacion.Models;
using Npgsql;
using Dapper;
using System.Configuration;
namespace Aplicacion.Repositorios.Dapper
{
    public class UsuarioRespositorio : IUsuarioRespositorio
    {


        public Usuario ValidarUsuario(Usuario usuario)
        {
            using (var connection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("v_email", usuario.email);
                parameters.Add("v_password", usuario.password);
                connection.BeginTransaction();
                var valor = connection.QueryFirst<Usuario>("esqmicriservempresa.fn_validar_usuario", parameters,
                    commandType: System.Data.CommandType.StoredProcedure);
                connection.Close();
                return valor;
            }
        }

    }
}
