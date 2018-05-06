using System.Collections.Generic;
using BusinessObjects;

namespace DataObjects
{
    public interface IPerfilDao
    {
        void Insertperfil(Perfil perfil);

        List<Perfil> GetPerfiles();
    }
}