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
    public partial class FrmComandaCad : Form
    {
        FrmCardapio _frmCardapio;
        public FrmComandaCad()
        {
            InitializeComponent();
            cbxItens.DataSource = ListarItens();
            cboxMesas.DataSource = ListarMesas();
        }

        private List<int> ListarMesas()
        {
            using (var context = new ComandasDbContext())
            {
                return context.Mesas.ToList().Select(me => me.Numero).ToList();
            }
        }
        private List<String> ListarItens()
        {
            using (var context = new ComandasDbContext())
            {
                return context.CardapioItems.ToList().Select(i => i.Titulo).ToList();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            using (var context = new ComandasDbContext())
            {

                var itemSelecionado = context.CardapioItems.First(ci => ci.Titulo.Equals(cbxItens.Text));

                bool itemJaAdicionado = false;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    if (row.Cells[0].Value != null && row.Cells[0].Value.Equals(itemSelecionado.Titulo))
                    {
                        int quantidadeAtual = Convert.ToInt32(row.Cells[3].Value);
                        row.Cells[3].Value = quantidadeAtual + 1;

                        itemJaAdicionado = true;
                        break;
                    }

                }
                if (!itemJaAdicionado)
                {
                    dataGridView1.Rows.Add(itemSelecionado.Titulo, itemSelecionado.Descricao, itemSelecionado.Preco, 1);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmar");
        }
    }
}
