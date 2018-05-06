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

            List<Perfil> perfiles = _service.GetPerfiles();
            iPerfilId.DataSource = perfiles;
            iPerfilId.DisplayMember = "DescripcionPerfil";
            iPerfilId.ValueMember = "PerfilId";

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (!DatosValidos())
            {
                return;
            }

            Recibo recibo = new Recibo();
            recibo.NumeroRecibo = Convert.ToInt32(iNumerorecibo.Text);
            recibo.FechaRecibo = iFecharecibo.Value;
            recibo.ClienteId = (int)iClienteId.SelectedValue;
            recibo.PerfilId = (int) iPerfilId.SelectedValue;
            recibo.ImportePago = Convert.ToInt32(iImporte.Text);

            _service.InsertRecibo(recibo);

            if (recibo.ReciboId > 0)
            {
                KryptonMessageBox.Show("Recibo grabado con exito",Text,MessageBoxButtons.OK,MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private bool DatosValidos()
        {
            if (iNumerorecibo.Text.Trim().Equals("0") || string.IsNullOrEmpty(iNumerorecibo.Text.Trim()))
            {
                KryptonMessageBox.Show("Ingrese N° recibo","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                iNumerorecibo.Select();
                return false;
            }

            if (iClienteId.SelectedIndex == -1)
            {
                KryptonMessageBox.Show("Seleccione el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                iClienteId.Select();
                return false;
            }

            if (iPerfilId.SelectedIndex == -1)
            {
                KryptonMessageBox.Show("Seleccione el perfil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                iPerfilId.Select();
                return false;
            }

            if (iImporte.Text.Trim().Equals("0") || string.IsNullOrEmpty(iImporte.Text.Trim()))
            {
                KryptonMessageBox.Show("Ingrese el importe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                iImporte.Select();
                return false;
            }

            return true;

        }

        private void Limpiar()
        {
            iNumerorecibo.Text = "0";
            iFecharecibo.Value = DateTime.Now;
            iClienteId.SelectedIndex = -1;
            iPerfilId.SelectedIndex = -1;
            iImporte.Text = "0";
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            CargarRecibos();
        }

        private void CargarRecibos()
        {
            List<Recibo> Recibos = _service.GetRecibos();
            dgvRecibos.DataSource = Recibos;
        }
    }
}
