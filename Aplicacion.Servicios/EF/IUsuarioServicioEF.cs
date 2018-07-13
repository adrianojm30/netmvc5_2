using Aplicacion.Beans;
using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
     public interface IUsuarioServicioEF
    {
        UsuarioBean ValidarUsuario(UsuarioBean usuarioBean);
    }
}
