using System.Collections.Generic;
using System.Linq;
using BusinessObjects;

namespace DataObjects
{
    public class PerfilDao : IPerfilDao
    {
        public void Insertperfil(Perfil perfil)
        {
            using (var context = new WinFormFrameworkPeruDb())
            {

                context.Perfiles.Add(perfil);
                context.SaveChanges();
            }
        }

        public List<Perfil> GetPerfiles()
        {
            using (var context = new WinFormFrameworkPeruDb())
            {
                return context.Perfiles.ToList();
            }
        }
    }
}