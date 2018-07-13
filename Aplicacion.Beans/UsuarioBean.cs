using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Beans
{
    public class UsuarioBean
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    }
}
