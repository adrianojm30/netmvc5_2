using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Beans
{
     public class ClienteProductoBean
    {
        public int Cliente { get; set; }
        public int Codigo { get; set; }
        public int Producto { get; set; }
        public int Monto { get; set; }
        public string Estado { get; set; }
    }
}
