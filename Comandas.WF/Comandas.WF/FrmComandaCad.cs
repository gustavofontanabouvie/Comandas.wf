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
        public FrmPrincipalMenu _frmPrincipalMenu;

        private List<ComandaItens> comandaItens = [];
        public FrmComandaCad()
        {
            InitializeComponent();
            cbxItens.DataSource = ListarItens();
            cbxItens.DisplayMember = "Titulo";
            cbxItens.ValueMember = "Id";

            cboxMesas.DataSource = ListarMesas();
            cboxMesas.DisplayMember = "Numero";
            cboxMesas.ValueMember = "Numero";
            cboxMesas.SelectedIndex = -1;
        }
        public FrmComandaCad ReceberFormPrincipal(FrmPrincipalMenu frmMenu)
        {
            _frmPrincipalMenu = frmMenu;
            return this;
        }
        private List<Mesa> ListarMesas()
        {
            using (var context = new ComandasDbContext())
            {
                return context.Mesas.ToList();
            }
        }
        private List<CardapioItem> ListarItens()
        {
            using (var context = new ComandasDbContext())
            {
                return context.CardapioItems.ToList();
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
                    comandaItens.Add(new ComandaItens
                    {
                        CardapioItemId = itemSelecionado.Id
                    });
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            _frmPrincipalMenu.AbrirFormNaAba(new FrmComanda().ReceberFormPrincipal(_frmPrincipalMenu), _frmPrincipalMenu.tabPgComanda);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            InserirComanda();
        }

        private void InserirComanda()
        {
            bool camposValidados = ValidarCampos();
            if (!camposValidados)
            {
                return;
            }

            var mesaSelecionada = (Mesa)cboxMesas.SelectedItem!;
            using (var context = new ComandasDbContext())
            {
                mesaSelecionada = context.Mesas.First(me => me.Id == mesaSelecionada.Id);
            }

            if (mesaSelecionada.SituacaoMesa)
            {
                MessageBox.Show($"Mesa {mesaSelecionada.Numero} Já está ocupada");
                return;
            }

            var comanda = new Comanda()
            {
                NomeCliente = txtNomeCliente.Text,
                NumeroMesa = mesaSelecionada.Numero,
                SituacaoComanda = true,
            };

            mesaSelecionada.Cliente = txtNomeCliente.Text;
            mesaSelecionada.SituacaoMesa = true;

            List<ComandaItens> itensAInserir = [];
            foreach (var item in comandaItens)
            {
                itensAInserir.Add(new ComandaItens
                {
                    Comanda = comanda,
                    CardapioItemId = item.CardapioItemId
                });
            }

            using (var context = new ComandasDbContext())
            {
                context.Comandas.Add(comanda);
                context.ComandaItens.AddRange(itensAInserir);
                context.Mesas.Update(mesaSelecionada);
                context.SaveChanges();
            }
            LimparCampos();
        }

        private bool ValidarCampos()
        {
            if (cboxMesas.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma mesa");
                cboxMesas.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNomeCliente.Text))
            {
                MessageBox.Show("Digite o nome do cliente");
                txtNomeCliente.Focus();
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            dataGridView1.Rows.Clear();
            txtNomeCliente.Clear();
        }
    }
}
