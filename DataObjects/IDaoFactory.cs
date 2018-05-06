namespace DataObjects
{
    public interface IDaoFactory
    {
        IPerfilDao PerfilDao { get; }
        IClienteDao ClienteDao { get; }
        ReciboDao ReciboDao { get; }
    }
}