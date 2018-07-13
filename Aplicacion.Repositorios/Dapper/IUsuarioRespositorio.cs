using System;
using System.Collections.Generic;
using System.Text;
using Aplicacion.Models;
namespace Aplicacion.Repositorios.Dapper
{
    public interface IUsuarioRespositorio
    {
        Usuario ValidarUsuario(Usuario usuario);
    }
}
