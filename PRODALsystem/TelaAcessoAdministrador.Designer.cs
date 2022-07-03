namespace PRODALsystem
{
    partial class TelaAcessoAdministrador
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
            this.groupBoxAcessoAdm = new System.Windows.Forms.GroupBox();
            this.groupBoxListaRequisicoesAlocacao = new System.Windows.Forms.GroupBox();
            this.cbBoxFiltroAlocacao = new System.Windows.Forms.ComboBox();
            this.lblFiltraAlocacao = new System.Windows.Forms.Label();
            this.btnBuscaAlocacao = new System.Windows.Forms.Button();
            this.txtBoxBuscaAlocacao = new System.Windows.Forms.TextBox();
            this.lblBuscaAlocacao = new System.Windows.Forms.Label();
            this.btnAutorizarAlocacao = new System.Windows.Forms.Button();
            this.btnDespacharAlocacao = new System.Windows.Forms.Button();
            this.DGVRequisicoesAlocacao = new System.Windows.Forms.DataGridView();
            this.groupBoxDadosCadastraisAdm = new System.Windows.Forms.GroupBox();
            this.txtBoxIdadeAdm = new System.Windows.Forms.TextBox();
            this.txtBoxCpfAdm = new System.Windows.Forms.TextBox();
            this.txtBoxNomeAdm = new System.Windows.Forms.TextBox();
            this.txtBoxEmailAdm = new System.Windows.Forms.TextBox();
            this.txtBoxIdAdm = new System.Windows.Forms.TextBox();
            this.lblEmailAdm = new System.Windows.Forms.Label();
            this.lblIdadeAdm = new System.Windows.Forms.Label();
            this.panelImagemAdm = new System.Windows.Forms.Panel();
            this.lblNomeAdm = new System.Windows.Forms.Label();
            this.lblCpfAdm = new System.Windows.Forms.Label();
            this.lblIdAdm = new System.Windows.Forms.Label();
            this.toolStripMenuItemAcessoAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditarCadastroAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAlteraSenha = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCadastrarUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripAcessoAdm = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemClienteAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConsultarClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemProdutoAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCadastrarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConsultarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxAcessoAdm.SuspendLayout();
            this.groupBoxListaRequisicoesAlocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequisicoesAlocacao)).BeginInit();
            this.groupBoxDadosCadastraisAdm.SuspendLayout();
            this.menuStripAcessoAdm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAcessoAdm
            // 
            this.groupBoxAcessoAdm.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxAcessoAdm.Controls.Add(this.groupBoxListaRequisicoesAlocacao);
            this.groupBoxAcessoAdm.Controls.Add(this.groupBoxDadosCadastraisAdm);
            this.groupBoxAcessoAdm.Location = new System.Drawing.Point(15, 46);
            this.groupBoxAcessoAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAcessoAdm.Name = "groupBoxAcessoAdm";
            this.groupBoxAcessoAdm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAcessoAdm.Size = new System.Drawing.Size(1095, 760);
            this.groupBoxAcessoAdm.TabIndex = 0;
            this.groupBoxAcessoAdm.TabStop = false;
            this.groupBoxAcessoAdm.Text = "Meus Dados";
            // 
            // groupBoxListaRequisicoesAlocacao
            // 
            this.groupBoxListaRequisicoesAlocacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.cbBoxFiltroAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.lblFiltraAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.btnBuscaAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.txtBoxBuscaAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.lblBuscaAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.btnAutorizarAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.btnDespacharAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Controls.Add(this.DGVRequisicoesAlocacao);
            this.groupBoxListaRequisicoesAlocacao.Location = new System.Drawing.Point(45, 288);
            this.groupBoxListaRequisicoesAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxListaRequisicoesAlocacao.Name = "groupBoxListaRequisicoesAlocacao";
            this.groupBoxListaRequisicoesAlocacao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxListaRequisicoesAlocacao.Size = new System.Drawing.Size(1005, 415);
            this.groupBoxListaRequisicoesAlocacao.TabIndex = 36;
            this.groupBoxListaRequisicoesAlocacao.TabStop = false;
            this.groupBoxListaRequisicoesAlocacao.Text = "Requisições de Alocação";
            // 
            // cbBoxFiltroAlocacao
            // 
            this.cbBoxFiltroAlocacao.FormattingEnabled = true;
            this.cbBoxFiltroAlocacao.Items.AddRange(new object[] {
            "Código da Alocação",
            "ID do Cliente"});
            this.cbBoxFiltroAlocacao.Location = new System.Drawing.Point(106, 43);
            this.cbBoxFiltroAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBoxFiltroAlocacao.Name = "cbBoxFiltroAlocacao";
            this.cbBoxFiltroAlocacao.Size = new System.Drawing.Size(148, 28);
            this.cbBoxFiltroAlocacao.TabIndex = 7;
            this.cbBoxFiltroAlocacao.MouseEnter += new System.EventHandler(this.cbBoxFiltroAlocacao_MouseEnter);
            // 
            // lblFiltraAlocacao
            // 
            this.lblFiltraAlocacao.AutoSize = true;
            this.lblFiltraAlocacao.Location = new System.Drawing.Point(18, 48);
            this.lblFiltraAlocacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltraAlocacao.Name = "lblFiltraAlocacao";
            this.lblFiltraAlocacao.Size = new System.Drawing.Size(80, 20);
            this.lblFiltraAlocacao.TabIndex = 6;
            this.lblFiltraAlocacao.Text = "Filtrar por ";
            // 
            // btnBuscaAlocacao
            // 
            this.btnBuscaAlocacao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBuscaAlocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaAlocacao.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscaAlocacao.Location = new System.Drawing.Point(946, 38);
            this.btnBuscaAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscaAlocacao.Name = "btnBuscaAlocacao";
            this.btnBuscaAlocacao.Size = new System.Drawing.Size(34, 38);
            this.btnBuscaAlocacao.TabIndex = 5;
            this.btnBuscaAlocacao.Text = "🔎";
            this.btnBuscaAlocacao.UseVisualStyleBackColor = false;
            this.btnBuscaAlocacao.Click += new System.EventHandler(this.btnBuscaAlocacao_Click);
            // 
            // txtBoxBuscaAlocacao
            // 
            this.txtBoxBuscaAlocacao.Location = new System.Drawing.Point(788, 43);
            this.txtBoxBuscaAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxBuscaAlocacao.Name = "txtBoxBuscaAlocacao";
            this.txtBoxBuscaAlocacao.Size = new System.Drawing.Size(148, 26);
            this.txtBoxBuscaAlocacao.TabIndex = 4;
            this.txtBoxBuscaAlocacao.MouseEnter += new System.EventHandler(this.txtBoxBuscaAlocacao_MouseEnter);
            // 
            // lblBuscaAlocacao
            // 
            this.lblBuscaAlocacao.AutoSize = true;
            this.lblBuscaAlocacao.Location = new System.Drawing.Point(704, 48);
            this.lblBuscaAlocacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscaAlocacao.Name = "lblBuscaAlocacao";
            this.lblBuscaAlocacao.Size = new System.Drawing.Size(59, 20);
            this.lblBuscaAlocacao.TabIndex = 3;
            this.lblBuscaAlocacao.Text = "Buscar";
            // 
            // btnAutorizarAlocacao
            // 
            this.btnAutorizarAlocacao.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAutorizarAlocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutorizarAlocacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAutorizarAlocacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAutorizarAlocacao.Location = new System.Drawing.Point(152, 352);
            this.btnAutorizarAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutorizarAlocacao.Name = "btnAutorizarAlocacao";
            this.btnAutorizarAlocacao.Size = new System.Drawing.Size(112, 38);
            this.btnAutorizarAlocacao.TabIndex = 2;
            this.btnAutorizarAlocacao.Text = "Autorizar ✔";
            this.btnAutorizarAlocacao.UseVisualStyleBackColor = false;
            // 
            // btnDespacharAlocacao
            // 
            this.btnDespacharAlocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDespacharAlocacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDespacharAlocacao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDespacharAlocacao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDespacharAlocacao.Location = new System.Drawing.Point(15, 352);
            this.btnDespacharAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDespacharAlocacao.Name = "btnDespacharAlocacao";
            this.btnDespacharAlocacao.Size = new System.Drawing.Size(128, 38);
            this.btnDespacharAlocacao.TabIndex = 1;
            this.btnDespacharAlocacao.Text = "Despachar 🗑";
            this.btnDespacharAlocacao.UseVisualStyleBackColor = false;
            // 
            // DGVRequisicoesAlocacao
            // 
            this.DGVRequisicoesAlocacao.AllowUserToDeleteRows = false;
            this.DGVRequisicoesAlocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRequisicoesAlocacao.Location = new System.Drawing.Point(15, 83);
            this.DGVRequisicoesAlocacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DGVRequisicoesAlocacao.Name = "DGVRequisicoesAlocacao";
            this.DGVRequisicoesAlocacao.ReadOnly = true;
            this.DGVRequisicoesAlocacao.Size = new System.Drawing.Size(975, 251);
            this.DGVRequisicoesAlocacao.TabIndex = 0;
            this.DGVRequisicoesAlocacao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRequisicaoAlocacoes_CellContentClick);
            // 
            // groupBoxDadosCadastraisAdm
            // 
            this.groupBoxDadosCadastraisAdm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.txtBoxIdadeAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.txtBoxCpfAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.txtBoxNomeAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.txtBoxEmailAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.txtBoxIdAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.lblEmailAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.lblIdadeAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.panelImagemAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.lblNomeAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.lblCpfAdm);
            this.groupBoxDadosCadastraisAdm.Controls.Add(this.lblIdAdm);
            this.groupBoxDadosCadastraisAdm.Location = new System.Drawing.Point(45, 46);
            this.groupBoxDadosCadastraisAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDadosCadastraisAdm.Name = "groupBoxDadosCadastraisAdm";
            this.groupBoxDadosCadastraisAdm.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxDadosCadastraisAdm.Size = new System.Drawing.Size(1005, 205);
            this.groupBoxDadosCadastraisAdm.TabIndex = 35;
            this.groupBoxDadosCadastraisAdm.TabStop = false;
            this.groupBoxDadosCadastraisAdm.Text = "Dados Cadastrais";
            // 
            // txtBoxIdadeAdm
            // 
            this.txtBoxIdadeAdm.BackColor = System.Drawing.Color.White;
            this.txtBoxIdadeAdm.Enabled = false;
            this.txtBoxIdadeAdm.Location = new System.Drawing.Point(788, 80);
            this.txtBoxIdadeAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxIdadeAdm.Name = "txtBoxIdadeAdm";
            this.txtBoxIdadeAdm.ReadOnly = true;
            this.txtBoxIdadeAdm.Size = new System.Drawing.Size(172, 26);
            this.txtBoxIdadeAdm.TabIndex = 52;
            this.txtBoxIdadeAdm.TextChanged += new System.EventHandler(this.txtBoxIdadeAdm_TextChanged);
            // 
            // txtBoxCpfAdm
            // 
            this.txtBoxCpfAdm.BackColor = System.Drawing.Color.White;
            this.txtBoxCpfAdm.Enabled = false;
            this.txtBoxCpfAdm.Location = new System.Drawing.Point(788, 118);
            this.txtBoxCpfAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxCpfAdm.Name = "txtBoxCpfAdm";
            this.txtBoxCpfAdm.ReadOnly = true;
            this.txtBoxCpfAdm.Size = new System.Drawing.Size(172, 26);
            this.txtBoxCpfAdm.TabIndex = 51;
            this.txtBoxCpfAdm.TextChanged += new System.EventHandler(this.txtBoxCpfAdm_TextChanged);
            // 
            // txtBoxNomeAdm
            // 
            this.txtBoxNomeAdm.BackColor = System.Drawing.Color.White;
            this.txtBoxNomeAdm.Enabled = false;
            this.txtBoxNomeAdm.Location = new System.Drawing.Point(304, 80);
            this.txtBoxNomeAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxNomeAdm.Name = "txtBoxNomeAdm";
            this.txtBoxNomeAdm.ReadOnly = true;
            this.txtBoxNomeAdm.Size = new System.Drawing.Size(358, 26);
            this.txtBoxNomeAdm.TabIndex = 50;
            this.txtBoxNomeAdm.TextChanged += new System.EventHandler(this.txtBoxNomeCliente_TextChanged);
            // 
            // txtBoxEmailAdm
            // 
            this.txtBoxEmailAdm.BackColor = System.Drawing.Color.White;
            this.txtBoxEmailAdm.Enabled = false;
            this.txtBoxEmailAdm.Location = new System.Drawing.Point(304, 118);
            this.txtBoxEmailAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxEmailAdm.Name = "txtBoxEmailAdm";
            this.txtBoxEmailAdm.ReadOnly = true;
            this.txtBoxEmailAdm.Size = new System.Drawing.Size(358, 26);
            this.txtBoxEmailAdm.TabIndex = 48;
            this.txtBoxEmailAdm.TextChanged += new System.EventHandler(this.txtBoxEmailAdm_TextChanged);
            // 
            // txtBoxIdAdm
            // 
            this.txtBoxIdAdm.BackColor = System.Drawing.Color.White;
            this.txtBoxIdAdm.Enabled = false;
            this.txtBoxIdAdm.Location = new System.Drawing.Point(304, 42);
            this.txtBoxIdAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxIdAdm.Name = "txtBoxIdAdm";
            this.txtBoxIdAdm.ReadOnly = true;
            this.txtBoxIdAdm.Size = new System.Drawing.Size(148, 26);
            this.txtBoxIdAdm.TabIndex = 45;
            this.txtBoxIdAdm.TextChanged += new System.EventHandler(this.txtBoxIdAdm_TextChanged);
            // 
            // lblEmailAdm
            // 
            this.lblEmailAdm.AutoSize = true;
            this.lblEmailAdm.Location = new System.Drawing.Point(194, 123);
            this.lblEmailAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAdm.Name = "lblEmailAdm";
            this.lblEmailAdm.Size = new System.Drawing.Size(65, 20);
            this.lblEmailAdm.TabIndex = 44;
            this.lblEmailAdm.Text = "E-mail : ";
            // 
            // lblIdadeAdm
            // 
            this.lblIdadeAdm.AutoSize = true;
            this.lblIdadeAdm.Location = new System.Drawing.Point(704, 85);
            this.lblIdadeAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdadeAdm.Name = "lblIdadeAdm";
            this.lblIdadeAdm.Size = new System.Drawing.Size(62, 20);
            this.lblIdadeAdm.TabIndex = 42;
            this.lblIdadeAdm.Text = "Idade : ";
            // 
            // panelImagemAdm
            // 
            this.panelImagemAdm.BackColor = System.Drawing.SystemColors.Menu;
            this.panelImagemAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImagemAdm.Location = new System.Drawing.Point(22, 42);
            this.panelImagemAdm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelImagemAdm.Name = "panelImagemAdm";
            this.panelImagemAdm.Size = new System.Drawing.Size(119, 122);
            this.panelImagemAdm.TabIndex = 41;
            // 
            // lblNomeAdm
            // 
            this.lblNomeAdm.AutoSize = true;
            this.lblNomeAdm.Location = new System.Drawing.Point(194, 85);
            this.lblNomeAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeAdm.Name = "lblNomeAdm";
            this.lblNomeAdm.Size = new System.Drawing.Size(63, 20);
            this.lblNomeAdm.TabIndex = 36;
            this.lblNomeAdm.Text = "Nome : ";
            // 
            // lblCpfAdm
            // 
            this.lblCpfAdm.AutoSize = true;
            this.lblCpfAdm.Location = new System.Drawing.Point(704, 123);
            this.lblCpfAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpfAdm.Name = "lblCpfAdm";
            this.lblCpfAdm.Size = new System.Drawing.Size(52, 20);
            this.lblCpfAdm.TabIndex = 35;
            this.lblCpfAdm.Text = "CPF : ";
            // 
            // lblIdAdm
            // 
            this.lblIdAdm.AutoSize = true;
            this.lblIdAdm.Location = new System.Drawing.Point(194, 46);
            this.lblIdAdm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdAdm.Name = "lblIdAdm";
            this.lblIdAdm.Size = new System.Drawing.Size(109, 20);
            this.lblIdAdm.TabIndex = 34;
            this.lblIdAdm.Text = "Identificador : ";
            // 
            // toolStripMenuItemAcessoAdm
            // 
            this.toolStripMenuItemAcessoAdm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEditarCadastroAdm,
            this.toolStripMenuItemAlteraSenha,
            this.toolStripMenuItemCadastrarUsuario,
            this.toolStripMenuItemSair});
            this.toolStripMenuItemAcessoAdm.Name = "toolStripMenuItemAcessoAdm";
            this.toolStripMenuItemAcessoAdm.Size = new System.Drawing.Size(120, 29);
            this.toolStripMenuItemAcessoAdm.Text = "Meu Acesso";
            // 
            // toolStripMenuItemEditarCadastroAdm
            // 
            this.toolStripMenuItemEditarCadastroAdm.Name = "toolStripMenuItemEditarCadastroAdm";
            this.toolStripMenuItemEditarCadastroAdm.Size = new System.Drawing.Size(285, 30);
            this.toolStripMenuItemEditarCadastroAdm.Text = "Editar Meu Cadastro";
            this.toolStripMenuItemEditarCadastroAdm.Click += new System.EventHandler(this.toolStripMenuItemEditarCadastroAdm_Click);
            // 
            // toolStripMenuItemAlteraSenha
            // 
            this.toolStripMenuItemAlteraSenha.Name = "toolStripMenuItemAlteraSenha";
            this.toolStripMenuItemAlteraSenha.Size = new System.Drawing.Size(285, 30);
            this.toolStripMenuItemAlteraSenha.Text = "Alterar Minha Senha";
            this.toolStripMenuItemAlteraSenha.Click += new System.EventHandler(this.toolStripMenuItemAlteraSenha_Click);
            // 
            // toolStripMenuItemCadastrarUsuario
            // 
            this.toolStripMenuItemCadastrarUsuario.Name = "toolStripMenuItemCadastrarUsuario";
            this.toolStripMenuItemCadastrarUsuario.Size = new System.Drawing.Size(285, 30);
            this.toolStripMenuItemCadastrarUsuario.Text = "Cadastrar Novo Usuário";
            this.toolStripMenuItemCadastrarUsuario.Click += new System.EventHandler(this.toolStripMenuItemCadastrarUsuario_Click);
            // 
            // toolStripMenuItemSair
            // 
            this.toolStripMenuItemSair.Name = "toolStripMenuItemSair";
            this.toolStripMenuItemSair.Size = new System.Drawing.Size(285, 30);
            this.toolStripMenuItemSair.Text = "Sair";
            this.toolStripMenuItemSair.Click += new System.EventHandler(this.toolStripMenuItemSair_Click);
            // 
            // menuStripAcessoAdm
            // 
            this.menuStripAcessoAdm.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripAcessoAdm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAcessoAdm,
            this.toolStripMenuItemClienteAdm,
            this.toolStripMenuItemProdutoAdm});
            this.menuStripAcessoAdm.Location = new System.Drawing.Point(0, 0);
            this.menuStripAcessoAdm.Name = "menuStripAcessoAdm";
            this.menuStripAcessoAdm.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStripAcessoAdm.Size = new System.Drawing.Size(1124, 35);
            this.menuStripAcessoAdm.TabIndex = 1;
            // 
            // toolStripMenuItemClienteAdm
            // 
            this.toolStripMenuItemClienteAdm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConsultarClientes});
            this.toolStripMenuItemClienteAdm.Name = "toolStripMenuItemClienteAdm";
            this.toolStripMenuItemClienteAdm.Size = new System.Drawing.Size(85, 29);
            this.toolStripMenuItemClienteAdm.Text = "Clientes";
            // 
            // toolStripMenuItemConsultarClientes
            // 
            this.toolStripMenuItemConsultarClientes.Name = "toolStripMenuItemConsultarClientes";
            this.toolStripMenuItemConsultarClientes.Size = new System.Drawing.Size(341, 30);
            this.toolStripMenuItemConsultarClientes.Text = "Consultar Clientes Cadastrados";
            this.toolStripMenuItemConsultarClientes.Click += new System.EventHandler(this.toolStripMenuItemConsultarClientes_Click);
            // 
            // toolStripMenuItemProdutoAdm
            // 
            this.toolStripMenuItemProdutoAdm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCadastrarProduto,
            this.toolStripMenuItemConsultarProdutos});
            this.toolStripMenuItemProdutoAdm.Name = "toolStripMenuItemProdutoAdm";
            this.toolStripMenuItemProdutoAdm.Size = new System.Drawing.Size(97, 29);
            this.toolStripMenuItemProdutoAdm.Text = "Produtos";
            // 
            // toolStripMenuItemCadastrarProduto
            // 
            this.toolStripMenuItemCadastrarProduto.Name = "toolStripMenuItemCadastrarProduto";
            this.toolStripMenuItemCadastrarProduto.Size = new System.Drawing.Size(353, 30);
            this.toolStripMenuItemCadastrarProduto.Text = "Cadastrar Novo Produto";
            this.toolStripMenuItemCadastrarProduto.Click += new System.EventHandler(this.toolStripMenuItemCadastrarProduto_Click);
            // 
            // toolStripMenuItemConsultarProdutos
            // 
            this.toolStripMenuItemConsultarProdutos.Name = "toolStripMenuItemConsultarProdutos";
            this.toolStripMenuItemConsultarProdutos.Size = new System.Drawing.Size(353, 30);
            this.toolStripMenuItemConsultarProdutos.Text = "Consultar Produtos Cadastrados";
            this.toolStripMenuItemConsultarProdutos.Click += new System.EventHandler(this.toolStripMenuItemConsultarProdutos_Click);
            // 
            // TelaAcessoAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1124, 829);
            this.Controls.Add(this.groupBoxAcessoAdm);
            this.Controls.Add(this.menuStripAcessoAdm);
            this.MainMenuStrip = this.menuStripAcessoAdm;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAcessoAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACESSO DO ADMINISTRADOR";
            this.groupBoxAcessoAdm.ResumeLayout(false);
            this.groupBoxListaRequisicoesAlocacao.ResumeLayout(false);
            this.groupBoxListaRequisicoesAlocacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRequisicoesAlocacao)).EndInit();
            this.groupBoxDadosCadastraisAdm.ResumeLayout(false);
            this.groupBoxDadosCadastraisAdm.PerformLayout();
            this.menuStripAcessoAdm.ResumeLayout(false);
            this.menuStripAcessoAdm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAcessoAdm;
        private System.Windows.Forms.GroupBox groupBoxDadosCadastraisAdm;
        private System.Windows.Forms.TextBox txtBoxIdadeAdm;
        private System.Windows.Forms.TextBox txtBoxNomeAdm;
        private System.Windows.Forms.TextBox txtBoxEmailAdm;
        private System.Windows.Forms.TextBox txtBoxIdAdm;
        private System.Windows.Forms.Label lblEmailAdm;
        private System.Windows.Forms.Label lblIdadeAdm;
        private System.Windows.Forms.Panel panelImagemAdm;
        private System.Windows.Forms.Label lblNomeAdm;
        private System.Windows.Forms.Label lblIdAdm;
        private System.Windows.Forms.GroupBox groupBoxListaRequisicoesAlocacao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAcessoAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditarCadastroAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSair;
        private System.Windows.Forms.MenuStrip menuStripAcessoAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemClienteAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConsultarClientes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemProdutoAdm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCadastrarProduto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConsultarProdutos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCadastrarUsuario;
        private System.Windows.Forms.DataGridView DGVRequisicoesAlocacao;
        private System.Windows.Forms.TextBox txtBoxCpfAdm;
        private System.Windows.Forms.Label lblCpfAdm;
        private System.Windows.Forms.Button btnDespacharAlocacao;
        private System.Windows.Forms.Button btnAutorizarAlocacao;
        private System.Windows.Forms.Button btnBuscaAlocacao;
        private System.Windows.Forms.TextBox txtBoxBuscaAlocacao;
        private System.Windows.Forms.Label lblBuscaAlocacao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlteraSenha;
        private System.Windows.Forms.ComboBox cbBoxFiltroAlocacao;
        private System.Windows.Forms.Label lblFiltraAlocacao;
    }
}
