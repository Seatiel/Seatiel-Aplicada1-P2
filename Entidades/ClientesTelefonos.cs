using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class ClientesTelefonos
    {
        public int Id { get; set; }

        public int ClientesId { get; set; }

        public int TiposClientes { get; set; }

    }
}
