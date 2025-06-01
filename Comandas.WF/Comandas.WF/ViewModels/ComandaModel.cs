using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.WF.ViewModels
{
    internal class ComandaModel
    {
        public int Id{ get; set; }
        public int NumeroMesa { get; set; }
        public string NomeCliente { get; set; }
        public bool SituacaoComanda{ get; set; }

    }
}
