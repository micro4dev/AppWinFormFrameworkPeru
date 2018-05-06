using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObjects;
using ComponentFactory.Krypton.Toolkit;
using Service;

namespace WinFormApp
{
    public partial class ReciboFrm : KryptonForm
    {
        IService _service = new ServiceLayer();
        public ReciboFrm()
        {
            InitializeComponent();
        }

        private void ReciboFrm_Load(object sender, EventArgs e)
        {
            CargarReferencias();

        }

        private void CargarReferencias()
        {
            List<Cliente> clientes = _service.GetClientes();
            iClienteId.DataSource = clientes;
            iClienteId.DisplayMember = "NombreCliente";
            iClienteId.ValueMember = "ClienteId";
            


        }
    }
}
