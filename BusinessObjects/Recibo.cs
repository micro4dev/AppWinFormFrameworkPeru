using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Recibo
    {
        public int ReciboId { get; set; }
        public int NUmeroRecibo { get; set; }
        public DateTime FechaRecibo { get; set; }
        public int ClienteId { get; set; }
        public int PerfilId { get; set; }
        public decimal ImportePago { get; set; }


    }
}
