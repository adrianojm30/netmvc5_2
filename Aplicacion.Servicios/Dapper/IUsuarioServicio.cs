using Aplicacion.Beans;
using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.Dapper
{
    public interface IUsuarioServicio
    {
        UsuarioBean ValidarUsuarioDapper(UsuarioBean usuarioBean);
    }
}
