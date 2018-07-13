using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.EF
{
    public class UsuarioServicioEF: IUsuarioServicioEF
    {
        public UsuarioServicioEF(PGDbContext context)
        {
            
            _usuarioEF = new UsuarioRepositorioEF(context);

        }
       
        public IUsuarioRepositorioEF _usuarioEF { get; private set; }

        public UsuarioBean ValidarUsuario(UsuarioBean usuarioBean)
        {
            Usuario usuario = new Usuario();
            usuario.email = usuarioBean.Email;
            usuario.password = usuarioBean.Password;
            var resultado = _usuarioEF.ValidarUsuario(usuario);
            UsuarioBean usuarioBeanResultado = new UsuarioBean
            {
                Apellidos = resultado.apellidos,
                Email = resultado.email,
                Id = resultado.id,
                Nombres = resultado.nombres,
                Password = resultado.password,
                Roles = resultado.roles
            };
            return usuarioBeanResultado;
        }
    }
}
