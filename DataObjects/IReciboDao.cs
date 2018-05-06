using System.Collections.Generic;
using BusinessObjects;

namespace DataObjects
{
    public interface IReciboDao
    {
        void InsertRecibo(Recibo recibo);
        List<Recibo> GetRecibos();
    }
}