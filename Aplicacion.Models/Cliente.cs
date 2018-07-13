

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aplicacion.Models
{
     public class Cliente
    {
        [Key]
        public int codigo { get; set; }
        [ForeignKey("Empresa")]
        
        public virtual int empresa { get; set; }
        
        public virtual Empresa Empresa { get; set; }
        public string nombres { get; set; }
    }
}
