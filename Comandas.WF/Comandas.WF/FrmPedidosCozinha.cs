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
using Microsoft.EntityFrameworkCore;

namespace Comandas.WF
{
    public partial class FrmPedidosCozinha : Form
    {
        List<PedidoCozinhaItem> itens;
        int pendenteId = 0;
        int emAndamentoID = 0;
        int finalizadosID = 0;

        public FrmPedidosCozinha()
        {
            InitializeComponent();
            CarregarDataGridPendentes();
            CarregarDataGridEmAndamento();
            CarregarDataGridFinalizado();
        }

        private void CarregarDataGridFinalizado()
        {
            dataGridViewFinalizados.Rows.Clear();
            using (var context = new ComandasDbContext())
            {
                var itensFinalizados = context.PedidoCozinhaItems
                    .Include(pci => pci.PedidoCozinha)
                        .ThenInclude(pc => pc.Comanda)
                            .ThenInclude(c => c.ComandaItens)
                                .ThenInclude(ci => ci.CardapioItem)
                    .Where(pci => pci.PedidoCozinha.Situacao == 3)
                    .Where(pc => pc.PedidoCozinha.Comanda.SituacaoComanda).ToList();

                foreach (var item in itensFinalizados)
                {
                    var comanda = item.PedidoCozinha.Comanda;
                    var cardapioItem = item.ComandaItem.CardapioItem;

                    if (cardapioItem.PossuiPreparo)
                    {
                        dataGridViewFinalizados.Rows.Add(comanda.NumeroMesa.ToString(), comanda.NomeCliente, cardapioItem.Titulo, item.PedidoCozinha.Id);
                    }
                }
            }
        }

        private void CarregarDataGridEmAndamento()
        {
            dataGridViewAndamento.Rows.Clear();
            using (var context = new ComandasDbContext())
            {
                var itensAndamento = context.PedidoCozinhaItems
                    .Include(pci => pci.PedidoCozinha)
                        .ThenInclude(pc => pc.Comanda)
                            .ThenInclude(c => c.ComandaItens)
                                .ThenInclude(ci => ci.CardapioItem)
                    .Where(pci => pci.PedidoCozinha.Situacao == 2)
                    .Where(pc => pc.PedidoCozinha.Comanda.SituacaoComanda).ToList();

                foreach (var item in itensAndamento)
                {
                    var comanda = item.PedidoCozinha.Comanda;
                    var cardapioItem = item.ComandaItem.CardapioItem;

                    if (cardapioItem.PossuiPreparo)
                    {
                        dataGridViewAndamento.Rows.Add(comanda.NumeroMesa.ToString(), comanda.NomeCliente, cardapioItem.Titulo, item.PedidoCozinha.Id);
                    }
                }
            }
        }

        private void CarregarDataGridPendentes()
        {
            dataGridViewPendentes.DataSource = null;
            dataGridViewPendentes.Rows.Clear();
            using (var context = new ComandasDbContext())
            {
                var itensPendentes2 = (from pedidoCozinhaItem in context.PedidoCozinhaItems
                                       join pedidoCozinha in context.PedidosCozinha
                                       on pedidoCozinhaItem.PedidoCozinhaId equals pedidoCozinha.Id
                                       join comanda in context.Comandas
                                       on pedidoCozinha.ComandaId equals comanda.Id
                                       join comandaItens in context.ComandaItens
                                       on comanda.Id equals comandaItens.ComandaId
                                       join cardapioItem in context.CardapioItems
                                       on comandaItens.CardapioItemId equals cardapioItem.Id
                                       where pedidoCozinha.Situacao == 1
                                       && comanda.SituacaoComanda
                                       && cardapioItem.PossuiPreparo
                                       select new
                                       {
                                           comanda.NumeroMesa,
                                           comanda.NomeCliente,
                                           cardapioItem.Titulo,
                                           pedidoCozinha.Id
                                       }).ToList();



                //var itensPendentes = context.PedidoCozinhaItems
                //    .Include(pci => pci.PedidoCozinha)
                //        .ThenInclude(pc => pc.Comanda)
                //            .ThenInclude(c => c.ComandaItens)
                //                .ThenInclude(ci => ci.CardapioItem)
                //    .Where(pci => pci.PedidoCozinha.Situacao == 1)
                //    .Where(pc => pc.PedidoCozinha.Comanda.SituacaoComanda).ToList();

                foreach (var item in itensPendentes2)
                {
                    ////var comanda = item.PedidoCozinha.Comanda;
                    //var cardapioItem = item.ComandaItem.CardapioItem;

                    //if (cardapioItem.PossuiPreparo)
                    //{

                    dataGridViewPendentes.Rows.Add(item.NumeroMesa.ToString(), item.NomeCliente, item.Titulo, item.Id);

                }
            }
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            using (var context = new ComandasDbContext())
            {
                if (pendenteId > 0)
                {
                    MessageBox.Show("pedido ja esta pendente");
                }
                if (emAndamentoID > 0)
                {
                    var pedidoCozinha = context.PedidosCozinha.First(pc => pc.Id == emAndamentoID);

                    pedidoCozinha.Situacao = 1;

                    context.Update(pedidoCozinha);
                }
                if (finalizadosID > 0)
                {
                    var pedidoCozinha = context.PedidosCozinha.First(pc => pc.Id == finalizadosID);

                    pedidoCozinha.Situacao = 2;

                    context.Update(pedidoCozinha);

                }
                context.SaveChanges();
            }
            CarregarDataGridPendentes();
            CarregarDataGridEmAndamento();
            CarregarDataGridFinalizado();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            using (var context = new ComandasDbContext())
            {
                if (pendenteId > 0)
                {
                    var pedidoCozinha = context.PedidosCozinha.First(pc => pc.Id == pendenteId);

                    pedidoCozinha.Situacao = 2;

                    context.Update(pedidoCozinha);
                }
                if (emAndamentoID > 0)
                {
                    var pedidoCozinha = context.PedidosCozinha.First(pc => pc.Id == emAndamentoID);

                    pedidoCozinha.Situacao = 3;

                    context.Update(pedidoCozinha);
                }
                if (finalizadosID > 0)
                {
                    var pedidoCozinha = context.PedidosCozinha.First(pc => pc.Id == finalizadosID);

                    pedidoCozinha.Situacao = 4;

                    context.Update(pedidoCozinha);

                }
                context.SaveChanges();
            }
            CarregarDataGridPendentes();
            CarregarDataGridEmAndamento();
            CarregarDataGridFinalizado();
        }

        private void dataGridViewPendentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                pendenteId = Convert.ToInt32(dataGridViewPendentes.Rows[e.RowIndex].Cells[3].Value);
                emAndamentoID = 0;
                finalizadosID = 0;
            }

        }

        private void dataGridViewAndamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewAndamento.SelectedRows.Count > 0)
            {
                emAndamentoID = Convert.ToInt32(dataGridViewAndamento.Rows[e.RowIndex].Cells[3].Value);
                pendenteId = 0;
                finalizadosID = 0;
            }
        }

        private void dataGridViewFinalizados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFinalizados.SelectedRows.Count > 0)
            {
                finalizadosID = Convert.ToInt32(dataGridViewFinalizados.Rows[e.RowIndex].Cells[3].Value);
                pendenteId = 0;
                emAndamentoID = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CarregarDataGridPendentes();
            CarregarDataGridEmAndamento();
            CarregarDataGridFinalizado();
        }
    }
}
