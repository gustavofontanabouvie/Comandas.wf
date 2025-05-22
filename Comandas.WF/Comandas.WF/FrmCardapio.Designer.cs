namespace Comandas.WF
{
    partial class FrmCardapio
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
            label1 = new Label();
            btnVoltar = new Button();
            txtPesquisar = new TextBox();
            btnAddItemCardapio = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewCheckBoxColumn();
            btnExcluir = new Button();
            btnEditar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Pesquisar:";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Salmon;
            btnVoltar.Location = new Point(751, 1);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(46, 38);
            btnVoltar.TabIndex = 1;
            btnVoltar.Text = "X";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(78, 10);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(543, 23);
            txtPesquisar.TabIndex = 2;
            // 
            // btnAddItemCardapio
            // 
            btnAddItemCardapio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddItemCardapio.Location = new Point(12, 54);
            btnAddItemCardapio.Name = "btnAddItemCardapio";
            btnAddItemCardapio.Size = new Size(128, 32);
            btnAddItemCardapio.TabIndex = 3;
            btnAddItemCardapio.Text = "+ Item cardápio";
            btnAddItemCardapio.UseVisualStyleBackColor = true;
            btnAddItemCardapio.Click += btnAddItemCardapio_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 92);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(754, 306);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(15, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(721, 268);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Título";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Descrição";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Preço";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Possui preparo";
            Column5.Name = "Column5";
            Column5.Resizable = DataGridViewTriState.True;
            Column5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.LightCoral;
            btnExcluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(27, 404);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(80, 34);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "X Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.PaleGreen;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(122, 404);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 34);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
     
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnExcluir);
            Controls.Add(groupBox1);
            Controls.Add(btnAddItemCardapio);
            Controls.Add(txtPesquisar);
            Controls.Add(btnVoltar);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapio";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnVoltar;
        private TextBox txtPesquisar;
        private Button btnAddItemCardapio;
        private GroupBox groupBox1;
        public DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewCheckBoxColumn Column5;
        private Button btnExcluir;
        private Button btnEditar;
    }
}