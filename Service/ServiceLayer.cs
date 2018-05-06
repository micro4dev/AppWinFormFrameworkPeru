using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataObjects;

namespace Service
{
    public class ServiceLayer : IService
    {
        static readonly IDaoFactory Factory = DaoFactories.GetFactory();

        static readonly IPerfilDao PerfilDao = Factory.PerfilDao;
        static readonly IClienteDao ClienteDao = Factory.ClienteDao;
        static readonly IReciboDao ReciboDao = Factory.ReciboDao;

        #region Perfil
        public void InsertPerfil(Perfil perfil)
        {
            PerfilDao.Insertperfil(perfil);
        }

        public List<Perfil> GetPerfiles()
        {
            return PerfilDao.GetPerfiles();
        }

        #endregion

        #region Clientes
        public List<Cliente> GetClientes()
        {
            return ClienteDao.GetClientes();
        }
        #endregion

        #region Recibos
        public void InsertRecibo(Recibo recibo)
        {
            ReciboDao.InsertRecibo(recibo);
        }

        public List<Recibo> GetRecibos()
        {
            return ReciboDao.GetRecibos();
        }
        #endregion

    }
}
