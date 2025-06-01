using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.WF.ViewModels
{
    internal class PedidoCozinhaItemModel
    {
        public int Id { get; set; }
        public int PedidoCozinhaId { get; set; }
        public int ComandaItemId { get; set; }
    }
}
