using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Service
{
    public interface IService
    {
        #region Perfil
        void InsertPerfil(Perfil perfil);
        List<Perfil> GetPerfiles();

        #endregion

        #region Cliente
        List<Cliente> GetClientes();
        #endregion

        #region Recibo
        void InsertRecibo(Recibo recibo);

        List<Recibo> GetRecibos();
        #endregion

    }
}
