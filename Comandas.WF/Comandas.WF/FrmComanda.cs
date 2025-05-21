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
    public partial class FrmComanda : Form
    {
        public FrmComanda()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmPrincipal().Show();
        }

        private void btnAddComanda_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmComandaCad().Show();
        }
    }
}
