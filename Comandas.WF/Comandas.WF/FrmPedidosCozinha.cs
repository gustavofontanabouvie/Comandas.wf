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
                var pedidosFinalizados = context.PedidosCozinha.Where(pc => pc.Comanda.SituacaoComanda).Include(c => c.Comanda).ThenInclude(ci => ci.ComandaItens).ThenInclude(cai => cai.CardapioItem).Where(pc => pc.Situacao == 3).ToList();
                foreach (var pedidoFinalizado in pedidosFinalizados)
                {
                    foreach (var item in pedidoFinalizado.Comanda.ComandaItens)
                    {
                        dataGridViewFinalizados.Rows.Add(pedidoFinalizado.Comanda.NumeroMesa.ToString(), pedidoFinalizado.Comanda.NomeCliente, item.CardapioItem.Titulo, pedidoFinalizado.Id.ToString());
                    }
                }
            }
        }

        private void CarregarDataGridEmAndamento()
        {
            dataGridViewAndamento.Rows.Clear();
            using (var context = new ComandasDbContext())
            {
                var pedidosEmAndamento = context.PedidosCozinha.Where(pc => pc.Comanda.SituacaoComanda).Include(c => c.Comanda).ThenInclude(ci => ci.ComandaItens).ThenInclude(cai => cai.CardapioItem).Where(pc => pc.Situacao == 2).ToList();
                foreach (var pedidoEmAndamento in pedidosEmAndamento)
                {
                    foreach (var item in pedidoEmAndamento.Comanda.ComandaItens)
                    {
                        dataGridViewAndamento.Rows.Add(pedidoEmAndamento.Comanda.NumeroMesa.ToString(), pedidoEmAndamento.Comanda.NomeCliente, item.CardapioItem.Titulo, pedidoEmAndamento.Id.ToString());
                    }
                }
            }
        }

        private void CarregarDataGridPendentes()
        {
            dataGridViewPendentes.Rows.Clear();
            using (var context = new ComandasDbContext())
            {
                var pedidoPendentes = context.PedidosCozinha.Where(pc => pc.Comanda.SituacaoComanda).Include(pc => pc.Comanda).ThenInclude(ci => ci.ComandaItens).ThenInclude(cai => cai.CardapioItem).Where(pc => pc.Situacao == 1).ToList();

                foreach (var pedidoPendente in pedidoPendentes)
                {
                    foreach (var item in pedidoPendente.Comanda.ComandaItens)
                    {
                        dataGridViewPendentes.Rows.Add(pedidoPendente.Comanda.NumeroMesa.ToString(), pedidoPendente.Comanda.NomeCliente, item.CardapioItem.Titulo, pedidoPendente.Id.ToString());
                    }
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

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
                emAndamentoID = Convert.ToInt32(dataGridViewAndamento.SelectedRows[0].Cells[3]);
                pendenteId = 0;
                finalizadosID = 0;
            }
        }

        private void dataGridViewFinalizados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFinalizados.SelectedRows.Count > 0)
            {
                finalizadosID = Convert.ToInt32(dataGridViewFinalizados.SelectedRows[0].Cells[3]);
                pendenteId = 0;
                emAndamentoID = 0;
            }
        }
    }
}
