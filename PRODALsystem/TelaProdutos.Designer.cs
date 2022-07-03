namespace PRODALsystem
{
    partial class TelaProdutos
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
            this.groupBoxListagemProdutos = new System.Windows.Forms.GroupBox();
            this.groupBoxListaProdutos = new System.Windows.Forms.GroupBox();
            this.cbBoxFiltroProdutos = new System.Windows.Forms.ComboBox();
            this.btnPesquisaListaProdutos = new System.Windows.Forms.Button();
            this.txtBoxBuscaProduto = new System.Windows.Forms.TextBox();
            this.lblPesquisaListaProdutos = new System.Windows.Forms.Label();
            this.lblFiltroProdutos = new System.Windows.Forms.Label();
            this.DGVListaProdutos = new System.Windows.Forms.DataGridView();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.panelDescricaoProduto = new System.Windows.Forms.Panel();
            this.panelDescricaoImagemProduto = new System.Windows.Forms.Panel();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.txtBoxDescricaoDataCadastroProduto = new System.Windows.Forms.TextBox();
            this.txtBoxDescricaoQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.txtBoxDescricaoStatusProduto = new System.Windows.Forms.TextBox();
            this.txtBoxDescricaoIdProduto = new System.Windows.Forms.TextBox();
            this.lblDescricaoDataCadastro = new System.Windows.Forms.Label();
            this.lblDescricaoQuantidadeProduto = new System.Windows.Forms.Label();
            this.lblDescricaoStatusProduto = new System.Windows.Forms.Label();
            this.lblDescricaoIdProduto = new System.Windows.Forms.Label();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.lblDescricaoTituloProduto = new System.Windows.Forms.Label();
            this.lblMensagemVisualizacao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsMenuItemAcessoProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxListagemProdutos.SuspendLayout();
            this.groupBoxListaProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProdutos)).BeginInit();
            this.panelDescricaoProduto.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxListagemProdutos
            // 
            this.groupBoxListagemProdutos.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxListagemProdutos.Controls.Add(this.groupBoxListaProdutos);
            this.groupBoxListagemProdutos.Controls.Add(this.btnCadastrarProduto);
            this.groupBoxListagemProdutos.Controls.Add(this.panelDescricaoProduto);
            this.groupBoxListagemProdutos.Controls.Add(this.lblMensagemVisualizacao);
            this.groupBoxListagemProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxListagemProdutos.Location = new System.Drawing.Point(15, 46);
            this.groupBoxListagemProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxListagemProdutos.Name = "groupBoxListagemProdutos";
            this.groupBoxListagemProdutos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxListagemProdutos.Size = new System.Drawing.Size(1125, 585);
            this.groupBoxListagemProdutos.TabIndex = 0;
            this.groupBoxListagemProdutos.TabStop = false;
            this.groupBoxListagemProdutos.Text = "Produtos Cadastrados";
            // 
            // groupBoxListaProdutos
            // 
            this.groupBoxListaProdutos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxListaProdutos.Controls.Add(this.cbBoxFiltroProdutos);
            this.groupBoxListaProdutos.Controls.Add(this.btnPesquisaListaProdutos);
            this.groupBoxListaProdutos.Controls.Add(this.txtBoxBuscaProduto);
            this.groupBoxListaProdutos.Controls.Add(this.lblPesquisaListaProdutos);
            this.groupBoxListaProdutos.Controls.Add(this.lblFiltroProdutos);
            this.groupBoxListaProdutos.Controls.Add(this.DGVListaProdutos);
            this.groupBoxListaProdutos.Location = new System.Drawing.Point(22, 120);
            this.groupBoxListaProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxListaProdutos.Name = "groupBoxListaProdutos";
            this.groupBoxListaProdutos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxListaProdutos.Size = new System.Drawing.Size(687, 369);
            this.groupBoxListaProdutos.TabIndex = 11;
            this.groupBoxListaProdutos.TabStop = false;
            this.groupBoxListaProdutos.Text = "Lista de Produtos";
            // 
            // cbBoxFiltroProdutos
            // 
            this.cbBoxFiltroProdutos.FormattingEnabled = true;
            this.cbBoxFiltroProdutos.Items.AddRange(new object[] {
            "Código",
            "Título",
            "Data de Cadastro"});
            this.cbBoxFiltroProdutos.Location = new System.Drawing.Point(96, 51);
            this.cbBoxFiltroProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoxFiltroProdutos.Name = "cbBoxFiltroProdutos";
            this.cbBoxFiltroProdutos.Size = new System.Drawing.Size(133, 28);
            this.cbBoxFiltroProdutos.TabIndex = 16;
            this.cbBoxFiltroProdutos.MouseEnter += new System.EventHandler(this.cbBoxFiltroProdutos_MouseEnter);
            // 
            // btnPesquisaListaProdutos
            // 
            this.btnPesquisaListaProdutos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisaListaProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisaListaProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPesquisaListaProdutos.ForeColor = System.Drawing.Color.Navy;
            this.btnPesquisaListaProdutos.Location = new System.Drawing.Point(652, 51);
            this.btnPesquisaListaProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPesquisaListaProdutos.Name = "btnPesquisaListaProdutos";
            this.btnPesquisaListaProdutos.Size = new System.Drawing.Size(26, 31);
            this.btnPesquisaListaProdutos.TabIndex = 15;
            this.btnPesquisaListaProdutos.Text = "🔎";
            this.btnPesquisaListaProdutos.UseVisualStyleBackColor = false;
            this.btnPesquisaListaProdutos.Click += new System.EventHandler(this.btnPesquisaListaProdutos_Click);
            // 
            // txtBoxBuscaProduto
            // 
            this.txtBoxBuscaProduto.Location = new System.Drawing.Point(494, 51);
            this.txtBoxBuscaProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxBuscaProduto.Name = "txtBoxBuscaProduto";
            this.txtBoxBuscaProduto.Size = new System.Drawing.Size(148, 26);
            this.txtBoxBuscaProduto.TabIndex = 14;
            this.txtBoxBuscaProduto.MouseEnter += new System.EventHandler(this.txtBoxPesquisaListaProdutos_MouseEnter);
            // 
            // lblPesquisaListaProdutos
            // 
            this.lblPesquisaListaProdutos.AutoSize = true;
            this.lblPesquisaListaProdutos.Location = new System.Drawing.Point(405, 55);
            this.lblPesquisaListaProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesquisaListaProdutos.Name = "lblPesquisaListaProdutos";
            this.lblPesquisaListaProdutos.Size = new System.Drawing.Size(84, 20);
            this.lblPesquisaListaProdutos.TabIndex = 13;
            this.lblPesquisaListaProdutos.Text = "Pesquisar";
            // 
            // lblFiltroProdutos
            // 
            this.lblFiltroProdutos.AutoSize = true;
            this.lblFiltroProdutos.Location = new System.Drawing.Point(12, 55);
            this.lblFiltroProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroProdutos.Name = "lblFiltroProdutos";
            this.lblFiltroProdutos.Size = new System.Drawing.Size(97, 20);
            this.lblFiltroProdutos.TabIndex = 12;
            this.lblFiltroProdutos.Text = "Filtrar por : ";
            // 
            // DGVListaProdutos
            // 
            this.DGVListaProdutos.AllowUserToDeleteRows = false;
            this.DGVListaProdutos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.DGVListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaProdutos.Location = new System.Drawing.Point(14, 86);
            this.DGVListaProdutos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVListaProdutos.Name = "DGVListaProdutos";
            this.DGVListaProdutos.ReadOnly = true;
            this.DGVListaProdutos.Size = new System.Drawing.Size(664, 218);
            this.DGVListaProdutos.TabIndex = 11;
            this.DGVListaProdutos.SelectionChanged += new System.EventHandler(this.DGVListaProdutos_SelectionChanged);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.Color.Green;
            this.btnCadastrarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(808, 512);
            this.btnCadastrarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnCadastrarProduto.Size = new System.Drawing.Size(300, 38);
            this.btnCadastrarProduto.TabIndex = 4;
            this.btnCadastrarProduto.Text = "Cadastrar Novo Produto ➕";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // panelDescricaoProduto
            // 
            this.panelDescricaoProduto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelDescricaoProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescricaoProduto.Controls.Add(this.panelDescricaoImagemProduto);
            this.panelDescricaoProduto.Controls.Add(this.btnExcluirProduto);
            this.panelDescricaoProduto.Controls.Add(this.txtBoxDescricaoDataCadastroProduto);
            this.panelDescricaoProduto.Controls.Add(this.txtBoxDescricaoQuantidadeProduto);
            this.panelDescricaoProduto.Controls.Add(this.txtBoxDescricaoStatusProduto);
            this.panelDescricaoProduto.Controls.Add(this.txtBoxDescricaoIdProduto);
            this.panelDescricaoProduto.Controls.Add(this.lblDescricaoDataCadastro);
            this.panelDescricaoProduto.Controls.Add(this.lblDescricaoQuantidadeProduto);
            this.panelDescricaoProduto.Controls.Add(this.lblDescricaoStatusProduto);
            this.panelDescricaoProduto.Controls.Add(this.lblDescricaoIdProduto);
            this.panelDescricaoProduto.Controls.Add(this.btnEditarProduto);
            this.panelDescricaoProduto.Controls.Add(this.lblDescricaoTituloProduto);
            this.panelDescricaoProduto.Location = new System.Drawing.Point(718, 120);
            this.panelDescricaoProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDescricaoProduto.Name = "panelDescricaoProduto";
            this.panelDescricaoProduto.Size = new System.Drawing.Size(389, 368);
            this.panelDescricaoProduto.TabIndex = 3;
            // 
            // panelDescricaoImagemProduto
            // 
            this.panelDescricaoImagemProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.panelDescricaoImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDescricaoImagemProduto.Location = new System.Drawing.Point(30, 31);
            this.panelDescricaoImagemProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelDescricaoImagemProduto.Name = "panelDescricaoImagemProduto";
            this.panelDescricaoImagemProduto.Size = new System.Drawing.Size(89, 91);
            this.panelDescricaoImagemProduto.TabIndex = 14;
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluirProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirProduto.ForeColor = System.Drawing.Color.White;
            this.btnExcluirProduto.Location = new System.Drawing.Point(75, 308);
            this.btnExcluirProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnExcluirProduto.Size = new System.Drawing.Size(112, 38);
            this.btnExcluirProduto.TabIndex = 5;
            this.btnExcluirProduto.Text = "Excluir ❌";
            this.btnExcluirProduto.UseVisualStyleBackColor = false;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // txtBoxDescricaoDataCadastroProduto
            // 
            this.txtBoxDescricaoDataCadastroProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDescricaoDataCadastroProduto.Enabled = false;
            this.txtBoxDescricaoDataCadastroProduto.Location = new System.Drawing.Point(184, 226);
            this.txtBoxDescricaoDataCadastroProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDescricaoDataCadastroProduto.Name = "txtBoxDescricaoDataCadastroProduto";
            this.txtBoxDescricaoDataCadastroProduto.Size = new System.Drawing.Size(163, 26);
            this.txtBoxDescricaoDataCadastroProduto.TabIndex = 12;
            // 
            // txtBoxDescricaoQuantidadeProduto
            // 
            this.txtBoxDescricaoQuantidadeProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDescricaoQuantidadeProduto.Enabled = false;
            this.txtBoxDescricaoQuantidadeProduto.Location = new System.Drawing.Point(184, 188);
            this.txtBoxDescricaoQuantidadeProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDescricaoQuantidadeProduto.Name = "txtBoxDescricaoQuantidadeProduto";
            this.txtBoxDescricaoQuantidadeProduto.Size = new System.Drawing.Size(163, 26);
            this.txtBoxDescricaoQuantidadeProduto.TabIndex = 11;
            // 
            // txtBoxDescricaoStatusProduto
            // 
            this.txtBoxDescricaoStatusProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDescricaoStatusProduto.Enabled = false;
            this.txtBoxDescricaoStatusProduto.Location = new System.Drawing.Point(184, 149);
            this.txtBoxDescricaoStatusProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDescricaoStatusProduto.Name = "txtBoxDescricaoStatusProduto";
            this.txtBoxDescricaoStatusProduto.Size = new System.Drawing.Size(163, 26);
            this.txtBoxDescricaoStatusProduto.TabIndex = 10;
            // 
            // txtBoxDescricaoIdProduto
            // 
            this.txtBoxDescricaoIdProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDescricaoIdProduto.Enabled = false;
            this.txtBoxDescricaoIdProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBoxDescricaoIdProduto.Location = new System.Drawing.Point(260, 80);
            this.txtBoxDescricaoIdProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxDescricaoIdProduto.Name = "txtBoxDescricaoIdProduto";
            this.txtBoxDescricaoIdProduto.ReadOnly = true;
            this.txtBoxDescricaoIdProduto.Size = new System.Drawing.Size(88, 26);
            this.txtBoxDescricaoIdProduto.TabIndex = 9;
            // 
            // lblDescricaoDataCadastro
            // 
            this.lblDescricaoDataCadastro.AutoSize = true;
            this.lblDescricaoDataCadastro.Location = new System.Drawing.Point(30, 231);
            this.lblDescricaoDataCadastro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoDataCadastro.Name = "lblDescricaoDataCadastro";
            this.lblDescricaoDataCadastro.Size = new System.Drawing.Size(156, 20);
            this.lblDescricaoDataCadastro.TabIndex = 8;
            this.lblDescricaoDataCadastro.Text = "Data de Cadastro : ";
            // 
            // lblDescricaoQuantidadeProduto
            // 
            this.lblDescricaoQuantidadeProduto.AutoSize = true;
            this.lblDescricaoQuantidadeProduto.Location = new System.Drawing.Point(30, 192);
            this.lblDescricaoQuantidadeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoQuantidadeProduto.Name = "lblDescricaoQuantidadeProduto";
            this.lblDescricaoQuantidadeProduto.Size = new System.Drawing.Size(109, 20);
            this.lblDescricaoQuantidadeProduto.TabIndex = 7;
            this.lblDescricaoQuantidadeProduto.Text = "Quantidade : ";
            // 
            // lblDescricaoStatusProduto
            // 
            this.lblDescricaoStatusProduto.AutoSize = true;
            this.lblDescricaoStatusProduto.Location = new System.Drawing.Point(30, 154);
            this.lblDescricaoStatusProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoStatusProduto.Name = "lblDescricaoStatusProduto";
            this.lblDescricaoStatusProduto.Size = new System.Drawing.Size(72, 20);
            this.lblDescricaoStatusProduto.TabIndex = 6;
            this.lblDescricaoStatusProduto.Text = "Status : ";
            // 
            // lblDescricaoIdProduto
            // 
            this.lblDescricaoIdProduto.AutoSize = true;
            this.lblDescricaoIdProduto.Location = new System.Drawing.Point(135, 85);
            this.lblDescricaoIdProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoIdProduto.Name = "lblDescricaoIdProduto";
            this.lblDescricaoIdProduto.Size = new System.Drawing.Size(127, 20);
            this.lblDescricaoIdProduto.TabIndex = 5;
            this.lblDescricaoIdProduto.Text = "ID do Produto : ";
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProduto.ForeColor = System.Drawing.Color.White;
            this.btnEditarProduto.Location = new System.Drawing.Point(210, 308);
            this.btnEditarProduto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.btnEditarProduto.Size = new System.Drawing.Size(112, 38);
            this.btnEditarProduto.TabIndex = 4;
            this.btnEditarProduto.Text = "Editar ✏";
            this.btnEditarProduto.UseVisualStyleBackColor = false;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // lblDescricaoTituloProduto
            // 
            this.lblDescricaoTituloProduto.AutoSize = true;
            this.lblDescricaoTituloProduto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDescricaoTituloProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoTituloProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescricaoTituloProduto.Location = new System.Drawing.Point(135, 38);
            this.lblDescricaoTituloProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricaoTituloProduto.Name = "lblDescricaoTituloProduto";
            this.lblDescricaoTituloProduto.Size = new System.Drawing.Size(228, 20);
            this.lblDescricaoTituloProduto.TabIndex = 0;
            this.lblDescricaoTituloProduto.Text = "< NOME DO PRODUTO >";
            // 
            // lblMensagemVisualizacao
            // 
            this.lblMensagemVisualizacao.AutoSize = true;
            this.lblMensagemVisualizacao.Location = new System.Drawing.Point(327, 52);
            this.lblMensagemVisualizacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensagemVisualizacao.Name = "lblMensagemVisualizacao";
            this.lblMensagemVisualizacao.Size = new System.Drawing.Size(542, 20);
            this.lblMensagemVisualizacao.TabIndex = 0;
            this.lblMensagemVisualizacao.Text = "Clique em algum dos campos abaixo para consultar o produto desejado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMenuItemAcessoProdutos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1156, 35);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsMenuItemAcessoProdutos
            // 
            this.tsMenuItemAcessoProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.tsMenuItemAcessoProdutos.Name = "tsMenuItemAcessoProdutos";
            this.tsMenuItemAcessoProdutos.Size = new System.Drawing.Size(80, 29);
            this.tsMenuItemAcessoProdutos.Text = "Acesso";
            this.tsMenuItemAcessoProdutos.Click += new System.EventHandler(this.tsMenuItemAcessoProdutos_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(147, 30);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // TelaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1156, 640);
            this.Controls.Add(this.groupBoxListagemProdutos);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LISTA DE PRODUTOS";
            this.groupBoxListagemProdutos.ResumeLayout(false);
            this.groupBoxListagemProdutos.PerformLayout();
            this.groupBoxListaProdutos.ResumeLayout(false);
            this.groupBoxListaProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaProdutos)).EndInit();
            this.panelDescricaoProduto.ResumeLayout(false);
            this.panelDescricaoProduto.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxListagemProdutos;
        private System.Windows.Forms.Label lblMensagemVisualizacao;
        private System.Windows.Forms.Panel panelDescricaoProduto;
        private System.Windows.Forms.Label lblDescricaoTituloProduto;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Label lblDescricaoDataCadastro;
        private System.Windows.Forms.Label lblDescricaoQuantidadeProduto;
        private System.Windows.Forms.Label lblDescricaoStatusProduto;
        private System.Windows.Forms.Label lblDescricaoIdProduto;
        private System.Windows.Forms.TextBox txtBoxDescricaoDataCadastroProduto;
        private System.Windows.Forms.TextBox txtBoxDescricaoQuantidadeProduto;
        private System.Windows.Forms.TextBox txtBoxDescricaoStatusProduto;
        private System.Windows.Forms.TextBox txtBoxDescricaoIdProduto;
        private System.Windows.Forms.Panel panelDescricaoImagemProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsMenuItemAcessoProdutos;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxListaProdutos;
        private System.Windows.Forms.Button btnPesquisaListaProdutos;
        private System.Windows.Forms.TextBox txtBoxBuscaProduto;
        private System.Windows.Forms.Label lblPesquisaListaProdutos;
        private System.Windows.Forms.Label lblFiltroProdutos;
        private System.Windows.Forms.DataGridView DGVListaProdutos;
        private System.Windows.Forms.ComboBox cbBoxFiltroProdutos;
    }
}