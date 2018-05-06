using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataObjects
{
    public class ClienteDao : IClienteDao
    {
        public List<Cliente> GetClientes()
        {
            using (var context = new WinFormFrameworkPeruDb())
            {
                return context.Clientes.ToList();
            }
        }
    }
}