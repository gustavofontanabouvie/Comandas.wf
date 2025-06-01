using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.WF.ViewModels
{
    public class CardapioItemModels

    {
        public int Id{ get; set; }

        public string Titulo { get; set; }

        public string Descricao{ get; set; }

        public double Preco { get; set; }

        public bool PossuiPreparo{ get; set; }

    }
}
