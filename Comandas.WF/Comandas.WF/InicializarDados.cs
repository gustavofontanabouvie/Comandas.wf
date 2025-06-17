using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Comandas.WF.Database;

namespace Comandas.WF
{
    public static class InicializarDados
    {
        public static void SemearBanco(ComandasDbContext dbContext)
        {
            if (!dbContext.Usuarios.Any()) 
            {
                dbContext.Usuarios.Add(new Models.Usuario()
                {
                    Nome = "admin",
                    Email = "admin@admin.com",
                    Senha = "1234"
                });
            }
            dbContext.SaveChanges();
        }
    }
}
