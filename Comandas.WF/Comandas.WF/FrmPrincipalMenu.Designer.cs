namespace Comandas.WF
{
    partial class FrmPrincipalMenu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalMenu));
            contextMenuStrip1 = new ContextMenuStrip(components);
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            tabPgCardapio = new TabPage();
            tabPgComanda = new TabPage();
            tabPgPedidoCozinha = new TabPage();
            tabPgUsuarios = new TabPage();
            tabPgMesa = new TabPage();
            imageList1 = new ImageList(components);
            materialTabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(tabPgCardapio);
            materialTabControl1.Controls.Add(tabPgComanda);
            materialTabControl1.Controls.Add(tabPgPedidoCozinha);
            materialTabControl1.Controls.Add(tabPgUsuarios);
            materialTabControl1.Controls.Add(tabPgMesa);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = imageList1;
            materialTabControl1.Location = new Point(3, 64);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(894, 721);
            materialTabControl1.TabIndex = 1;
            // 
            // tabPgCardapio
            // 
            tabPgCardapio.ForeColor = SystemColors.ControlLightLight;
            tabPgCardapio.ImageKey = "imgCardapio.png";
            tabPgCardapio.Location = new Point(4, 31);
            tabPgCardapio.Name = "tabPgCardapio";
            tabPgCardapio.Padding = new Padding(3);
            tabPgCardapio.Size = new Size(886, 686);
            tabPgCardapio.TabIndex = 0;
            tabPgCardapio.Text = "Cardápio";
            tabPgCardapio.UseVisualStyleBackColor = true;
            // 
            // tabPgComanda
            // 
            tabPgComanda.ImageKey = "imgComanda.png";
            tabPgComanda.Location = new Point(4, 31);
            tabPgComanda.Name = "tabPgComanda";
            tabPgComanda.Padding = new Padding(3);
            tabPgComanda.Size = new Size(886, 686);
            tabPgComanda.TabIndex = 1;
            tabPgComanda.Text = "Comanda";
            tabPgComanda.UseVisualStyleBackColor = true;
            // 
            // tabPgPedidoCozinha
            // 
            tabPgPedidoCozinha.ImageKey = "imgPedidoCozinha.png";
            tabPgPedidoCozinha.Location = new Point(4, 31);
            tabPgPedidoCozinha.Name = "tabPgPedidoCozinha";
            tabPgPedidoCozinha.Size = new Size(886, 686);
            tabPgPedidoCozinha.TabIndex = 2;
            tabPgPedidoCozinha.Text = "Pedido Cozinha";
            tabPgPedidoCozinha.UseVisualStyleBackColor = true;
            // 
            // tabPgUsuarios
            // 
            tabPgUsuarios.ImageKey = "imgUsuarios.png";
            tabPgUsuarios.Location = new Point(4, 31);
            tabPgUsuarios.Name = "tabPgUsuarios";
            tabPgUsuarios.Size = new Size(886, 686);
            tabPgUsuarios.TabIndex = 3;
            tabPgUsuarios.Text = "Usuários";
            tabPgUsuarios.UseVisualStyleBackColor = true;
            // 
            // tabPgMesa
            // 
            tabPgMesa.ImageKey = "imgMesa.png";
            tabPgMesa.Location = new Point(4, 31);
            tabPgMesa.Name = "tabPgMesa";
            tabPgMesa.Size = new Size(886, 686);
            tabPgMesa.TabIndex = 4;
            tabPgMesa.Text = "Mesa";
            tabPgMesa.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "imgPedidoCozinha.png");
            imageList1.Images.SetKeyName(1, "imgCardapio.png");
            imageList1.Images.SetKeyName(2, "imgComanda.png");
            imageList1.Images.SetKeyName(3, "imgUsuarios.png");
            imageList1.Images.SetKeyName(4, "imgMesa.png");
            // 
            // FrmPrincipalMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 788);
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Name = "FrmPrincipalMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nome em definição";
            materialTabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private ImageList imageList1;
        public TabPage tabPgCardapio;
        public TabPage tabPgComanda;
        public TabPage tabPgPedidoCozinha;
        public TabPage tabPgUsuarios;
        public TabPage tabPgMesa;
    }
}
