using Aplicacion.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion.Repositorios.EF
{
    public class ClienteRepositorioEF : RepositorioEF<Cliente>, IClienteRepositorioEF
    {
        public ClienteRepositorioEF(PGDbContext context) : base(context)
        {

        }

    }
}
