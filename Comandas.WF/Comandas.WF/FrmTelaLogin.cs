using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comandas.WF.Database;
using Comandas.WF.Models;

namespace Comandas.WF
{
    public partial class FrmTelaLogin : Form
    {
        public FrmTelaLogin()
        {
            InitializeComponent();
            cbxUsuario.DataSource = BuscaTodosUsuarios();
        }

        private List<string> BuscaTodosUsuarios()
        {
            using (var context = new ComandasDbContext())
            {
                return context.Usuarios.ToList().Select(u => u.Email).ToList();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool loginOk = false;

            using (var context = new ComandasDbContext())
            {

                var usuario = context.Usuarios.FirstOrDefault(u => u.Email.Equals(cbxUsuario.Text));

                if (usuario is not null && usuario.Senha.Equals(txtSenha.Text))
                {
                    this.Close();
                    loginOk = true;
                }
            }
            ;

            if (!loginOk)
                MessageBox.Show("Usuario ou senha inválido");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
