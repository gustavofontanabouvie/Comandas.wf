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
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmPrincipal().Show();
        }

        private void btnAddItemCardapio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCardapioCad().Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
