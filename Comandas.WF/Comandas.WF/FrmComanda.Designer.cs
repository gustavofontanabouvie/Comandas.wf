namespace Comandas.WF
{
    partial class FrmComanda
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
            dataGridViewComandas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            btnEncerrar = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            btnAddComanda = new MaterialSkin.Controls.MaterialButton();
            txtPesquisarComanda = new MaterialSkin.Controls.MaterialTextBox();
            materialCardBot = new MaterialSkin.Controls.MaterialCard();
            materialCardTop = new MaterialSkin.Controls.MaterialCard();
            materialCardMiddle = new MaterialSkin.Controls.MaterialCard();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            dataGridViewItens = new DataGridView();
            titulo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            btnAddItem = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            cbxItens = new MaterialSkin.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComandas).BeginInit();
            materialCardBot.SuspendLayout();
            materialCardTop.SuspendLayout();
            materialCardMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewComandas
            // 
            dataGridViewComandas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewComandas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComandas.BackgroundColor = SystemColors.ControlLight;
            dataGridViewComandas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComandas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Id });
            dataGridViewComandas.Location = new Point(77, 97);
            dataGridViewComandas.Name = "dataGridViewComandas";
            dataGridViewComandas.Size = new Size(638, 368);
            dataGridViewComandas.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Mesa";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Cliente";
            Column2.Name = "Column2";
            // 
            // Id
            // 
            Id.HeaderText = "Column3";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // btnEncerrar
            // 
            btnEncerrar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEncerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEncerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEncerrar.Depth = 0;
            btnEncerrar.HighEmphasis = true;
            btnEncerrar.Icon = null;
            btnEncerrar.Location = new Point(412, 6);
            btnEncerrar.Margin = new Padding(4, 6, 4, 6);
            btnEncerrar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.NoAccentTextColor = Color.Empty;
            btnEncerrar.Size = new Size(112, 36);
            btnEncerrar.TabIndex = 3;
            btnEncerrar.Text = "@ Encerrar";
            btnEncerrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEncerrar.UseAccentColor = false;
            btnEncerrar.UseVisualStyleBackColor = true;
            btnEncerrar.Click += btnEncerrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(306, 6);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(84, 36);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "# Editar";
            btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAddComanda
            // 
            btnAddComanda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddComanda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddComanda.Depth = 0;
            btnAddComanda.HighEmphasis = true;
            btnAddComanda.Icon = null;
            btnAddComanda.Location = new Point(77, 12);
            btnAddComanda.Margin = new Padding(4, 6, 4, 6);
            btnAddComanda.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddComanda.Name = "btnAddComanda";
            btnAddComanda.NoAccentTextColor = Color.Empty;
            btnAddComanda.Size = new Size(106, 36);
            btnAddComanda.TabIndex = 5;
            btnAddComanda.Text = "+ Comanda";
            btnAddComanda.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddComanda.UseAccentColor = false;
            btnAddComanda.UseVisualStyleBackColor = true;
            btnAddComanda.Click += btnAddComanda_Click;
            // 
            // txtPesquisarComanda
            // 
            txtPesquisarComanda.AnimateReadOnly = false;
            txtPesquisarComanda.BorderStyle = BorderStyle.None;
            txtPesquisarComanda.Depth = 0;
            txtPesquisarComanda.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPesquisarComanda.LeadingIcon = null;
            txtPesquisarComanda.Location = new Point(77, 57);
            txtPesquisarComanda.MaximumSize = new Size(900, 25);
            txtPesquisarComanda.MaxLength = 50;
            txtPesquisarComanda.MouseState = MaterialSkin.MouseState.OUT;
            txtPesquisarComanda.Multiline = false;
            txtPesquisarComanda.Name = "txtPesquisarComanda";
            txtPesquisarComanda.Size = new Size(638, 25);
            txtPesquisarComanda.TabIndex = 6;
            txtPesquisarComanda.Text = "";
            txtPesquisarComanda.TrailingIcon = null;
            // 
            // materialCardBot
            // 
            materialCardBot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCardBot.BackColor = Color.FromArgb(255, 255, 255);
            materialCardBot.Controls.Add(btnEditar);
            materialCardBot.Controls.Add(btnEncerrar);
            materialCardBot.Depth = 0;
            materialCardBot.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardBot.Location = new Point(0, 465);
            materialCardBot.Margin = new Padding(14);
            materialCardBot.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardBot.Name = "materialCardBot";
            materialCardBot.Padding = new Padding(14);
            materialCardBot.Size = new Size(800, 54);
            materialCardBot.TabIndex = 7;
            // 
            // materialCardTop
            // 
            materialCardTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialCardTop.BackColor = Color.FromArgb(255, 255, 255);
            materialCardTop.Controls.Add(dataGridViewComandas);
            materialCardTop.Controls.Add(txtPesquisarComanda);
            materialCardTop.Controls.Add(btnAddComanda);
            materialCardTop.Depth = 0;
            materialCardTop.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardTop.Location = new Point(0, 0);
            materialCardTop.Margin = new Padding(14);
            materialCardTop.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardTop.Name = "materialCardTop";
            materialCardTop.Padding = new Padding(14);
            materialCardTop.Size = new Size(800, 465);
            materialCardTop.TabIndex = 8;
            // 
            // materialCardMiddle
            // 
            materialCardMiddle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialCardMiddle.BackColor = Color.FromArgb(255, 255, 255);
            materialCardMiddle.Controls.Add(btnCancelar);
            materialCardMiddle.Controls.Add(btnConfirmar);
            materialCardMiddle.Controls.Add(dataGridViewItens);
            materialCardMiddle.Controls.Add(btnAddItem);
            materialCardMiddle.Controls.Add(materialLabel3);
            materialCardMiddle.Controls.Add(cbxItens);
            materialCardMiddle.Depth = 0;
            materialCardMiddle.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCardMiddle.Location = new Point(0, 246);
            materialCardMiddle.Margin = new Padding(14);
            materialCardMiddle.MouseState = MaterialSkin.MouseState.HOVER;
            materialCardMiddle.Name = "materialCardMiddle";
            materialCardMiddle.Padding = new Padding(14);
            materialCardMiddle.Size = new Size(800, 273);
            materialCardMiddle.TabIndex = 9;
            materialCardMiddle.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(412, 217);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnConfirmar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnConfirmar.Depth = 0;
            btnConfirmar.HighEmphasis = true;
            btnConfirmar.Icon = null;
            btnConfirmar.Location = new Point(285, 217);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(105, 36);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // dataGridViewItens
            // 
            dataGridViewItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewItens.BackgroundColor = SystemColors.ControlLight;
            dataGridViewItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItens.Columns.AddRange(new DataGridViewColumn[] { titulo, descricao, preco, quantidade });
            dataGridViewItens.Location = new Point(77, 80);
            dataGridViewItens.Name = "dataGridViewItens";
            dataGridViewItens.Size = new Size(639, 116);
            dataGridViewItens.TabIndex = 7;
            // 
            // titulo
            // 
            titulo.FillWeight = 50.4923859F;
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.FillWeight = 99.4923859F;
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // preco
            // 
            preco.FillWeight = 30.52284F;
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.FillWeight = 35.4923859F;
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // btnAddItem
            // 
            btnAddItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddItem.Depth = 0;
            btnAddItem.HighEmphasis = true;
            btnAddItem.Icon = null;
            btnAddItem.Location = new Point(529, 29);
            btnAddItem.Margin = new Padding(4, 6, 4, 6);
            btnAddItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.NoAccentTextColor = Color.Empty;
            btnAddItem.Size = new Size(64, 36);
            btnAddItem.TabIndex = 6;
            btnAddItem.Text = "+";
            btnAddItem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddItem.UseAccentColor = false;
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(75, 39);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(32, 19);
            materialLabel3.TabIndex = 5;
            materialLabel3.Text = "Item";
            // 
            // cbxItens
            // 
            cbxItens.AutoResize = false;
            cbxItens.BackColor = Color.FromArgb(255, 255, 255);
            cbxItens.Depth = 0;
            cbxItens.DrawMode = DrawMode.OwnerDrawVariable;
            cbxItens.DropDownHeight = 174;
            cbxItens.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxItens.DropDownWidth = 121;
            cbxItens.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbxItens.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbxItens.FormattingEnabled = true;
            cbxItens.IntegralHeight = false;
            cbxItens.ItemHeight = 43;
            cbxItens.Location = new Point(113, 22);
            cbxItens.MaxDropDownItems = 4;
            cbxItens.MaximumSize = new Size(900, 0);
            cbxItens.MouseState = MaterialSkin.MouseState.OUT;
            cbxItens.Name = "cbxItens";
            cbxItens.Size = new Size(395, 49);
            cbxItens.StartIndex = 0;
            cbxItens.TabIndex = 4;
            // 
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 519);
            Controls.Add(materialCardMiddle);
            Controls.Add(materialCardTop);
            Controls.Add(materialCardBot);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewComandas).EndInit();
            materialCardBot.ResumeLayout(false);
            materialCardBot.PerformLayout();
            materialCardTop.ResumeLayout(false);
            materialCardTop.PerformLayout();
            materialCardMiddle.ResumeLayout(false);
            materialCardMiddle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItens).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridViewComandas;
        private MaterialSkin.Controls.MaterialButton btnEncerrar;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnAddComanda;
        private MaterialSkin.Controls.MaterialTextBox txtPesquisarComanda;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Id;
        private MaterialSkin.Controls.MaterialCard materialCardBot;
        private MaterialSkin.Controls.MaterialCard materialCardTop;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialCard materialCardMiddle;
        private MaterialSkin.Controls.MaterialComboBox cbxItens;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnAddItem;
        private DataGridView dataGridViewItens;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn quantidade;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}