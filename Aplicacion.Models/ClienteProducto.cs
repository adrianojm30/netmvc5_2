using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Aplicacion.Models
{
     public class ClienteProducto
    {
        [Key]
        public int codigo { get; set; }
        public int cliente { get; set; }
        public int producto { get; set; }
        [ForeignKey("cliente")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("producto")]
        public virtual Producto Producto { get; set; }
        public int monto { get; set; }
        public string estado { get; set; }
    }
}
