namespace Comandas.WF
{
    partial class FrmCardapioCad
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
            groupBox1 = new GroupBox();
            ckboxPreparo = new MaterialSkin.Controls.MaterialCheckbox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtPreco = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            txtTitulo = new MaterialSkin.Controls.MaterialTextBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnSalvar = new MaterialSkin.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckboxPreparo);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Location = new Point(43, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 312);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // ckboxPreparo
            // 
            ckboxPreparo.AutoSize = true;
            ckboxPreparo.Depth = 0;
            ckboxPreparo.Location = new Point(25, 249);
            ckboxPreparo.Margin = new Padding(0);
            ckboxPreparo.MouseLocation = new Point(-1, -1);
            ckboxPreparo.MouseState = MaterialSkin.MouseState.HOVER;
            ckboxPreparo.Name = "ckboxPreparo";
            ckboxPreparo.ReadOnly = false;
            ckboxPreparo.Ripple = true;
            ckboxPreparo.Size = new Size(153, 37);
            ckboxPreparo.TabIndex = 9;
            ckboxPreparo.Text = "Possui preparo ?";
            ckboxPreparo.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(25, 175);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(41, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Preço";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(25, 111);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Descrição";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(25, 42);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(42, 19);
            materialLabel1.TabIndex = 8;
            materialLabel1.Text = "Título";
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(25, 197);
            txtPreco.MaximumSize = new Size(900, 35);
            txtPreco.MaxLength = 50;
            txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            txtPreco.Multiline = false;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(171, 35);
            txtPreco.TabIndex = 7;
            txtPreco.Text = "";
            txtPreco.TrailingIcon = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(25, 137);
            txtDescricao.MaximumSize = new Size(900, 35);
            txtDescricao.MaxLength = 50;
            txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(500, 35);
            txtDescricao.TabIndex = 7;
            txtDescricao.Text = "";
            txtDescricao.TrailingIcon = null;
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(25, 73);
            txtTitulo.MaximumSize = new Size(900, 35);
            txtTitulo.MaxLength = 50;
            txtTitulo.MouseState = MaterialSkin.MouseState.OUT;
            txtTitulo.Multiline = false;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(500, 35);
            txtTitulo.TabIndex = 7;
            txtTitulo.Text = "";
            txtTitulo.TrailingIcon = null;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(368, 332);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(109, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.Location = new Point(261, 332);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(89, 36);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "# Salvar";
            btnSalvar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmCardapioCad";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnSalvar;
        private MaterialSkin.Controls.MaterialCheckbox ckboxPreparo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtPreco;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialTextBox txtTitulo;
    }
}