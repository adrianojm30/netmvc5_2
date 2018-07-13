using Aplicacion.Beans;
using Aplicacion.Models;
using Aplicacion.Repositorios.Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Servicios.Dapper
{
    public class UsuarioServicio: IUsuarioServicio
    {
        static readonly IUsuarioRespositorio _usuarioDapper = new UsuarioRespositorio();
        public UsuarioBean ValidarUsuarioDapper(UsuarioBean usuarioBean)
        {
            Usuario usuario = new Usuario
            {
                email = usuarioBean.Email,
                password = usuarioBean.Password
            };
            var resultado = _usuarioDapper.ValidarUsuario(usuario);
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
