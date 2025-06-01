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
            btnEditar = new Button();
            btnCancelar = new Button();
            groupBox1 = new GroupBox();
            ckboxPreparo = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPreco = new TextBox();
            txtDescricao = new TextBox();
            txtTitulo = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.LightGreen;
            btnEditar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(579, 388);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(154, 41);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "# Editar";
            btnEditar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Tomato;
            btnCancelar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(412, 388);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(154, 41);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "X Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ckboxPreparo);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPreco);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Location = new Point(68, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(665, 312);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // ckboxPreparo
            // 
            ckboxPreparo.AutoSize = true;
            ckboxPreparo.Location = new Point(25, 241);
            ckboxPreparo.Name = "ckboxPreparo";
            ckboxPreparo.Size = new Size(112, 19);
            ckboxPreparo.TabIndex = 6;
            ckboxPreparo.Text = "Possui preparo ?";
            ckboxPreparo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 175);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Preço";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 54);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Título";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(25, 193);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(156, 23);
            txtPreco.TabIndex = 5;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(25, 129);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(473, 23);
            txtDescricao.TabIndex = 3;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(25, 72);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(473, 23);
            txtTitulo.TabIndex = 1;
            // 
            // FrmCardapioEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditar);
            Controls.Add(btnCancelar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapioEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCardapioEdit";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEditar;
        private Button btnCancelar;
        private GroupBox groupBox1;
        private CheckBox ckboxPreparo;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPreco;
        private TextBox txtDescricao;
        private TextBox txtTitulo;
    }
}