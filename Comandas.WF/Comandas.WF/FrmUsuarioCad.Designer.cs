namespace Comandas.WF
{
    partial class FrmUsuarioCad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVoltar = new Button();
            groupBox2 = new GroupBox();
            txtNome = new TextBox();
            txtConfirmaSenha = new TextBox();
            label5 = new Label();
            btnCadastrar = new Button();
            txtSenha = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            btnExcluirUsuario = new Button();
            btnSelecionar = new Button();
            Id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.IndianRed;
            btnVoltar.Location = new Point(652, 3);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(43, 32);
            btnVoltar.TabIndex = 0;
            btnVoltar.Text = "X";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(txtConfirmaSenha);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnCadastrar);
            groupBox2.Controls.Add(txtSenha);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(351, 38);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 393);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 84);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 23);
            txtNome.TabIndex = 3;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(44, 268);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(195, 23);
            txtConfirmaSenha.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 250);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Confirmar senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(88, 344);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(98, 23);
            btnCadastrar.TabIndex = 0;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(44, 204);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(195, 23);
            txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 186);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 66);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome de Usuário";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 144);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 23);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 126);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Usuario, Email });
            dataGridView1.Location = new Point(27, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(279, 311);
            dataGridView1.TabIndex = 6;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(65, 382);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(88, 23);
            btnExcluirUsuario.TabIndex = 7;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(180, 382);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(75, 23);
            btnSelecionar.TabIndex = 8;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 30;
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 443);
            Controls.Add(btnSelecionar);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(btnVoltar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsuarioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmUsuarioCad";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private GroupBox groupBox2;
        private TextBox txtNome;
        private TextBox txtConfirmaSenha;
        private Label label5;
        private Button btnCadastrar;
        private TextBox txtSenha;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnExcluirUsuario;
        private Button btnSelecionar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Email;
    }
}