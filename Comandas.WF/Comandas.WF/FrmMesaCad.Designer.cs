namespace Comandas.WF
{
    partial class FrmMesaCad
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
            btnCadastrarMesa = new MaterialSkin.Controls.MaterialButton();
            dataGridViewMesas = new DataGridView();
            numeroMesa = new DataGridViewTextBoxColumn();
            clienteMesa = new DataGridViewTextBoxColumn();
            situacaoMesa = new DataGridViewTextBoxColumn();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtNumeroMesa = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).BeginInit();
            SuspendLayout();
            // 
            // btnCadastrarMesa
            // 
            btnCadastrarMesa.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCadastrarMesa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCadastrarMesa.Depth = 0;
            btnCadastrarMesa.HighEmphasis = true;
            btnCadastrarMesa.Icon = null;
            btnCadastrarMesa.Location = new Point(273, 311);
            btnCadastrarMesa.Margin = new Padding(4, 6, 4, 6);
            btnCadastrarMesa.MouseState = MaterialSkin.MouseState.HOVER;
            btnCadastrarMesa.Name = "btnCadastrarMesa";
            btnCadastrarMesa.NoAccentTextColor = Color.Empty;
            btnCadastrarMesa.Size = new Size(149, 36);
            btnCadastrarMesa.TabIndex = 0;
            btnCadastrarMesa.Text = "Cadastrar Mesa";
            btnCadastrarMesa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCadastrarMesa.UseAccentColor = false;
            btnCadastrarMesa.UseVisualStyleBackColor = true;
            btnCadastrarMesa.Click += btnCadastrarMesa_Click;
            // 
            // dataGridViewMesas
            // 
            dataGridViewMesas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMesas.BackgroundColor = SystemColors.ControlLight;
            dataGridViewMesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMesas.Columns.AddRange(new DataGridViewColumn[] { numeroMesa, clienteMesa, situacaoMesa });
            dataGridViewMesas.Location = new Point(25, 84);
            dataGridViewMesas.Name = "dataGridViewMesas";
            dataGridViewMesas.Size = new Size(615, 150);
            dataGridViewMesas.TabIndex = 1;
            // 
            // numeroMesa
            // 
            numeroMesa.FillWeight = 80.93909F;
            numeroMesa.HeaderText = "Numero";
            numeroMesa.Name = "numeroMesa";
            // 
            // clienteMesa
            // 
            clienteMesa.FillWeight = 88.68863F;
            clienteMesa.HeaderText = "Cliente";
            clienteMesa.Name = "clienteMesa";
            // 
            // situacaoMesa
            // 
            situacaoMesa.FillWeight = 80.37228F;
            situacaoMesa.HeaderText = "Situação";
            situacaoMesa.Name = "situacaoMesa";
            situacaoMesa.Resizable = DataGridViewTriState.True;
            situacaoMesa.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(23, 319);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(122, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Numero da mesa";
            // 
            // txtNumeroMesa
            // 
            txtNumeroMesa.AnimateReadOnly = false;
            txtNumeroMesa.BorderStyle = BorderStyle.None;
            txtNumeroMesa.Depth = 0;
            txtNumeroMesa.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNumeroMesa.LeadingIcon = null;
            txtNumeroMesa.Location = new Point(151, 311);
            txtNumeroMesa.MaximumSize = new Size(500, 35);
            txtNumeroMesa.MaxLength = 50;
            txtNumeroMesa.MouseState = MaterialSkin.MouseState.OUT;
            txtNumeroMesa.Multiline = false;
            txtNumeroMesa.Name = "txtNumeroMesa";
            txtNumeroMesa.Size = new Size(100, 35);
            txtNumeroMesa.TabIndex = 3;
            txtNumeroMesa.Text = "";
            txtNumeroMesa.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(23, 256);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(152, 19);
            materialLabel2.TabIndex = 2;
            materialLabel2.Text = "Cadastrar nova mesa";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(23, 19);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(92, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "Listar mesas";
            // 
            // FrmMesaCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 404);
            Controls.Add(txtNumeroMesa);
            Controls.Add(materialLabel3);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(dataGridViewMesas);
            Controls.Add(btnCadastrarMesa);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmMesaCad";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FrmMesaCad";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMesas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnCadastrarMesa;
        private DataGridView dataGridViewMesas;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtNumeroMesa;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DataGridViewTextBoxColumn numeroMesa;
        private DataGridViewTextBoxColumn clienteMesa;
        private DataGridViewTextBoxColumn situacaoMesa;
        private System.Windows.Forms.Timer timer1;
    }
}