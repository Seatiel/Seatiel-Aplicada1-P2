using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class TiposTelefonos
    {
        [Key]

        public int TipoId { get; set; }

        public string Descripcion { get; set; }

        public List<Clientes> Cliente { get; set; }

        public TiposTelefonos()
        {
            this.Cliente = new List<Clientes>();
        }

        public TiposTelefonos(int tipoId, string descripcion)
        {
            this.TipoId = tipoId;
            this.Descripcion = descripcion;
            this.Cliente = new List<Clientes>();
        }
    }
}
