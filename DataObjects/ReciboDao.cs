using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataObjects
{
    public class ReciboDao : IReciboDao
    {
        public void InsertRecibo(Recibo recibo)
        {
            using (var context = new WinFormFrameworkPeruDb())
            {

                context.Recibos.Add(recibo);
                context.SaveChanges();
            }
        }

        public List<Recibo> GetRecibos()
        {
            using (var context = new WinFormFrameworkPeruDb())
            {
                return  context.Recibos.ToList();
            }
        }
    }
}