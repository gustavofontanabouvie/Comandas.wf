using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comandas.WF
{
    public static class ListaDeItensEstatica
    {
        public static List<CardapioItem> Itens { get; set; } = new List<CardapioItem>();
        public static List<Mesa> Mesas { get; set; } = new List<Mesa>();
    }
}
