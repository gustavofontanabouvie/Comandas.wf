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
            btnAddComanda = new Button();
            txtPesquisarComanda = new TextBox();
            btnEditar = new Button();
            btnEncerrar = new Button();
            btnCancelar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAddComanda
            // 
            btnAddComanda.Location = new Point(75, 12);
            btnAddComanda.Name = "btnAddComanda";
            btnAddComanda.Size = new Size(123, 23);
            btnAddComanda.TabIndex = 0;
            btnAddComanda.Text = "+ Comanda";
            btnAddComanda.UseVisualStyleBackColor = true;
            btnAddComanda.Click += btnAddComanda_Click;
            // 
            // txtPesquisarComanda
            // 
            txtPesquisarComanda.Location = new Point(75, 50);
            txtPesquisarComanda.Name = "txtPesquisarComanda";
            txtPesquisarComanda.Size = new Size(638, 23);
            txtPesquisarComanda.TabIndex = 1;
            // 
            // btnEditar
            // 
            btnEditar.AllowDrop = true;
            btnEditar.BackColor = Color.LightGreen;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(142, 393);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(123, 36);
            btnEditar.TabIndex = 0;
            btnEditar.Text = "# Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEncerrar
            // 
            btnEncerrar.BackColor = SystemColors.ActiveCaption;
            btnEncerrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEncerrar.Location = new Point(338, 393);
            btnEncerrar.Name = "btnEncerrar";
            btnEncerrar.Size = new Size(130, 36);
            btnEncerrar.TabIndex = 0;
            btnEncerrar.Text = "@ Encerrar";
            btnEncerrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(537, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(123, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(75, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(638, 275);
            dataGridView1.TabIndex = 2;
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
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisarComanda);
            Controls.Add(btnCancelar);
            Controls.Add(btnEncerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAddComanda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddComanda;
        private TextBox txtPesquisarComanda;
        private Button btnEditar;
        private Button btnEncerrar;
        private Button btnCancelar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}