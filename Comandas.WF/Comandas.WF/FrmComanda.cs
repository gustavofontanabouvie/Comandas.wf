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
            PreencherDataGrid();
            CriarMesas();
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

        private void CriarMesas()
        {
            for (int i = 1; i <= 10; i++)
            {
                Mesa mesa = new Mesa();
                mesa.Numero = i;
                mesa.Disponivel = true;
                ListaDeItensEstatica.Mesas.Add(mesa);
            }
        }
        
        private void PreencherDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var mesa in ListaDeItensEstatica.Mesas)
            {
                if (mesa.Disponivel)
                {
                    dataGridView1.Rows.Add(mesa.Numero, "Disponível");
                }
                else
                {
                    dataGridView1.Rows.Add(mesa.Numero, "Ocupada");
                }
            }
        }
    }
}
