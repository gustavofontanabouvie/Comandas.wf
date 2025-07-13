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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtConfirmaSenha = new MaterialSkin.Controls.MaterialTextBox();
            txtSenha = new MaterialSkin.Controls.MaterialTextBox();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox();
            txtNome = new MaterialSkin.Controls.MaterialTextBox();
            btnCadastrar = new MaterialSkin.Controls.MaterialButton();
            btnExcluirUsuario = new MaterialSkin.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialLabel2);
            groupBox2.Controls.Add(materialLabel4);
            groupBox2.Controls.Add(materialLabel5);
            groupBox2.Controls.Add(materialLabel3);
            groupBox2.Controls.Add(materialLabel1);
            groupBox2.Controls.Add(txtConfirmaSenha);
            groupBox2.Controls.Add(txtSenha);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(btnCadastrar);
            groupBox2.Location = new Point(351, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(282, 419);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(77, 19);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(128, 19);
            materialLabel2.TabIndex = 11;
            materialLabel2.Text = "Cadastrar Usuário";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(44, 132);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(45, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "E-mail";
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(44, 268);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(119, 19);
            materialLabel5.TabIndex = 11;
            materialLabel5.Text = "Confirmar senha";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(44, 202);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(46, 19);
            materialLabel3.TabIndex = 11;
            materialLabel3.Text = "Senha";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(44, 72);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(122, 19);
            materialLabel1.TabIndex = 11;
            materialLabel1.Text = "Nome de Usuário";
            // 
            // txtConfirmaSenha
            // 
            txtConfirmaSenha.AnimateReadOnly = false;
            txtConfirmaSenha.BorderStyle = BorderStyle.None;
            txtConfirmaSenha.Depth = 0;
            txtConfirmaSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtConfirmaSenha.LeadingIcon = null;
            txtConfirmaSenha.Location = new Point(44, 301);
            txtConfirmaSenha.MaximumSize = new Size(500, 35);
            txtConfirmaSenha.MaxLength = 50;
            txtConfirmaSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtConfirmaSenha.Multiline = false;
            txtConfirmaSenha.Name = "txtConfirmaSenha";
            txtConfirmaSenha.Size = new Size(195, 35);
            txtConfirmaSenha.TabIndex = 10;
            txtConfirmaSenha.Text = "";
            txtConfirmaSenha.TrailingIcon = null;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.LeadingIcon = null;
            txtSenha.Location = new Point(44, 224);
            txtSenha.MaximumSize = new Size(500, 35);
            txtSenha.MaxLength = 50;
            txtSenha.MouseState = MaterialSkin.MouseState.OUT;
            txtSenha.Multiline = false;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(195, 35);
            txtSenha.TabIndex = 10;
            txtSenha.Text = "";
            txtSenha.TrailingIcon = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(44, 164);
            txtEmail.MaximumSize = new Size(500, 35);
            txtEmail.MaxLength = 50;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(195, 35);
            txtEmail.TabIndex = 10;
            txtEmail.Text = "";
            txtEmail.TrailingIcon = null;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.BorderStyle = BorderStyle.None;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(44, 94);
            txtNome.MaximumSize = new Size(500, 35);
            txtNome.MaxLength = 50;
            txtNome.MouseState = MaterialSkin.MouseState.OUT;
            txtNome.Multiline = false;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(195, 35);
            txtNome.TabIndex = 10;
            txtNome.Text = "";
            txtNome.TrailingIcon = null;
            // 
            // btnCadastrar
            // 
            btnCadastrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrar.Depth = 0;
            btnCadastrar.HighEmphasis = true;
            btnCadastrar.Icon = null;
            btnCadastrar.Location = new Point(89, 353);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.NoAccentTextColor = Color.Empty;
            btnCadastrar.Size = new Size(106, 36);
            btnCadastrar.TabIndex = 9;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrar.UseAccentColor = false;
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluirUsuario.Cursor = Cursors.Hand;
            btnExcluirUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluirUsuario.Depth = 0;
            btnExcluirUsuario.HighEmphasis = true;
            btnExcluirUsuario.Icon = null;
            btnExcluirUsuario.Location = new Point(60, 382);
            btnExcluirUsuario.Margin = new Padding(4, 6, 4, 6);
            btnExcluirUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.NoAccentTextColor = Color.Empty;
            btnExcluirUsuario.Size = new Size(80, 36);
            btnExcluirUsuario.TabIndex = 9;
            btnExcluirUsuario.Text = "Excluir";
            btnExcluirUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluirUsuario.UseAccentColor = false;
            btnExcluirUsuario.UseVisualStyleBackColor = true;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Usuario, Email });
            dataGridView1.Location = new Point(27, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(279, 343);
            dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            Id.FillWeight = 45.68528F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Usuario
            // 
            Usuario.FillWeight = 127.157364F;
            Usuario.HeaderText = "Usuario";
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Email
            // 
            Email.FillWeight = 127.157364F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(191, 382);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmUsuarioCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 443);
            Controls.Add(btnExcluirUsuario);
            Controls.Add(btnEditar);
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
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button btnEdita;
        private MaterialSkin.Controls.MaterialButton btnCadastrar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Email;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnExcluirUsuario;
        private MaterialSkin.Controls.MaterialTextBox txtNome;
        private MaterialSkin.Controls.MaterialTextBox txtConfirmaSenha;
        private MaterialSkin.Controls.MaterialTextBox txtSenha;
        private MaterialSkin.Controls.MaterialTextBox txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}