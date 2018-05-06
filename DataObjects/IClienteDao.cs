using System.Collections.Generic;
using BusinessObjects;

namespace DataObjects
{
    public interface IClienteDao
    {
        List<Cliente> GetClientes();
    }
}