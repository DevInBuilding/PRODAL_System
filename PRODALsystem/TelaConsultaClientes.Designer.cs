namespace PRODALsystem
{
    partial class TelaConsultaClientes
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
            this.groupBoxConsultaClientes = new System.Windows.Forms.GroupBox();
            this.groupBoxListaClientes = new System.Windows.Forms.GroupBox();
            this.btnAtualizarLista = new System.Windows.Forms.Button();
            this.cbBoxFiltroConsulta = new System.Windows.Forms.ComboBox();
            this.lblFiltroConsultaCliente = new System.Windows.Forms.Label();
            this.btnAtivarInativarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.txtBoxBuscaCliente = new System.Windows.Forms.TextBox();
            this.lblBuscaCliente = new System.Windows.Forms.Label();
            this.DGVListaClientes = new System.Windows.Forms.DataGridView();
            this.groupBoxDadosCliente = new System.Windows.Forms.GroupBox();
            this.txtBoxIdadeCliente = new System.Windows.Forms.TextBox();
            this.txtBoxStatusCliente = new System.Windows.Forms.TextBox();
            this.lblIdadeCliente = new System.Windows.Forms.Label();
            this.lblStatusCliente = new System.Windows.Forms.Label();
            this.panelImagemCliente = new System.Windows.Forms.Panel();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.txtBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.txtBoxCpfCliente = new System.Windows.Forms.TextBox();
            this.txtBoxIdCliente = new System.Windows.Forms.TextBox();
            this.txtBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.menuStripConsultaClientes = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAcessoConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxConsultaClientes.SuspendLayout();
            this.groupBoxListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaClientes)).BeginInit();
            this.groupBoxDadosCliente.SuspendLayout();
            this.menuStripConsultaClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConsultaClientes
            // 
            this.groupBoxConsultaClientes.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxConsultaClientes.Controls.Add(this.groupBoxListaClientes);
            this.groupBoxConsultaClientes.Controls.Add(this.groupBoxDadosCliente);
            this.groupBoxConsultaClientes.Location = new System.Drawing.Point(10, 30);
            this.groupBoxConsultaClientes.Name = "groupBoxConsultaClientes";
            this.groupBoxConsultaClientes.Size = new System.Drawing.Size(646, 425);
            this.groupBoxConsultaClientes.TabIndex = 0;
            this.groupBoxConsultaClientes.TabStop = false;
            this.groupBoxConsultaClientes.Text = "Dados de Consulta";
            // 
            // groupBoxListaClientes
            // 
            this.groupBoxListaClientes.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxListaClientes.Controls.Add(this.btnAtualizarLista);
            this.groupBoxListaClientes.Controls.Add(this.cbBoxFiltroConsulta);
            this.groupBoxListaClientes.Controls.Add(this.lblFiltroConsultaCliente);
            this.groupBoxListaClientes.Controls.Add(this.btnAtivarInativarCliente);
            this.groupBoxListaClientes.Controls.Add(this.btnExcluirCliente);
            this.groupBoxListaClientes.Controls.Add(this.btnPesquisaCliente);
            this.groupBoxListaClientes.Controls.Add(this.txtBoxBuscaCliente);
            this.groupBoxListaClientes.Controls.Add(this.lblBuscaCliente);
            this.groupBoxListaClientes.Controls.Add(this.DGVListaClientes);
            this.groupBoxListaClientes.Location = new System.Drawing.Point(18, 177);
            this.groupBoxListaClientes.Name = "groupBoxListaClientes";
            this.groupBoxListaClientes.Size = new System.Drawing.Size(600, 222);
            this.groupBoxListaClientes.TabIndex = 1;
            this.groupBoxListaClientes.TabStop = false;
            this.groupBoxListaClientes.Text = "Lista de Clientes";
            // 
            // btnAtualizarLista
            // 
            this.btnAtualizarLista.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAtualizarLista.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizarLista.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizarLista.ForeColor = System.Drawing.Color.White;
            this.btnAtualizarLista.Location = new System.Drawing.Point(502, 180);
            this.btnAtualizarLista.Name = "btnAtualizarLista";
            this.btnAtualizarLista.Size = new System.Drawing.Size(75, 25);
            this.btnAtualizarLista.TabIndex = 8;
            this.btnAtualizarLista.Text = "Editar ✏";
            this.btnAtualizarLista.UseVisualStyleBackColor = false;
            this.btnAtualizarLista.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // cbBoxFiltroConsulta
            // 
            this.cbBoxFiltroConsulta.FormattingEnabled = true;
            this.cbBoxFiltroConsulta.Items.AddRange(new object[] {
            "Nº Cadastro",
            "Nome",
            "CPF"});
            this.cbBoxFiltroConsulta.Location = new System.Drawing.Point(93, 19);
            this.cbBoxFiltroConsulta.Name = "cbBoxFiltroConsulta";
            this.cbBoxFiltroConsulta.Size = new System.Drawing.Size(121, 21);
            this.cbBoxFiltroConsulta.TabIndex = 7;
            this.cbBoxFiltroConsulta.MouseEnter += new System.EventHandler(this.cbBoxFiltroConsulta_MouseEnter);
            // 
            // lblFiltroConsultaCliente
            // 
            this.lblFiltroConsultaCliente.AutoSize = true;
            this.lblFiltroConsultaCliente.Location = new System.Drawing.Point(28, 22);
            this.lblFiltroConsultaCliente.Name = "lblFiltroConsultaCliente";
            this.lblFiltroConsultaCliente.Size = new System.Drawing.Size(59, 13);
            this.lblFiltroConsultaCliente.TabIndex = 6;
            this.lblFiltroConsultaCliente.Text = "Filtrar por : ";
            // 
            // btnAtivarInativarCliente
            // 
            this.btnAtivarInativarCliente.BackColor = System.Drawing.Color.Purple;
            this.btnAtivarInativarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtivarInativarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtivarInativarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtivarInativarCliente.Location = new System.Drawing.Point(101, 180);
            this.btnAtivarInativarCliente.Name = "btnAtivarInativarCliente";
            this.btnAtivarInativarCliente.Size = new System.Drawing.Size(75, 25);
            this.btnAtivarInativarCliente.TabIndex = 5;
            this.btnAtivarInativarCliente.Text = "Inativar 🚫";
            this.btnAtivarInativarCliente.UseVisualStyleBackColor = false;
            this.btnAtivarInativarCliente.Click += new System.EventHandler(this.btnAtivarInativarCliente_Click);
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.BackColor = System.Drawing.Color.DarkRed;
            this.btnExcluirCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluirCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExcluirCliente.Location = new System.Drawing.Point(20, 180);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(75, 25);
            this.btnExcluirCliente.TabIndex = 4;
            this.btnExcluirCliente.Text = "Excluir 🗑";
            this.btnExcluirCliente.UseVisualStyleBackColor = false;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisaCliente.ForeColor = System.Drawing.Color.Navy;
            this.btnPesquisaCliente.Location = new System.Drawing.Point(557, 17);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(20, 23);
            this.btnPesquisaCliente.TabIndex = 3;
            this.btnPesquisaCliente.Text = "🔎";
            this.btnPesquisaCliente.UseVisualStyleBackColor = false;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // txtBoxBuscaCliente
            // 
            this.txtBoxBuscaCliente.Location = new System.Drawing.Point(454, 19);
            this.txtBoxBuscaCliente.Name = "txtBoxBuscaCliente";
            this.txtBoxBuscaCliente.Size = new System.Drawing.Size(100, 20);
            this.txtBoxBuscaCliente.TabIndex = 2;
            this.txtBoxBuscaCliente.MouseEnter += new System.EventHandler(this.txtBoxBuscaCliente_MouseEnter);
            // 
            // lblBuscaCliente
            // 
            this.lblBuscaCliente.AutoSize = true;
            this.lblBuscaCliente.Location = new System.Drawing.Point(399, 22);
            this.lblBuscaCliente.Name = "lblBuscaCliente";
            this.lblBuscaCliente.Size = new System.Drawing.Size(49, 13);
            this.lblBuscaCliente.TabIndex = 1;
            this.lblBuscaCliente.Text = "Buscar : ";
            // 
            // DGVListaClientes
            // 
            this.DGVListaClientes.AllowUserToDeleteRows = false;
            this.DGVListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVListaClientes.Location = new System.Drawing.Point(20, 46);
            this.DGVListaClientes.Name = "DGVListaClientes";
            this.DGVListaClientes.ReadOnly = true;
            this.DGVListaClientes.Size = new System.Drawing.Size(557, 128);
            this.DGVListaClientes.TabIndex = 0;
            this.DGVListaClientes.SelectionChanged += new System.EventHandler(this.DGVListaClientes_SelectionChanged);
            // 
            // groupBoxDadosCliente
            // 
            this.groupBoxDadosCliente.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxDadosCliente.Controls.Add(this.txtBoxIdadeCliente);
            this.groupBoxDadosCliente.Controls.Add(this.txtBoxStatusCliente);
            this.groupBoxDadosCliente.Controls.Add(this.lblIdadeCliente);
            this.groupBoxDadosCliente.Controls.Add(this.lblStatusCliente);
            this.groupBoxDadosCliente.Controls.Add(this.panelImagemCliente);
            this.groupBoxDadosCliente.Controls.Add(this.lblIdCliente);
            this.groupBoxDadosCliente.Controls.Add(this.txtBoxEmailCliente);
            this.groupBoxDadosCliente.Controls.Add(this.txtBoxCpfCliente);
            this.groupBoxDadosCliente.Controls.Add(this.txtBoxIdCliente);
            this.groupBoxDadosCliente.Controls.Add(this.txtBoxNomeCliente);
            this.groupBoxDadosCliente.Controls.Add(this.lblEmailCliente);
            this.groupBoxDadosCliente.Controls.Add(this.lblNomeCliente);
            this.groupBoxDadosCliente.Controls.Add(this.lblCpfCliente);
            this.groupBoxDadosCliente.Location = new System.Drawing.Point(18, 30);
            this.groupBoxDadosCliente.Name = "groupBoxDadosCliente";
            this.groupBoxDadosCliente.Size = new System.Drawing.Size(600, 125);
            this.groupBoxDadosCliente.TabIndex = 0;
            this.groupBoxDadosCliente.TabStop = false;
            this.groupBoxDadosCliente.Text = "Cliente";
            // 
            // txtBoxIdadeCliente
            // 
            this.txtBoxIdadeCliente.BackColor = System.Drawing.Color.White;
            this.txtBoxIdadeCliente.Enabled = false;
            this.txtBoxIdadeCliente.Location = new System.Drawing.Point(437, 62);
            this.txtBoxIdadeCliente.Name = "txtBoxIdadeCliente";
            this.txtBoxIdadeCliente.Size = new System.Drawing.Size(128, 20);
            this.txtBoxIdadeCliente.TabIndex = 55;
            // 
            // txtBoxStatusCliente
            // 
            this.txtBoxStatusCliente.BackColor = System.Drawing.Color.White;
            this.txtBoxStatusCliente.Enabled = false;
            this.txtBoxStatusCliente.Location = new System.Drawing.Point(439, 13);
            this.txtBoxStatusCliente.Name = "txtBoxStatusCliente";
            this.txtBoxStatusCliente.ReadOnly = true;
            this.txtBoxStatusCliente.Size = new System.Drawing.Size(126, 20);
            this.txtBoxStatusCliente.TabIndex = 54;
            // 
            // lblIdadeCliente
            // 
            this.lblIdadeCliente.AutoSize = true;
            this.lblIdadeCliente.Location = new System.Drawing.Point(386, 65);
            this.lblIdadeCliente.Name = "lblIdadeCliente";
            this.lblIdadeCliente.Size = new System.Drawing.Size(43, 13);
            this.lblIdadeCliente.TabIndex = 53;
            this.lblIdadeCliente.Text = "Idade : ";
            // 
            // lblStatusCliente
            // 
            this.lblStatusCliente.AutoSize = true;
            this.lblStatusCliente.Location = new System.Drawing.Point(387, 16);
            this.lblStatusCliente.Name = "lblStatusCliente";
            this.lblStatusCliente.Size = new System.Drawing.Size(46, 13);
            this.lblStatusCliente.TabIndex = 52;
            this.lblStatusCliente.Text = "Status : ";
            // 
            // panelImagemCliente
            // 
            this.panelImagemCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.panelImagemCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImagemCliente.Location = new System.Drawing.Point(20, 25);
            this.panelImagemCliente.Name = "panelImagemCliente";
            this.panelImagemCliente.Size = new System.Drawing.Size(70, 70);
            this.panelImagemCliente.TabIndex = 41;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(116, 16);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(73, 13);
            this.lblIdCliente.TabIndex = 34;
            this.lblIdCliente.Text = "Cadastro Nº : ";
            // 
            // txtBoxEmailCliente
            // 
            this.txtBoxEmailCliente.BackColor = System.Drawing.Color.White;
            this.txtBoxEmailCliente.Enabled = false;
            this.txtBoxEmailCliente.Location = new System.Drawing.Point(195, 88);
            this.txtBoxEmailCliente.Name = "txtBoxEmailCliente";
            this.txtBoxEmailCliente.ReadOnly = true;
            this.txtBoxEmailCliente.Size = new System.Drawing.Size(370, 20);
            this.txtBoxEmailCliente.TabIndex = 48;
            // 
            // txtBoxCpfCliente
            // 
            this.txtBoxCpfCliente.BackColor = System.Drawing.Color.White;
            this.txtBoxCpfCliente.Enabled = false;
            this.txtBoxCpfCliente.Location = new System.Drawing.Point(195, 63);
            this.txtBoxCpfCliente.Name = "txtBoxCpfCliente";
            this.txtBoxCpfCliente.ReadOnly = true;
            this.txtBoxCpfCliente.Size = new System.Drawing.Size(170, 20);
            this.txtBoxCpfCliente.TabIndex = 51;
            // 
            // txtBoxIdCliente
            // 
            this.txtBoxIdCliente.BackColor = System.Drawing.Color.White;
            this.txtBoxIdCliente.Enabled = false;
            this.txtBoxIdCliente.Location = new System.Drawing.Point(195, 13);
            this.txtBoxIdCliente.Name = "txtBoxIdCliente";
            this.txtBoxIdCliente.ReadOnly = true;
            this.txtBoxIdCliente.Size = new System.Drawing.Size(70, 20);
            this.txtBoxIdCliente.TabIndex = 45;
            // 
            // txtBoxNomeCliente
            // 
            this.txtBoxNomeCliente.BackColor = System.Drawing.Color.White;
            this.txtBoxNomeCliente.Enabled = false;
            this.txtBoxNomeCliente.Location = new System.Drawing.Point(195, 38);
            this.txtBoxNomeCliente.Name = "txtBoxNomeCliente";
            this.txtBoxNomeCliente.ReadOnly = true;
            this.txtBoxNomeCliente.Size = new System.Drawing.Size(370, 20);
            this.txtBoxNomeCliente.TabIndex = 50;
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Location = new System.Drawing.Point(114, 91);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(44, 13);
            this.lblEmailCliente.TabIndex = 44;
            this.lblEmailCliente.Text = "E-mail : ";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(116, 41);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNomeCliente.TabIndex = 36;
            this.lblNomeCliente.Text = "Nome : ";
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(116, 66);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(36, 13);
            this.lblCpfCliente.TabIndex = 35;
            this.lblCpfCliente.Text = "CPF : ";
            // 
            // menuStripConsultaClientes
            // 
            this.menuStripConsultaClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAcessoConsulta});
            this.menuStripConsultaClientes.Location = new System.Drawing.Point(0, 0);
            this.menuStripConsultaClientes.Name = "menuStripConsultaClientes";
            this.menuStripConsultaClientes.Size = new System.Drawing.Size(667, 24);
            this.menuStripConsultaClientes.TabIndex = 1;
            this.menuStripConsultaClientes.Text = "menuStrip1";
            // 
            // toolStripMenuItemAcessoConsulta
            // 
            this.toolStripMenuItemAcessoConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFechar});
            this.toolStripMenuItemAcessoConsulta.Name = "toolStripMenuItemAcessoConsulta";
            this.toolStripMenuItemAcessoConsulta.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItemAcessoConsulta.Text = "Acesso";
            // 
            // toolStripMenuItemFechar
            // 
            this.toolStripMenuItemFechar.Name = "toolStripMenuItemFechar";
            this.toolStripMenuItemFechar.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItemFechar.Text = "Fechar";
            this.toolStripMenuItemFechar.Click += new System.EventHandler(this.toolStripMenuItemFechar_Click);
            // 
            // TelaConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(667, 460);
            this.Controls.Add(this.groupBoxConsultaClientes);
            this.Controls.Add(this.menuStripConsultaClientes);
            this.MainMenuStrip = this.menuStripConsultaClientes;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaConsultaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTA DE CLIENTES";
            this.groupBoxConsultaClientes.ResumeLayout(false);
            this.groupBoxListaClientes.ResumeLayout(false);
            this.groupBoxListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVListaClientes)).EndInit();
            this.groupBoxDadosCliente.ResumeLayout(false);
            this.groupBoxDadosCliente.PerformLayout();
            this.menuStripConsultaClientes.ResumeLayout(false);
            this.menuStripConsultaClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConsultaClientes;
        private System.Windows.Forms.GroupBox groupBoxListaClientes;
        private System.Windows.Forms.GroupBox groupBoxDadosCliente;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.TextBox txtBoxBuscaCliente;
        private System.Windows.Forms.Label lblBuscaCliente;
        private System.Windows.Forms.DataGridView DGVListaClientes;
        private System.Windows.Forms.TextBox txtBoxIdadeCliente;
        private System.Windows.Forms.TextBox txtBoxStatusCliente;
        private System.Windows.Forms.Label lblIdadeCliente;
        private System.Windows.Forms.Label lblStatusCliente;
        private System.Windows.Forms.Panel panelImagemCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TextBox txtBoxEmailCliente;
        private System.Windows.Forms.TextBox txtBoxCpfCliente;
        private System.Windows.Forms.TextBox txtBoxIdCliente;
        private System.Windows.Forms.TextBox txtBoxNomeCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.Button btnAtivarInativarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.MenuStrip menuStripConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAcessoConsulta;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFechar;
        private System.Windows.Forms.ComboBox cbBoxFiltroConsulta;
        private System.Windows.Forms.Label lblFiltroConsultaCliente;
        private System.Windows.Forms.Button btnAtualizarLista;
    }
}