using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aplicacion.Repositorios.EF
{
    public class UsuarioRepositorioEF : RepositorioEF<Usuario>, IUsuarioRepositorioEF
    {
        public UsuarioRepositorioEF(PGDbContext context) : base(context)
        {

        }

        public Usuario ValidarUsuario(Usuario usuario)
        {
            var resultado = _context.Usuarios.Where(m => m.email == usuario.email && m.password == usuario.password).SingleOrDefault();
            return resultado;

        }
    }
}
