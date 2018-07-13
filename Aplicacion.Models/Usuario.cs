using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aplicacion.Models
{
     public class Usuario
    {
        [Key]
        public int id { get; set; }
        public string email { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string password { get; set; }
        public string roles { get; set; }
    }
}
