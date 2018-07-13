using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios.EF
{
     public interface IUsuarioRepositorioEF
    {
        Usuario ValidarUsuario(Usuario usuario);
    }
}
