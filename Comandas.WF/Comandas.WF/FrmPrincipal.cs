namespace Comandas.WF
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
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

        }
    }
}
