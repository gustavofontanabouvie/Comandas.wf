﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Comandas.WF
{
    public partial class FrmUsuarioCad : Form
    {
        public int idAtual;
        public FrmUsuarioCad()
        {
            InitializeComponent();
            CarregarItens();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtConfirmaSenha.Clear();
        }

        public void CarregarItens()
        {
            dataGridView1.Rows.Clear();

            using (var context = new ComandasDbContext())
            {
                foreach (var user in context.Usuarios)
                {
                    dataGridView1.Rows.Add(user.Id, user.Nome, user.Email);
                }

            }
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int userId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);

            using (var context = new ComandasDbContext())
            {
                var user = context.Usuarios.FirstOrDefault(u => u.Id == userId);
                context.Usuarios.Remove(user!);

                context.SaveChanges();
            }
            CarregarItens();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();

            user.Nome = txtNome.Text;
            user.Email = txtEmail.Text;

            if (txtSenha.Text.Equals(txtConfirmaSenha.Text))
            {
                if (txtNome.Text == "" || txtEmail.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos");
                }
                else
                {
                    user.Senha = txtSenha.Text;

                    using (var context = new ComandasDbContext())
                    {
                        //Select * From Usuario Where id = ?
                        var usuarioExistente = context.Usuarios.FirstOrDefault(u => u.Id == idAtual);

                        if (usuarioExistente != null)
                        {
                            usuarioExistente.Nome = user.Nome;
                            usuarioExistente.Email = user.Email;
                            usuarioExistente.Senha = user.Senha;
                            context.Update(usuarioExistente);
                            context.SaveChanges();
                        }
                        else
                        {
                            context.Add(user);
                            context.SaveChanges();
                        }
                    }
                    LimparCampos();
                    CarregarItens();
                }

            }
            else
            {
                txtSenha.Clear();
                txtConfirmaSenha.Clear();
                MessageBox.Show("Campo confirmar senha deve ser igual ao campo senha");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int userId = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells[0].Value);


            int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out idAtual);
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
