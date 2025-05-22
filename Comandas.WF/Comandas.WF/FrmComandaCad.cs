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
    public partial class FrmComandaCad : Form
    {
        public FrmComandaCad()
        {
            InitializeComponent();
            PreencherComboBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmComanda().Show();
        }

        private void PreencherComboBox()
        {
            cboxItens.Items.Clear();
            foreach (var item in ListaDeItensEstatica.Itens)
            {
                cboxItens.Items.Add(item.Titulo);
            }
        }
    }
}
