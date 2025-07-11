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
    public partial class FrmComanda : Form
    {
        public FrmComanda()
        {
            InitializeComponent();
            PreencherDataGrid();
            CriarMesas();
        }

        private void btnAddComanda_Click(object sender, EventArgs e)
        {
            this.Close();
            new FrmComandaCad().Show();
        }

        private void CriarMesas()
        {

        }

        private void PreencherDataGrid()
        {

        }
    }
}
