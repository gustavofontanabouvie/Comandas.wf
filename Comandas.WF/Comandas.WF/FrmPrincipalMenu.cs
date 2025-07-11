using Comandas.WF.Database;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;

namespace Comandas.WF
{
    public partial class FrmPrincipalMenu : MaterialForm
    {
        public FrmPrincipalMenu()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE);
            InicializarBD();
            AbrirFormNaAba(new FrmCardapio(), tabPgCardapio);
            AbrirFormNaAba(new FrmComanda(), tabPgComanda);
            AbrirFormNaAba(new FrmPedidosCozinha(), tabPgPedidoCozinha);
            AbrirFormNaAba(new FrmUsuarioCad(), tabPgUsuarios);
            AbrirFormNaAba(new FrmMesaCad(), tabPgMesa);

            new FrmTelaLogin().ShowDialog();
        }

        public FrmPrincipalMenu(bool usuarioAutenticado)
        {
            InitializeComponent();
        }

        private void InicializarBD()
        {
            using (var context = new ComandasDbContext())
            {
                context.Database.EnsureCreated();
                context.Database.Migrate();

                InicializarDados.SemearBanco(context);
            }
        }


        private void btnCardapio_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCardapio().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnComanda_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmComanda().Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmPedidosCozinha().Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmUsuarioCad().Show();
        }

        private void btnMesa_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmMesaCad().Show();
        }

        private void AbrirFormNaAba(Form frm, TabPage tabPage)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();
            tabPage.Controls.Add(frm);
            frm.Show();
        }
    }
}
