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
            Id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnExcluirUsuario = new Button();
            btnEditar = new Button();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            groupBox2.Location = new Point(351, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 419);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 104);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 23);
            txtNome.TabIndex = 1;
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.Location = new Point(44, 288);
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(195, 23);
            txtConfirmaSenha.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 270);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 2;
            label5.Text = "Confirmar senha";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(91, 377);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(98, 23);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(44, 224);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(195, 23);
            txtSenha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 32);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Cadastrar Usuário";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 206);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 2;
            label4.Text = "Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 86);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome de Usuário";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(44, 164);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 23);
            txtEmail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 146);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 2;
            label3.Text = "E-mail";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Usuario, Email });
            dataGridView1.Location = new Point(27, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(279, 343);
            dataGridView1.TabIndex = 8;
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
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.Location = new Point(65, 391);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(88, 23);
            btnExcluirUsuario.TabIndex = 6;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(180, 391);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 443);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
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
        private Button btnEditar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Email;
    }
}