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


namespace Comandas.WF
{
    public partial class FrmCardapio : Form
    {
        public List<CardapioItem> itens = new List<CardapioItem>();


        public FrmCardapio()
        {
            InitializeComponent();
            CarregarItens();
        }
        private void btnAddItemCardapio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCardapioCad().Show();
        }
        public void CarregarItens()
        {
            dataGridView1.Rows.Clear();

            using (var context = new ComandasDbContext())

                foreach (var item in context.CardapioItems)
                {
                    dataGridView1.Rows.Add(item.Id, item.Titulo, item.Descricao, item.Preco, item.PossuiPreparo);
                }
        }

        private void FrmCardapio_Activated(object sender, EventArgs e)
        {
            CarregarItens();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Hide();
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);
            new FrmCardapioEdit(this, id).Show();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);

            using (var context = new ComandasDbContext())
            {
                var cardapio = context.CardapioItems.FirstOrDefault(ci => ci.Id == id);
                context.CardapioItems.Remove(cardapio!);
                context.SaveChanges();
            }
            CarregarItens();
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //linhaSelecionada = dataGridView1.Rows[i];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
