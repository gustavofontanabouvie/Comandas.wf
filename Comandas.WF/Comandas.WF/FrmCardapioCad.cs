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
using MaterialSkin.Controls;

namespace Comandas.WF
{
    public partial class FrmCardapioCad : MaterialForm
    {
        public FrmPrincipalMenu frmMenu;

        public FrmCardapioCad()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtTitulo.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            ckboxPreparo.Checked = false;
        }
        public FrmCardapioCad ReceberFormPrincipal(FrmPrincipalMenu frm)
        {
            frmMenu = frm;
            return this;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

            frmMenu.AbrirFormNaAba(new FrmCardapio().ReceberFormPrincipal(frmMenu), frmMenu.tabPgCardapio);
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

            using (var context = new ComandasDbContext())
            {
                context.Add(novoItem);
                context.SaveChanges();
            }

            LimparCampos();
        }
    }
}
