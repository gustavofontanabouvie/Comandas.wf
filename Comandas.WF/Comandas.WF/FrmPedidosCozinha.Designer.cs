namespace Comandas.WF
{
    partial class FrmPedidosCozinha
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            dataGridViewPendentes = new DataGridView();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            dataGridViewAndamento = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            dataGridViewFinalizados = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            btnVoltar = new MaterialSkin.Controls.MaterialButton();
            btnAvancar = new MaterialSkin.Controls.MaterialButton();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendentes).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAndamento).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalizados).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridViewPendentes);
            groupBox1.Location = new Point(5, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 425);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pendentes";
            // 
            // dataGridViewPendentes
            // 
            dataGridViewPendentes.AllowUserToAddRows = false;
            dataGridViewPendentes.AllowUserToDeleteRows = false;
            dataGridViewPendentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPendentes.BackgroundColor = SystemColors.ControlLight;
            dataGridViewPendentes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewPendentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPendentes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridViewPendentes.Location = new Point(11, 29);
            dataGridViewPendentes.Name = "dataGridViewPendentes";
            dataGridViewPendentes.ReadOnly = true;
            dataGridViewPendentes.Size = new Size(289, 366);
            dataGridViewPendentes.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.FillWeight = 60.9137039F;
            dataGridViewTextBoxColumn7.HeaderText = "Mesa";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.FillWeight = 119.543152F;
            dataGridViewTextBoxColumn8.HeaderText = "Nome do cliente";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.FillWeight = 119.543152F;
            dataGridViewTextBoxColumn9.HeaderText = "Item";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "PedidoCozinhaId";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewAndamento);
            groupBox2.Location = new Point(316, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 425);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Em andamento";
            // 
            // dataGridViewAndamento
            // 
            dataGridViewAndamento.AllowUserToAddRows = false;
            dataGridViewAndamento.AllowUserToDeleteRows = false;
            dataGridViewAndamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAndamento.BackgroundColor = SystemColors.ControlLight;
            dataGridViewAndamento.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewAndamento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAndamento.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, Column5 });
            dataGridViewAndamento.Location = new Point(15, 41);
            dataGridViewAndamento.Name = "dataGridViewAndamento";
            dataGridViewAndamento.ReadOnly = true;
            dataGridViewAndamento.Size = new Size(289, 366);
            dataGridViewAndamento.TabIndex = 1;
            dataGridViewAndamento.CellClick += dataGridViewAndamento_CellClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 60.9137039F;
            dataGridViewTextBoxColumn1.HeaderText = "Mesa";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.FillWeight = 119.543152F;
            dataGridViewTextBoxColumn2.HeaderText = "Nome do cliente";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.FillWeight = 119.543152F;
            dataGridViewTextBoxColumn3.HeaderText = "Item";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.HeaderText = "PedidoCozinhaId";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewFinalizados);
            groupBox3.Location = new Point(626, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(310, 425);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Finalizado";
            // 
            // dataGridViewFinalizados
            // 
            dataGridViewFinalizados.AllowUserToAddRows = false;
            dataGridViewFinalizados.AllowUserToDeleteRows = false;
            dataGridViewFinalizados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFinalizados.BackgroundColor = SystemColors.ControlLight;
            dataGridViewFinalizados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFinalizados.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column6 });
            dataGridViewFinalizados.Location = new Point(16, 41);
            dataGridViewFinalizados.Name = "dataGridViewFinalizados";
            dataGridViewFinalizados.ReadOnly = true;
            dataGridViewFinalizados.Size = new Size(275, 366);
            dataGridViewFinalizados.TabIndex = 0;
            dataGridViewFinalizados.CellClick += dataGridViewFinalizados_CellClick;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.FillWeight = 60.9137039F;
            dataGridViewTextBoxColumn4.HeaderText = "Mesa";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.FillWeight = 119.543152F;
            dataGridViewTextBoxColumn5.HeaderText = "Nome do cliente";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.FillWeight = 119.543152F;
            dataGridViewTextBoxColumn6.HeaderText = "Item";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.HeaderText = "PedidoCozinhaId";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Visible = false;
            // 
            // btnVoltar
            // 
            btnVoltar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnVoltar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnVoltar.Depth = 0;
            btnVoltar.HighEmphasis = true;
            btnVoltar.Icon = null;
            btnVoltar.Location = new Point(398, 446);
            btnVoltar.Margin = new Padding(4, 6, 4, 6);
            btnVoltar.MaximumSize = new Size(500, 25);
            btnVoltar.MouseState = MaterialSkin.MouseState.HOVER;
            btnVoltar.Name = "btnVoltar";
            btnVoltar.NoAccentTextColor = Color.Empty;
            btnVoltar.Size = new Size(64, 25);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "<-";
            btnVoltar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnVoltar.UseAccentColor = false;
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnAvancar
            // 
            btnAvancar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAvancar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAvancar.Depth = 0;
            btnAvancar.HighEmphasis = true;
            btnAvancar.Icon = null;
            btnAvancar.Location = new Point(492, 446);
            btnAvancar.Margin = new Padding(4, 6, 4, 6);
            btnAvancar.MaximumSize = new Size(500, 25);
            btnAvancar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAvancar.Name = "btnAvancar";
            btnAvancar.NoAccentTextColor = Color.Empty;
            btnAvancar.Size = new Size(64, 25);
            btnAvancar.TabIndex = 4;
            btnAvancar.Text = "->";
            btnAvancar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAvancar.UseAccentColor = false;
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Click += btnAvancar_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000000;
            timer1.Tick += timer1_Tick;
            // 
            // FrmPedidosCozinha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 475);
            Controls.Add(btnAvancar);
            Controls.Add(btnVoltar);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPedidosCozinha";
            Text = "FrmPedidosCozinha";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPendentes).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAndamento).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFinalizados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private DataGridView dataGridViewFinalizados;
        private MaterialSkin.Controls.MaterialButton btnVoltar;
        private MaterialSkin.Controls.MaterialButton btnAvancar;
        private DataGridView dataGridViewAndamento;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dataGridViewPendentes;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Column5;
    }
}