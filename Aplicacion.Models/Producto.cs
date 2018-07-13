using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aplicacion.Models
{
   public class Producto
    {
        [Key]
        public int codigo { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
    }
}
