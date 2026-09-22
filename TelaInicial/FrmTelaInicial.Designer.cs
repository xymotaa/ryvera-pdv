namespace Ryvera_PDV.TelaInicial
{
    partial class FrmTelaInicial
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
            MenStripTelaInicial = new MenuStrip();
            MenuCadastros = new ToolStripMenuItem();
            MenuCadFuncionarios = new ToolStripMenuItem();
            MenuCadClientes = new ToolStripMenuItem();
            MenuCadUsuarios = new ToolStripMenuItem();
            MenuCadCargos = new ToolStripMenuItem();
            MenuCadFornecedor = new ToolStripMenuItem();
            MenuProdutos = new ToolStripMenuItem();
            MenuProProdutos = new ToolStripMenuItem();
            MenuProEstoque = new ToolStripMenuItem();
            MenuMovimentações = new ToolStripMenuItem();
            MenuMovFluxoDeCaixa = new ToolStripMenuItem();
            MenuMovLancarVenda = new ToolStripMenuItem();
            MenuMovEntradaSaida = new ToolStripMenuItem();
            MenuMovDespesas = new ToolStripMenuItem();
            MenuRelatórios = new ToolStripMenuItem();
            MenuRelVendas = new ToolStripMenuItem();
            MenuRelEstoque = new ToolStripMenuItem();
            MenuRelFinanceiro = new ToolStripMenuItem();
            MenuRelMovimentos = new ToolStripMenuItem();
            MenuRelDespesas = new ToolStripMenuItem();
            MenuRelEntradaSaida = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            ImgCaixa = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            MenStripTelaInicial.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgCaixa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenStripTelaInicial
            // 
            MenStripTelaInicial.BackColor = SystemColors.Control;
            MenStripTelaInicial.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenStripTelaInicial.Items.AddRange(new ToolStripItem[] { MenuCadastros, MenuMovimentações, MenuProdutos, MenuRelatórios, sairToolStripMenuItem });
            MenStripTelaInicial.Location = new Point(0, 0);
            MenStripTelaInicial.Name = "MenStripTelaInicial";
            MenStripTelaInicial.Size = new Size(800, 24);
            MenStripTelaInicial.TabIndex = 0;
            MenStripTelaInicial.Text = "MenStripTelaIinicial";
            // 
            // MenuCadastros
            // 
            MenuCadastros.DropDownItems.AddRange(new ToolStripItem[] { MenuCadFuncionarios, MenuCadClientes, MenuCadUsuarios, MenuCadCargos, MenuCadFornecedor });
            MenuCadastros.Name = "MenuCadastros";
            MenuCadastros.Size = new Size(82, 20);
            MenuCadastros.Text = "Cadastros";
            // 
            // MenuCadFuncionarios
            // 
            MenuCadFuncionarios.Name = "MenuCadFuncionarios";
            MenuCadFuncionarios.Size = new Size(180, 22);
            MenuCadFuncionarios.Text = "Funcionários";
            // 
            // MenuCadClientes
            // 
            MenuCadClientes.Name = "MenuCadClientes";
            MenuCadClientes.Size = new Size(180, 22);
            MenuCadClientes.Text = "Clientes";
            // 
            // MenuCadUsuarios
            // 
            MenuCadUsuarios.Name = "MenuCadUsuarios";
            MenuCadUsuarios.Size = new Size(180, 22);
            MenuCadUsuarios.Text = "Usuários";
            // 
            // MenuCadCargos
            // 
            MenuCadCargos.Name = "MenuCadCargos";
            MenuCadCargos.Size = new Size(180, 22);
            MenuCadCargos.Text = "Cargos";
            // 
            // MenuCadFornecedor
            // 
            MenuCadFornecedor.Name = "MenuCadFornecedor";
            MenuCadFornecedor.Size = new Size(180, 22);
            MenuCadFornecedor.Text = "Fornecedor";
            // 
            // MenuProdutos
            // 
            MenuProdutos.DropDownItems.AddRange(new ToolStripItem[] { MenuProProdutos, MenuProEstoque });
            MenuProdutos.Name = "MenuProdutos";
            MenuProdutos.Size = new Size(75, 20);
            MenuProdutos.Text = "Produtos";
            // 
            // MenuProProdutos
            // 
            MenuProProdutos.Name = "MenuProProdutos";
            MenuProProdutos.Size = new Size(180, 22);
            MenuProProdutos.Text = "Produtos";
            // 
            // MenuProEstoque
            // 
            MenuProEstoque.Name = "MenuProEstoque";
            MenuProEstoque.Size = new Size(180, 22);
            MenuProEstoque.Text = "Estoque";
            // 
            // MenuMovimentações
            // 
            MenuMovimentações.DropDownItems.AddRange(new ToolStripItem[] { MenuMovFluxoDeCaixa, MenuMovLancarVenda, MenuMovEntradaSaida, MenuMovDespesas });
            MenuMovimentações.Name = "MenuMovimentações";
            MenuMovimentações.Size = new Size(110, 20);
            MenuMovimentações.Text = "Movimentaçôes";
            // 
            // MenuMovFluxoDeCaixa
            // 
            MenuMovFluxoDeCaixa.Name = "MenuMovFluxoDeCaixa";
            MenuMovFluxoDeCaixa.Size = new Size(193, 22);
            MenuMovFluxoDeCaixa.Text = "Fluxo de Caixa";
            // 
            // MenuMovLancarVenda
            // 
            MenuMovLancarVenda.Name = "MenuMovLancarVenda";
            MenuMovLancarVenda.Size = new Size(193, 22);
            MenuMovLancarVenda.Text = "Lançar Venda";
            // 
            // MenuMovEntradaSaida
            // 
            MenuMovEntradaSaida.Name = "MenuMovEntradaSaida";
            MenuMovEntradaSaida.Size = new Size(193, 22);
            MenuMovEntradaSaida.Text = "Entradas / Saídas";
            // 
            // MenuMovDespesas
            // 
            MenuMovDespesas.Name = "MenuMovDespesas";
            MenuMovDespesas.Size = new Size(193, 22);
            MenuMovDespesas.Text = "Despesas";
            // 
            // MenuRelatórios
            // 
            MenuRelatórios.DropDownItems.AddRange(new ToolStripItem[] { MenuRelVendas, MenuRelEstoque, MenuRelFinanceiro, MenuRelMovimentos, MenuRelDespesas, MenuRelEntradaSaida });
            MenuRelatórios.Name = "MenuRelatórios";
            MenuRelatórios.Size = new Size(89, 20);
            MenuRelatórios.Text = "Relatórios";
            // 
            // MenuRelVendas
            // 
            MenuRelVendas.Name = "MenuRelVendas";
            MenuRelVendas.Size = new Size(193, 22);
            MenuRelVendas.Text = "Vendas";
            // 
            // MenuRelEstoque
            // 
            MenuRelEstoque.Name = "MenuRelEstoque";
            MenuRelEstoque.Size = new Size(193, 22);
            MenuRelEstoque.Text = "Estoque";
            // 
            // MenuRelFinanceiro
            // 
            MenuRelFinanceiro.Name = "MenuRelFinanceiro";
            MenuRelFinanceiro.Size = new Size(193, 22);
            MenuRelFinanceiro.Text = "Financeiro";
            // 
            // MenuRelMovimentos
            // 
            MenuRelMovimentos.Name = "MenuRelMovimentos";
            MenuRelMovimentos.Size = new Size(193, 22);
            MenuRelMovimentos.Text = "Movimentos";
            // 
            // MenuRelDespesas
            // 
            MenuRelDespesas.Name = "MenuRelDespesas";
            MenuRelDespesas.Size = new Size(193, 22);
            MenuRelDespesas.Text = "Despesas";
            // 
            // MenuRelEntradaSaida
            // 
            MenuRelEntradaSaida.Name = "MenuRelEntradaSaida";
            MenuRelEntradaSaida.Size = new Size(193, 22);
            MenuRelEntradaSaida.Text = "Entradas / Saidas";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(47, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2169342F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2184162F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.2184582F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1153984F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1153984F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.1153984F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 2, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(ImgCaixa, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Location = new Point(12, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.1506119F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.3690486F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.6369133F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.8434238F));
            tableLayoutPanel1.Size = new Size(776, 411);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fluxo_de_caixa;
            pictureBox1.Location = new Point(121, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // ImgCaixa
            // 
            ImgCaixa.Image = Properties.Resources.carrinho_de_compras;
            ImgCaixa.Location = new Point(3, 3);
            ImgCaixa.Name = "ImgCaixa";
            ImgCaixa.Size = new Size(108, 86);
            ImgCaixa.SizeMode = PictureBoxSizeMode.Zoom;
            ImgCaixa.TabIndex = 0;
            ImgCaixa.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 99);
            label1.Name = "label1";
            label1.Size = new Size(91, 14);
            label1.TabIndex = 2;
            label1.Text = "Lançar Venda";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(124, 99);
            label2.Name = "label2";
            label2.Size = new Size(105, 14);
            label2.TabIndex = 3;
            label2.Text = "Fluxo de Caixa";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(267, 99);
            label3.Name = "label3";
            label3.Size = new Size(56, 14);
            label3.TabIndex = 4;
            label3.Text = "Estoque";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.armazenar;
            pictureBox2.Location = new Point(239, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // FrmTelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(MenStripTelaInicial);
            MainMenuStrip = MenStripTelaInicial;
            Name = "FrmTelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Inicial";
            MenStripTelaInicial.ResumeLayout(false);
            MenStripTelaInicial.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgCaixa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenStripTelaInicial;
        private ToolStripMenuItem MenuCadastros;
        private ToolStripMenuItem MenuCadFuncionarios;
        private ToolStripMenuItem MenuCadClientes;
        private ToolStripMenuItem MenuRelatórios;
        private ToolStripMenuItem MenuRelVendas;
        private ToolStripMenuItem MenuRelEstoque;
        private ToolStripMenuItem MenuRelFinanceiro;
        private ToolStripMenuItem MenuProdutos;
        private ToolStripMenuItem MenuMovimentações;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem MenuCadUsuarios;
        private ToolStripMenuItem MenuCadCargos;
        private ToolStripMenuItem MenuCadFornecedor;
        private ToolStripMenuItem MenuProProdutos;
        private ToolStripMenuItem MenuProEstoque;
        private ToolStripMenuItem MenuMovFluxoDeCaixa;
        private ToolStripMenuItem MenuMovLancarVenda;
        private ToolStripMenuItem MenuMovEntradaSaida;
        private ToolStripMenuItem MenuMovDespesas;
        private ToolStripMenuItem MenuRelMovimentos;
        private ToolStripMenuItem MenuRelDespesas;
        private ToolStripMenuItem MenuRelEntradaSaida;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox ImgCaixa;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
    }
}