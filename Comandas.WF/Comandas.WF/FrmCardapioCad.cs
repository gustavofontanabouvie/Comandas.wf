using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comandas.WF.ViewModels;

namespace Comandas.WF
{
    public partial class FrmCardapioCad : Form
    {
        FrmCardapio _frmCardapio;
        public FrmCardapioCad(FrmCardapio frmCardapio)
        {
            _frmCardapio = frmCardapio;
            InitializeComponent();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
          _frmCardapio.Show();
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CardapioItem novoItem = new CardapioItem();

            novoItem.Titulo = txtTitulo.Text;
            novoItem.Descricao = txtDescricao.Text;

            if (double.TryParse(txtPreco.Text, out double preco))
            {
                novoItem.Preco = preco;
            }
            else
            {
                txtPreco.Clear();
                txtPreco.Focus();
                MessageBox.Show("Valor inválido para o preço.");
                return;
            }
            novoItem.PossuiPreparo = ckboxPreparo.Checked;

            if (_frmCardapio.itens.Count == 0)
            { novoItem.Id = 1;
            }
            else
            {
                int maxId = _frmCardapio.itens.Max(item => item.Id);
                novoItem.Id = maxId + 1;
            }
                //ListaDeItensEstatica.Itens.Add(novoItem);
            _frmCardapio.itens.Add(novoItem);
            LimparCampos();
        }
        private void LimparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            ckboxPreparo.Checked = false;
        }
       
    }
}
