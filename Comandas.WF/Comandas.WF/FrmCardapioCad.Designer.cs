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
            label1 = new Label();
            txtTitulo = new TextBox();
            groupBox1 = new GroupBox();
            cboxPreparo = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Título";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(25, 72);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(473, 23);
            txtTitulo.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboxPreparo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Location = new Point(67, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 312);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // cboxPreparo
            // 
            cboxPreparo.AutoSize = true;
            cboxPreparo.Location = new Point(25, 241);
            cboxPreparo.Name = "cboxPreparo";
            cboxPreparo.Size = new Size(112, 19);
            cboxPreparo.TabIndex = 2;
            cboxPreparo.Text = "Possui preparo ?";
            cboxPreparo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 175);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 0;
            label3.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 0;
            label2.Text = "Descrição";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(25, 193);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(156, 23);
            txtPreco.TabIndex = 1;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(25, 129);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(473, 23);
            txtDescricao.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(411, 397);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 41);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.LightGreen;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(578, 397);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(154, 41);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "# Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // FrmCardapioCad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioCad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTitulo;
        private GroupBox groupBox1;
        private CheckBox cboxPreparo;
        private Label label2;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private Label label3;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}