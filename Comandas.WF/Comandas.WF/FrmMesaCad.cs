using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Comandas.WF.Database;
using Comandas.WF.Models;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Comandas.WF
{

    public partial class FrmMesaCad : MaterialForm
    {
        private System.Windows.Forms.Timer timer10sec;

        public FrmMesaCad()
        {
            InitializeComponent();
            timer10sec = new System.Windows.Forms.Timer();
            timer10sec.Interval = 10000;
            timer10sec.Tick += timer10sec_tick;
            timer10sec.Start();

            CarregarMesasDatagrid();
        }

        private void timer10sec_tick(object? sender, EventArgs e)
        {
            CarregarMesasDatagrid();
        }

        private void btnCadastrarMesa_Click(object sender, EventArgs e)
        {
            Mesa mesa = new Mesa();

            using (var context = new ComandasDbContext())
            {
                if (!int.TryParse(txtNumeroMesa.Text, out int numMesa))
                {
                    txtNumeroMesa.Clear();
                    return;
                }
                else
                {
                    mesa.Numero = numMesa;
                    mesa.SituacaoMesa = false;
                    mesa.Cliente = "sem cliente";
                }

                context.Add(mesa);
                context.SaveChanges();
            }

            txtNumeroMesa.Clear();
            CarregarMesasDatagrid();
        }

        public void CarregarMesasDatagrid()
        {
            dataGridViewMesas.Rows.Clear();
            using (var context = new ComandasDbContext())
            {
                foreach (var mesa in context.Mesas)
                {
                    if (mesa.SituacaoMesa == false)
                    {
                        dataGridViewMesas.Rows.Add(mesa.Numero, mesa.Cliente, "Disponivel");
                    }
                    else
                    {
                        dataGridViewMesas.Rows.Add(mesa.Numero, mesa.Cliente, "Ocupada");
                    }
                }
            }

        }
    }
}
