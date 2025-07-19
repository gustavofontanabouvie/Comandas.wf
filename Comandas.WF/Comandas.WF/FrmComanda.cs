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
using Comandas.WF.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Comandas.WF
{
    public partial class FrmComanda : Form
    {

        private List<ComandaItens> comandaItens = [];

        public FrmPrincipalMenu _frmPrincipalMenu;

        public FrmComanda()
        {
            InitializeComponent();
            cbxItens.DataSource = ListarItens();
            cbxItens.DisplayMember = "Titulo";
            cbxItens.ValueMember = "Id";
            PreencherDataGrid();
        }

        private List<CardapioItem> ListarItens()
        {
            using (var context = new ComandasDbContext())
            {
                return context.CardapioItems.ToList();
            }
        }

        private void btnAddComanda_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmPrincipalMenu.AbrirFormNaAba(new FrmComandaCad().ReceberFormPrincipal(_frmPrincipalMenu), _frmPrincipalMenu.tabPgComanda);
        }
        public FrmComanda ReceberFormPrincipal(FrmPrincipalMenu frmMenu)
        {
            _frmPrincipalMenu = frmMenu;
            return this;
        }

        private void PreencherDataGrid()
        {
            dataGridViewComandas.Rows.Clear();

            using (var context = new ComandasDbContext())
            {
                foreach (var comanda in context.Comandas.Where(co => co.SituacaoComanda == true))
                {
                    dataGridViewComandas.Rows.Add(comanda.NumeroMesa, comanda.NomeCliente, comanda.Id);
                }
            }

        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewComandas.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridViewComandas.Rows[rowIndex].Cells[2].Value);

            using (var context = new ComandasDbContext())
            {
                var comanda = context.Comandas.FirstOrDefault(ci => ci.Id == id);
                comanda.SituacaoComanda = false;

                var mesa = context.Mesas.First(me => me.Numero == comanda!.NumeroMesa);
                mesa.Cliente = "sem cliente";
                mesa.SituacaoMesa = false;


                context.Comandas.Update(comanda!);
                context.SaveChanges();
            }
            PreencherDataGrid();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            materialCardMiddle.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            materialCardMiddle.Visible = false;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            using (var context = new ComandasDbContext())
            {
                var itemSelecionado = context.CardapioItems.First(ci => ci.Titulo.Equals(cbxItens.Text));
                bool itemJaAdicionado = false;

                foreach (DataGridViewRow row in dataGridViewItens.Rows)
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
                    dataGridViewItens.Rows.Add(itemSelecionado.Titulo, itemSelecionado.Descricao, itemSelecionado.Preco, 1);
                    comandaItens.Add(new ComandaItens
                    {
                        CardapioItemId = itemSelecionado.Id
                    });
                }
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EditarComanda();
        }

        private void EditarComanda()
        {
            Mesa mesaSelecionada;
            Comanda comanda;

            int rowIndex = dataGridViewComandas.CurrentCell.RowIndex;
            int numeroMesa = Convert.ToInt32(dataGridViewComandas.Rows[rowIndex].Cells[0].Value);


            using (var context = new ComandasDbContext())
            {
                mesaSelecionada = context.Mesas.First(me => me.Numero == numeroMesa);

                comanda = context.Comandas.First(co => co.NumeroMesa == mesaSelecionada.Numero);
            }

            var pedidoCozinha = new PedidoCozinha()
            {
                Comanda = comanda,
                Situacao = 1
            };

            List<ComandaItens> itensComPreparo = [];
            List<ComandaItens> itensAInserir = [];
            foreach (var item in comandaItens)
            {
                itensAInserir.Add(new ComandaItens
                {
                    Comanda = comanda,
                    CardapioItemId = item.CardapioItemId
                });

                if (item.CardapioItem != null && item.CardapioItem.PossuiPreparo)
                {
                    itensComPreparo.Add(new ComandaItens
                    {
                        CardapioItemId = item.CardapioItemId,
                        Comanda = comanda
                    });
                }
            }

            using (var context = new ComandasDbContext())
            {

                context.ComandaItens.AddRange(itensAInserir);
                context.Update(comanda);
                context.PedidosCozinha.Add(pedidoCozinha);
                context.SaveChanges();
            }
            List<PedidoCozinhaItem> pedidoCozinhaItens = [];
            using (var context = new ComandasDbContext())
            {
                var itensSalvos = context.ComandaItens.Where(ci => ci.Id == comanda.Id).Include(ci => ci.CardapioItem).ToList();
                foreach (var item in itensSalvos)
                {
                    if (item.CardapioItem != null && item.CardapioItem.PossuiPreparo)
                    {
                        pedidoCozinhaItens.Add(new PedidoCozinhaItem
                        {
                            ComandaItemId = item.Id.Value,
                            PedidoCozinhaId = pedidoCozinha.Id
                        });
                    }
                }

                context.PedidoCozinhaItems.AddRange(pedidoCozinhaItens);
                context.SaveChanges();
            }

            PreencherDataGrid();
            dataGridViewItens.Rows.Clear();
        }
    }
}
