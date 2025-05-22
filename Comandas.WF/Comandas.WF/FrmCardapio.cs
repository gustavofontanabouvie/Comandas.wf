using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comandas.WF
{
    public partial class FrmCardapio : Form
    {
        public FrmCardapio()
        {
            InitializeComponent();
            CarregarItens();
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmPrincipal().Show();
        }
        private void btnAddItemCardapio_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmCardapioCad().Show();
        }
        public void CarregarItens()
        {
            dataGridView1.Rows.Clear();

            foreach (var item in ListaDeItensEstatica.Itens)
            {
                dataGridView1.Rows.Add(item.Id, item.Titulo, item.Descricao, item.Preco, item.PossuiPreparo);
            }
        }
    }
}
