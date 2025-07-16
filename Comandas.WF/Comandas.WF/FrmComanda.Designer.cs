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
            btnEncerrar = new MaterialSkin.Controls.MaterialButton();
            btnEditar = new MaterialSkin.Controls.MaterialButton();
            btnAddComanda = new MaterialSkin.Controls.MaterialButton();
            txtPesquisarComanda = new MaterialSkin.Controls.MaterialTextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComandas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewComandas
            // 
            dataGridViewComandas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewComandas.BackgroundColor = SystemColors.ControlLight;
            dataGridViewComandas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComandas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Id });
            dataGridViewComandas.Location = new Point(75, 111);
            dataGridViewComandas.Name = "dataGridViewComandas";
            dataGridViewComandas.Size = new Size(638, 275);
            dataGridViewComandas.TabIndex = 2;
            // 
            // btnEncerrar
            // 
            btnEncerrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEncerrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEncerrar.Depth = 0;
            btnEncerrar.HighEmphasis = true;
            btnEncerrar.Icon = null;
            btnEncerrar.Location = new Point(380, 406);
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
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.Location = new Point(277, 406);
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
            // 
            // btnAddComanda
            // 
            btnAddComanda.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddComanda.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddComanda.Depth = 0;
            btnAddComanda.HighEmphasis = true;
            btnAddComanda.Icon = null;
            btnAddComanda.Location = new Point(75, 11);
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
            txtPesquisarComanda.Location = new Point(75, 70);
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
            // FrmComanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 457);
            Controls.Add(txtPesquisarComanda);
            Controls.Add(btnAddComanda);
            Controls.Add(btnEditar);
            Controls.Add(btnEncerrar);
            Controls.Add(dataGridViewComandas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmComanda";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewComandas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}