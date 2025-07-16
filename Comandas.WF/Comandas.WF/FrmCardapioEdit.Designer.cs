namespace Comandas.WF
{
    partial class FrmCardapioEdit
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
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtTitulo = new MaterialSkin.Controls.MaterialTextBox();
            txtDescricao = new MaterialSkin.Controls.MaterialTextBox();
            txtPreco = new MaterialSkin.Controls.MaterialTextBox();
            ckboxPreparo = new MaterialSkin.Controls.MaterialCheckbox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(65, 32);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(42, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Título";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(64, 108);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(71, 19);
            materialLabel2.TabIndex = 13;
            materialLabel2.Text = "Descrição";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(65, 172);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(41, 19);
            materialLabel3.TabIndex = 13;
            materialLabel3.Text = "Preço";
            // 
            // txtTitulo
            // 
            txtTitulo.AnimateReadOnly = false;
            txtTitulo.BorderStyle = BorderStyle.None;
            txtTitulo.Depth = 0;
            txtTitulo.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTitulo.LeadingIcon = null;
            txtTitulo.Location = new Point(64, 54);
            txtTitulo.MaximumSize = new Size(900, 35);
            txtTitulo.MaxLength = 50;
            txtTitulo.MouseState = MaterialSkin.MouseState.OUT;
            txtTitulo.Multiline = false;
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(473, 35);
            txtTitulo.TabIndex = 14;
            txtTitulo.Text = "";
            txtTitulo.TrailingIcon = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.BackColor = SystemColors.MenuHighlight;
            txtDescricao.BorderStyle = BorderStyle.None;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(64, 130);
            txtDescricao.MaximumSize = new Size(900, 35);
            txtDescricao.MaxLength = 50;
            txtDescricao.MouseState = MaterialSkin.MouseState.OUT;
            txtDescricao.Multiline = false;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(473, 35);
            txtDescricao.TabIndex = 14;
            txtDescricao.Text = "";
            txtDescricao.TrailingIcon = null;
            // 
            // txtPreco
            // 
            txtPreco.AnimateReadOnly = false;
            txtPreco.BorderStyle = BorderStyle.None;
            txtPreco.Depth = 0;
            txtPreco.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPreco.LeadingIcon = null;
            txtPreco.Location = new Point(65, 194);
            txtPreco.MaximumSize = new Size(900, 35);
            txtPreco.MaxLength = 50;
            txtPreco.MouseState = MaterialSkin.MouseState.OUT;
            txtPreco.Multiline = false;
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(163, 35);
            txtPreco.TabIndex = 14;
            txtPreco.Text = "";
            txtPreco.TrailingIcon = null;
            // 
            // ckboxPreparo
            // 
            ckboxPreparo.AutoSize = true;
            ckboxPreparo.Depth = 0;
            ckboxPreparo.Location = new Point(65, 249);
            ckboxPreparo.Margin = new Padding(0);
            ckboxPreparo.MouseLocation = new Point(-1, -1);
            ckboxPreparo.MouseState = MaterialSkin.MouseState.HOVER;
            ckboxPreparo.Name = "ckboxPreparo";
            ckboxPreparo.ReadOnly = false;
            ckboxPreparo.Ripple = true;
            ckboxPreparo.Size = new Size(153, 37);
            ckboxPreparo.TabIndex = 15;
            ckboxPreparo.Text = "Possui preparo ?";
            ckboxPreparo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(257, 316);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(372, 316);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 16;
            btnEditar.Text = "Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // FrmCardapioEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(ckboxPreparo);
            Controls.Add(txtPreco);
            Controls.Add(txtDescricao);
            Controls.Add(txtTitulo);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmCardapioEdit";
            Padding = new Padding(3, 0, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapioEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtTitulo;
        private MaterialSkin.Controls.MaterialTextBox txtDescricao;
        private MaterialSkin.Controls.MaterialTextBox txtPreco;
        private MaterialSkin.Controls.MaterialCheckbox ckboxPreparo;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
    }
}