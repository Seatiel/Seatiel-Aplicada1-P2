using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        [Key]

        public int ClienteId { get; set; }

        public string Nombre { get; set; }

        public int Telefono { get; set; }
        
        public DateTime FechaNacimiento { get; set; }
        
        public double LimiteCredito { get; set; }

        public List<TiposTelefonos> TipoTelefono { get; set; }

        public Clientes()
        {
            this.TipoTelefono = new List<TiposTelefonos>();
        }

        public Clientes(int clienteId, string nombre, double limiteCredito)
        {
            this.ClienteId = clienteId;
            this.Nombre = nombre;
            this.LimiteCredito = limiteCredito;
            this.TipoTelefono = new List<TiposTelefonos>();
        }
    }
}
