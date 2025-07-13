using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comandas.WF.Database;
using Comandas.WF.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Comandas.WF
{
    public partial class FrmMesaCad : MaterialForm
    {
        public FrmMesaCad()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
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

        private void CarregarMesasDatagrid()
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
