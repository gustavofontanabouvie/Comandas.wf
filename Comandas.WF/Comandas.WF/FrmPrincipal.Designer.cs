namespace Comandas.WF
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnUsuarios = new Button();
            btnMesa = new Button();
            btnPedidos = new Button();
            btnComanda = new Button();
            btnCardapio = new Button();
            btnFechar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(btnMesa);
            groupBox1.Controls.Add(btnPedidos);
            groupBox1.Controls.Add(btnComanda);
            groupBox1.Controls.Add(btnCardapio);
            groupBox1.Location = new Point(55, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(738, 267);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.LightCoral;
            btnUsuarios.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuarios.Location = new Point(440, 61);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(134, 123);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnMesa
            // 
            btnMesa.BackColor = SystemColors.GradientActiveCaption;
            btnMesa.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMesa.Location = new Point(585, 61);
            btnMesa.Name = "btnMesa";
            btnMesa.Size = new Size(134, 123);
            btnMesa.TabIndex = 0;
            btnMesa.Text = "Mesa";
            btnMesa.UseVisualStyleBackColor = false;
            btnMesa.Click += btnMesa_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = SystemColors.GradientActiveCaption;
            btnPedidos.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPedidos.Location = new Point(300, 61);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(134, 123);
            btnPedidos.TabIndex = 0;
            btnPedidos.Text = "Pedido Cozinha";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += btnPedidos_Click;
            // 
            // btnComanda
            // 
            btnComanda.BackColor = Color.LightGreen;
            btnComanda.Font = new Font("Segoe UI", 18.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnComanda.Location = new Point(160, 61);
            btnComanda.Name = "btnComanda";
            btnComanda.Size = new Size(134, 123);
            btnComanda.TabIndex = 0;
            btnComanda.Text = "Comanda";
            btnComanda.UseVisualStyleBackColor = false;
            btnComanda.Click += btnComanda_Click;
            // 
            // btnCardapio
            // 
            btnCardapio.BackColor = SystemColors.Info;
            btnCardapio.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCardapio.Location = new Point(20, 61);
            btnCardapio.Name = "btnCardapio";
            btnCardapio.Size = new Size(134, 123);
            btnCardapio.TabIndex = 0;
            btnCardapio.Text = "Cardápio";
            btnCardapio.UseVisualStyleBackColor = false;
            btnCardapio.Click += btnCardapio_Click;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Salmon;
            btnFechar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(802, 1);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(47, 44);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += button1_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 450);
            Controls.Add(btnFechar);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnCardapio;
        private Button btnUsuarios;
        private Button btnPedidos;
        private Button btnComanda;
        private Button btnFechar;
        private Button btnMesa;
    }
}
