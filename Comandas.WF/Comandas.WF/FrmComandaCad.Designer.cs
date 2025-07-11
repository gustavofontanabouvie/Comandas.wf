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
            btnAddItem = new Button();
            cbxItens = new ComboBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            txtNomeCliente = new TextBox();
            cboxMesas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            titulo = new DataGridViewTextBoxColumn();
            descricao = new DataGridViewTextBoxColumn();
            preco = new DataGridViewTextBoxColumn();
            quantidade = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddItem);
            groupBox1.Controls.Add(cbxItens);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(51, 159);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 55);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnAddItem
            // 
            btnAddItem.BackColor = Color.LightGreen;
            btnAddItem.Location = new Point(455, 19);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(40, 25);
            btnAddItem.TabIndex = 2;
            btnAddItem.Text = "+";
            btnAddItem.UseVisualStyleBackColor = false;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // cbxItens
            // 
            cbxItens.FormattingEnabled = true;
            cbxItens.Location = new Point(64, 21);
            cbxItens.Name = "cbxItens";
            cbxItens.Size = new Size(351, 23);
            cbxItens.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 19);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 0;
            label3.Text = "Item:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNomeCliente);
            groupBox2.Controls.Add(cboxMesas);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(51, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(639, 132);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Location = new Point(20, 41);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(395, 23);
            txtNomeCliente.TabIndex = 1;
            // 
            // cboxMesas
            // 
            cboxMesas.FormattingEnabled = true;
            cboxMesas.Location = new Point(20, 91);
            cboxMesas.Name = "cboxMesas";
            cboxMesas.Size = new Size(395, 23);
            cboxMesas.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 67);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 0;
            label2.Text = "Mesa:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 17);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 0;
            label1.Text = "Nome do cliente:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.LightGreen;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnConfirmar.Location = new Point(266, 401);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(116, 37);
            btnConfirmar.TabIndex = 1;
            btnConfirmar.Text = "@ Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Salmon;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(430, 401);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(116, 37);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { titulo, descricao, preco, quantidade });
            dataGridView1.Location = new Point(51, 232);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(639, 150);
            dataGridView1.TabIndex = 2;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.Name = "titulo";
            titulo.ReadOnly = true;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            // 
            // preco
            // 
            preco.HeaderText = "Preço";
            preco.Name = "preco";
            preco.ReadOnly = true;
            // 
            // quantidade
            // 
            quantidade.HeaderText = "Quantidade";
            quantidade.Name = "quantidade";
            quantidade.ReadOnly = true;
            // 
            // FrmComandaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
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
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button btnAddItem;
        private ComboBox cbxItens;
        private TextBox txtNomeCliente;
        private ComboBox cboxMesas;
        private Button btnConfirmar;
        private Button btnCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn preco;
        private DataGridViewTextBoxColumn quantidade;
    }
}