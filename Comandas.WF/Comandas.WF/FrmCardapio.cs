using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPrincipal().Show();
        }
        private void btnAddItemCardapio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCardapioCad(this).Show();
        }
        public void CarregarItens()
        {
            dataGridView1.Rows.Clear();

            foreach (var item in itens)
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

            dataGridView1.Rows.RemoveAt(rowIndex);

            itens.RemoveAt(rowIndex);
        }

        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = e.RowIndex;
            //linhaSelecionada = dataGridView1.Rows[i];
        }
    }
}
