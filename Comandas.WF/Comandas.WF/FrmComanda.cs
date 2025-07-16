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
    public partial class FrmComanda : Form
    {

        public FrmPrincipalMenu _frmPrincipalMenu;
        public FrmComanda()
        {
            InitializeComponent();
            PreencherDataGrid();
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
                foreach (var comanda in context.Comandas)
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
                var itens = context.ComandaItens.Where(ci => ci.ComandaId == id).ToList();

                var mesa = context.Mesas.First(me => me.Numero == comanda!.NumeroMesa);
                mesa.Cliente = "sem cliente";
                mesa.SituacaoMesa = false;

                context.RemoveRange(itens);
                context.Comandas.Remove(comanda!);
                context.SaveChanges();
            }
            PreencherDataGrid();
        }
    }
}
