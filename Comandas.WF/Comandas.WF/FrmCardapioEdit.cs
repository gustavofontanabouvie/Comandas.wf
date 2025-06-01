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
    public partial class FrmCardapioEdit : Form
    {
        FrmCardapio _frmCardapio;
        int _itemId;
        public FrmCardapioEdit(FrmCardapio frmCardapio, int id)
        {
            _itemId = id;
            _frmCardapio = frmCardapio;
            InitializeComponent();
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            txtTitulo.Text = _frmCardapio.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDescricao.Text = _frmCardapio.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPreco.Text = _frmCardapio.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            ckboxPreparo.Checked = Convert.ToBoolean(_frmCardapio.dataGridView1.CurrentRow.Cells[4].Value);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _frmCardapio.Show();
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int posicaoDoItem = _frmCardapio.itens.FindIndex(index => index.Id == _itemId);

            if(posicaoDoItem >= 0)
            {
                _frmCardapio.itens[posicaoDoItem].Titulo = txtTitulo.Text;
                _frmCardapio.itens[posicaoDoItem].Descricao = txtDescricao.Text;
                _frmCardapio.itens[posicaoDoItem].Preco = Convert.ToDouble(txtPreco.Text);
                _frmCardapio.itens[posicaoDoItem].PossuiPreparo = ckboxPreparo.Checked;
            }
            else
            {
                MessageBox.Show("Item não encontrado.");
            }

            this.Close();
            _frmCardapio.Show();
        }
    }
}
