using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aplicacion.Models
{
     public class Artefacto
    {

        [Key]
        public int codigo { get; set; }
        public string nombreartefacto { get; set; }
    }
}
