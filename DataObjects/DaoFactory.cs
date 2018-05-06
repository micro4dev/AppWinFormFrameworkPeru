namespace DataObjects
{
    public class DaoFactory : IDaoFactory
    {
        public IPerfilDao PerfilDao => new PerfilDao();
        public IClienteDao ClienteDao => new ClienteDao();
        public ReciboDao ReciboDao => new ReciboDao();
    }
}