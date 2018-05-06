using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class Perfil
    {
        public int PerfilId { get; set; }
        public string DescripcionPerfil { get; set; }
        public decimal VelocidadDescarga { get; set; }
        public decimal VelocidadSubida { get; set; }
        public decimal TarifaPerfil { get; set; }

    }
}
