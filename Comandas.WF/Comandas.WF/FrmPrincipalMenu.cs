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

            AbrirFormNaAba(new FrmCardapio().ReceberFormPrincipal(this), tabPgCardapio);
            AbrirFormNaAba(new FrmComanda().ReceberFormPrincipal(this), tabPgComanda);
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

        public void AbrirFormNaAba(Form frm, TabPage tabPage)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue900, Primary.Blue900, Accent.Blue700, TextShade.WHITE);

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();
            tabPage.Controls.Add(frm);
            frm.Show();
        }
    }
}
