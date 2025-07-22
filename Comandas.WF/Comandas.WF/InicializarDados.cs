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
            if (!dbContext.CardapioItems.Any())
            {
                dbContext.CardapioItems.Add(new Models.CardapioItem()
                {
                    Titulo = "pizza",
                    Descricao = "pizza com 4 sabores",
                    Preco = 50,
                    PossuiPreparo = true
                });
                dbContext.CardapioItems.Add(new Models.CardapioItem()
                {
                    Titulo = "coca 600",
                    Descricao = "coca 600ml garrrafa",
                    Preco = 5,
                    PossuiPreparo = false
                });
            }
            dbContext.SaveChanges();
        }
    }
}
