using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TelefonoContactoCliente { get; set; }
        public bool ClienteActivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaDePago { get; set; }
        public string Observacion { get; set; }

    }
}
