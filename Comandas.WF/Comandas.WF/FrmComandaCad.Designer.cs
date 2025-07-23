namespace Comandas.WF
{
    partial class FrmComandaCad
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
            btnAddItem = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            button1 = new Button();
            cbxItens = new MaterialSkin.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            cboxMesas = new MaterialSkin.Controls.MaterialComboBox();
            txtNomeCliente = new MaterialSkin.Controls.MaterialTextBox();
            dataGridView1 = new DataGridView();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnConfirmar = new MaterialSkin.Controls.MaterialButton();
            titulo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddItem);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(cbxItens);
            groupBox1.Location = new Point(51, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 79);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnAddItem
            // 
            btnAddItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddItem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddItem.Depth = 0;
            btnAddItem.HighEmphasis = true;
            btnAddItem.Icon = null;
            btnAddItem.Location = new Point(482, 25);
            btnAddItem.Margin = new Padding(4, 6, 4, 6);
            btnAddItem.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddItem.Name = "btnAddItem";
            btnAddItem.NoAccentTextColor = Color.Empty;
            btnAddItem.Size = new Size(64, 36);
            btnAddItem.TabIndex = 5;
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
            materialLabel3.Location = new Point(20, 35);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(32, 19);
            materialLabel3.TabIndex = 4;
            materialLabel3.Text = "Item";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(104, 241);
            button1.Name = "button1";
            button1.Size = new Size(116, 37);
            button1.TabIndex = 1;
            button1.Text = "@ Confirmar";
            button1.UseVisualStyleBackColor = false;
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
            cbxItens.Location = new Point(64, 19);
            cbxItens.MaxDropDownItems = 4;
            cbxItens.MaximumSize = new Size(900, 0);
            cbxItens.MouseState = MaterialSkin.MouseState.OUT;
            cbxItens.Name = "cbxItens";
            cbxItens.Size = new Size(395, 49);
            cbxItens.StartIndex = 0;
            cbxItens.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(materialLabel2);
            groupBox2.Controls.Add(materialLabel1);
            groupBox2.Controls.Add(cboxMesas);
            groupBox2.Controls.Add(txtNomeCliente);
            groupBox2.Location = new Point(51, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(639, 193);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(20, 19);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(115, 19);
            materialLabel2.TabIndex = 4;
            materialLabel2.Text = "Nome do cliente";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(20, 104);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(40, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Mesa";
            // 
            // cboxMesas
            // 
            cboxMesas.AutoResize = false;
            cboxMesas.BackColor = Color.FromArgb(255, 255, 255);
            cboxMesas.Depth = 0;
            cboxMesas.DrawMode = DrawMode.OwnerDrawVariable;
            cboxMesas.DropDownHeight = 174;
            cboxMesas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboxMesas.DropDownWidth = 121;
            cboxMesas.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboxMesas.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboxMesas.FormattingEnabled = true;
            cboxMesas.IntegralHeight = false;
            cboxMesas.ItemHeight = 43;
            cboxMesas.Location = new Point(20, 126);
            cboxMesas.MaxDropDownItems = 4;
            cboxMesas.MaximumSize = new Size(900, 0);
            cboxMesas.MouseState = MaterialSkin.MouseState.OUT;
            cboxMesas.Name = "cboxMesas";
            cboxMesas.Size = new Size(395, 49);
            cboxMesas.StartIndex = 0;
            cboxMesas.TabIndex = 3;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.AnimateReadOnly = false;
            txtNomeCliente.BorderStyle = BorderStyle.None;
            txtNomeCliente.Depth = 0;
            txtNomeCliente.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCliente.LeadingIcon = null;
            txtNomeCliente.Location = new Point(20, 50);
            txtNomeCliente.MaximumSize = new Size(900, 35);
            txtNomeCliente.MaxLength = 50;
            txtNomeCliente.MouseState = MaterialSkin.MouseState.OUT;
            txtNomeCliente.Multiline = false;
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(395, 35);
            txtNomeCliente.TabIndex = 2;
            txtNomeCliente.Text = "";
            txtNomeCliente.TrailingIcon = null;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titulo, descricao, preco });
            dataGridView1.Location = new Point(51, 296);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(639, 150);
            dataGridView1.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(370, 455);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 6;
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
            btnConfirmar.Location = new Point(246, 454);
            btnConfirmar.Margin = new Padding(4, 6, 4, 6);
            btnConfirmar.MouseState = MaterialSkin.MouseState.HOVER;
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.NoAccentTextColor = Color.Empty;
            btnConfirmar.Size = new Size(105, 36);
            btnConfirmar.TabIndex = 7;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnConfirmar.UseAccentColor = false;
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
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
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(btnConfirmar);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComandaCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmComandaCad";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialComboBox cboxMesas;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNomeCliente;
        private MaterialSkin.Controls.MaterialButton btnAddItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox cbxItens;
        private Button button1;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnConfirmar;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn preco;
    }
}