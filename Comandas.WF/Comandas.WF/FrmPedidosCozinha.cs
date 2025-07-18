using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comandas.WF.Database;
using Comandas.WF.Models;

namespace Comandas.WF
{
    public partial class FrmPedidosCozinha : Form
    {
        List<PedidoCozinhaItem> itens;
        public FrmPedidosCozinha()
        {
            InitializeComponent();
            CarregarDataGrids();
        }

        private void CarregarDataGrids()
        {
            using (var context = new ComandasDbContext())
            {
                foreach (var pedidoPendente in context.PedidosCozinha.Where(pc => pc.Situacao == 1))
                {
                    itens.Add((PedidoCozinhaItem)context.PedidoCozinhaItems.Where(pci => pci.PedidoCozinhaId == pedidoPendente.Id));
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {

        }


    }
}
