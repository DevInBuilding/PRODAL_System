namespace PRODALsystem
{
    partial class TelaAlocacaoProduto
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
            this.groupBoxDadosAlocacaoCliente = new System.Windows.Forms.GroupBox();
            this.groupBoxDadosProdutoAlocacao = new System.Windows.Forms.GroupBox();
            this.cbBoxFiltraBuscaProduto = new System.Windows.Forms.ComboBox();
            this.lblFiltraBuscaProduto = new System.Windows.Forms.Label();
            this.numericUpDownDadosQuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.btnReservarProduto = new System.Windows.Forms.Button();
            this.lblDadosQuantidadeProduto = new System.Windows.Forms.Label();
            this.txtBoxDadosStatusProduto = new System.Windows.Forms.TextBox();
            this.lblDadosStatusProduto = new System.Windows.Forms.Label();
            this.lbDadosTituloProduto = new System.Windows.Forms.Label();
            this.txtBoxDadosTituloProduto = new System.Windows.Forms.TextBox();
            this.txtBoxDadosIdProduto = new System.Windows.Forms.TextBox();
            this.lblDadosIdProduto = new System.Windows.Forms.Label();
            this.btnBuscaProduto = new System.Windows.Forms.Button();
            this.txtBoxBuscaProduto = new System.Windows.Forms.TextBox();
            this.lblBuscaProduto = new System.Windows.Forms.Label();
            this.groupBoxDadosAlocacao = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDataAlocacao = new System.Windows.Forms.DateTimePicker();
            this.lblDataReserva = new System.Windows.Forms.Label();
            this.txtBoxIdAlocacao = new System.Windows.Forms.TextBox();
            this.lblAlocacaoIdAlocacao = new System.Windows.Forms.Label();
            this.menuStripAcessoAlocacao = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAcessoAlocacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDadosAlocacaoCliente.SuspendLayout();
            this.groupBoxDadosProdutoAlocacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDadosQuantidadeProduto)).BeginInit();
            this.groupBoxDadosAlocacao.SuspendLayout();
            this.menuStripAcessoAlocacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadosAlocacaoCliente
            // 
            this.groupBoxDadosAlocacaoCliente.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxDadosAlocacaoCliente.Controls.Add(this.groupBoxDadosProdutoAlocacao);
            this.groupBoxDadosAlocacaoCliente.Controls.Add(this.groupBoxDadosAlocacao);
            this.groupBoxDadosAlocacaoCliente.Location = new System.Drawing.Point(12, 30);
            this.groupBoxDadosAlocacaoCliente.Name = "groupBoxDadosAlocacaoCliente";
            this.groupBoxDadosAlocacaoCliente.Size = new System.Drawing.Size(310, 420);
            this.groupBoxDadosAlocacaoCliente.TabIndex = 0;
            this.groupBoxDadosAlocacaoCliente.TabStop = false;
            this.groupBoxDadosAlocacaoCliente.Text = "Dados da Nova Alocação";
            // 
            // groupBoxDadosProdutoAlocacao
            // 
            this.groupBoxDadosProdutoAlocacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.cbBoxFiltraBuscaProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.lblFiltraBuscaProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.numericUpDownDadosQuantidadeProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.btnReservarProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.lblDadosQuantidadeProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.txtBoxDadosStatusProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.lblDadosStatusProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.lbDadosTituloProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.txtBoxDadosTituloProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.txtBoxDadosIdProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.lblDadosIdProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.btnBuscaProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.txtBoxBuscaProduto);
            this.groupBoxDadosProdutoAlocacao.Controls.Add(this.lblBuscaProduto);
            this.groupBoxDadosProdutoAlocacao.Location = new System.Drawing.Point(17, 150);
            this.groupBoxDadosProdutoAlocacao.Name = "groupBoxDadosProdutoAlocacao";
            this.groupBoxDadosProdutoAlocacao.Size = new System.Drawing.Size(275, 245);
            this.groupBoxDadosProdutoAlocacao.TabIndex = 1;
            this.groupBoxDadosProdutoAlocacao.TabStop = false;
            this.groupBoxDadosProdutoAlocacao.Text = "Dados do Produto";
            // 
            // cbBoxFiltraBuscaProduto
            // 
            this.cbBoxFiltraBuscaProduto.FormattingEnabled = true;
            this.cbBoxFiltraBuscaProduto.Items.AddRange(new object[] {
            "Código do Produto",
            "Nome do Produto"});
            this.cbBoxFiltraBuscaProduto.Location = new System.Drawing.Point(91, 24);
            this.cbBoxFiltraBuscaProduto.Name = "cbBoxFiltraBuscaProduto";
            this.cbBoxFiltraBuscaProduto.Size = new System.Drawing.Size(149, 21);
            this.cbBoxFiltraBuscaProduto.TabIndex = 17;
            this.cbBoxFiltraBuscaProduto.SelectedIndexChanged += new System.EventHandler(this.cbBoxFiltraBuscaProduto_SelectedIndexChanged);
            // 
            // lblFiltraBuscaProduto
            // 
            this.lblFiltraBuscaProduto.AutoSize = true;
            this.lblFiltraBuscaProduto.Location = new System.Drawing.Point(26, 27);
            this.lblFiltraBuscaProduto.Name = "lblFiltraBuscaProduto";
            this.lblFiltraBuscaProduto.Size = new System.Drawing.Size(59, 13);
            this.lblFiltraBuscaProduto.TabIndex = 16;
            this.lblFiltraBuscaProduto.Text = "Filtrar por : ";
            // 
            // numericUpDownDadosQuantidadeProduto
            // 
            this.numericUpDownDadosQuantidadeProduto.Location = new System.Drawing.Point(126, 175);
            this.numericUpDownDadosQuantidadeProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDadosQuantidadeProduto.Name = "numericUpDownDadosQuantidadeProduto";
            this.numericUpDownDadosQuantidadeProduto.Size = new System.Drawing.Size(114, 20);
            this.numericUpDownDadosQuantidadeProduto.TabIndex = 2;
            this.numericUpDownDadosQuantidadeProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnReservarProduto
            // 
            this.btnReservarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReservarProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReservarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReservarProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReservarProduto.Location = new System.Drawing.Point(100, 210);
            this.btnReservarProduto.Name = "btnReservarProduto";
            this.btnReservarProduto.Size = new System.Drawing.Size(75, 23);
            this.btnReservarProduto.TabIndex = 14;
            this.btnReservarProduto.Text = "Reservar 📦";
            this.btnReservarProduto.UseVisualStyleBackColor = false;
            // 
            // lblDadosQuantidadeProduto
            // 
            this.lblDadosQuantidadeProduto.AutoSize = true;
            this.lblDadosQuantidadeProduto.Location = new System.Drawing.Point(25, 178);
            this.lblDadosQuantidadeProduto.Name = "lblDadosQuantidadeProduto";
            this.lblDadosQuantidadeProduto.Size = new System.Drawing.Size(71, 13);
            this.lblDadosQuantidadeProduto.TabIndex = 13;
            this.lblDadosQuantidadeProduto.Text = "Quantidade : ";
            // 
            // txtBoxDadosStatusProduto
            // 
            this.txtBoxDadosStatusProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDadosStatusProduto.Enabled = false;
            this.txtBoxDadosStatusProduto.Location = new System.Drawing.Point(126, 150);
            this.txtBoxDadosStatusProduto.Name = "txtBoxDadosStatusProduto";
            this.txtBoxDadosStatusProduto.ReadOnly = true;
            this.txtBoxDadosStatusProduto.Size = new System.Drawing.Size(114, 20);
            this.txtBoxDadosStatusProduto.TabIndex = 11;
            // 
            // lblDadosStatusProduto
            // 
            this.lblDadosStatusProduto.AutoSize = true;
            this.lblDadosStatusProduto.Location = new System.Drawing.Point(25, 153);
            this.lblDadosStatusProduto.Name = "lblDadosStatusProduto";
            this.lblDadosStatusProduto.Size = new System.Drawing.Size(46, 13);
            this.lblDadosStatusProduto.TabIndex = 10;
            this.lblDadosStatusProduto.Text = "Status : ";
            // 
            // lbDadosTituloProduto
            // 
            this.lbDadosTituloProduto.AutoSize = true;
            this.lbDadosTituloProduto.Location = new System.Drawing.Point(25, 128);
            this.lbDadosTituloProduto.Name = "lbDadosTituloProduto";
            this.lbDadosTituloProduto.Size = new System.Drawing.Size(44, 13);
            this.lbDadosTituloProduto.TabIndex = 9;
            this.lbDadosTituloProduto.Text = "Título : ";
            // 
            // txtBoxDadosTituloProduto
            // 
            this.txtBoxDadosTituloProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDadosTituloProduto.Enabled = false;
            this.txtBoxDadosTituloProduto.Location = new System.Drawing.Point(126, 125);
            this.txtBoxDadosTituloProduto.Name = "txtBoxDadosTituloProduto";
            this.txtBoxDadosTituloProduto.ReadOnly = true;
            this.txtBoxDadosTituloProduto.Size = new System.Drawing.Size(114, 20);
            this.txtBoxDadosTituloProduto.TabIndex = 8;
            // 
            // txtBoxDadosIdProduto
            // 
            this.txtBoxDadosIdProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxDadosIdProduto.Enabled = false;
            this.txtBoxDadosIdProduto.Location = new System.Drawing.Point(126, 100);
            this.txtBoxDadosIdProduto.Name = "txtBoxDadosIdProduto";
            this.txtBoxDadosIdProduto.ReadOnly = true;
            this.txtBoxDadosIdProduto.Size = new System.Drawing.Size(114, 20);
            this.txtBoxDadosIdProduto.TabIndex = 7;
            // 
            // lblDadosIdProduto
            // 
            this.lblDadosIdProduto.AutoSize = true;
            this.lblDadosIdProduto.Location = new System.Drawing.Point(25, 103);
            this.lblDadosIdProduto.Name = "lblDadosIdProduto";
            this.lblDadosIdProduto.Size = new System.Drawing.Size(74, 13);
            this.lblDadosIdProduto.TabIndex = 6;
            this.lblDadosIdProduto.Text = "Identificador : ";
            // 
            // btnBuscaProduto
            // 
            this.btnBuscaProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.btnBuscaProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscaProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscaProduto.Location = new System.Drawing.Point(221, 49);
            this.btnBuscaProduto.Name = "btnBuscaProduto";
            this.btnBuscaProduto.Size = new System.Drawing.Size(20, 23);
            this.btnBuscaProduto.TabIndex = 5;
            this.btnBuscaProduto.Text = "🔎";
            this.btnBuscaProduto.UseVisualStyleBackColor = false;
            // 
            // txtBoxBuscaProduto
            // 
            this.txtBoxBuscaProduto.Location = new System.Drawing.Point(91, 51);
            this.txtBoxBuscaProduto.Name = "txtBoxBuscaProduto";
            this.txtBoxBuscaProduto.Size = new System.Drawing.Size(125, 20);
            this.txtBoxBuscaProduto.TabIndex = 4;
            this.txtBoxBuscaProduto.Text = "Digite o código ou o nome do produto";
            // 
            // lblBuscaProduto
            // 
            this.lblBuscaProduto.AutoSize = true;
            this.lblBuscaProduto.Location = new System.Drawing.Point(26, 54);
            this.lblBuscaProduto.Name = "lblBuscaProduto";
            this.lblBuscaProduto.Size = new System.Drawing.Size(49, 13);
            this.lblBuscaProduto.TabIndex = 4;
            this.lblBuscaProduto.Text = "Buscar : ";
            // 
            // groupBoxDadosAlocacao
            // 
            this.groupBoxDadosAlocacao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBoxDadosAlocacao.Controls.Add(this.dateTimePickerDataAlocacao);
            this.groupBoxDadosAlocacao.Controls.Add(this.lblDataReserva);
            this.groupBoxDadosAlocacao.Controls.Add(this.txtBoxIdAlocacao);
            this.groupBoxDadosAlocacao.Controls.Add(this.lblAlocacaoIdAlocacao);
            this.groupBoxDadosAlocacao.Location = new System.Drawing.Point(17, 30);
            this.groupBoxDadosAlocacao.Name = "groupBoxDadosAlocacao";
            this.groupBoxDadosAlocacao.Size = new System.Drawing.Size(275, 100);
            this.groupBoxDadosAlocacao.TabIndex = 0;
            this.groupBoxDadosAlocacao.TabStop = false;
            this.groupBoxDadosAlocacao.Text = "Dados da Alocação : ";
            // 
            // dateTimePickerDataAlocacao
            // 
            this.dateTimePickerDataAlocacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDataAlocacao.Location = new System.Drawing.Point(140, 57);
            this.dateTimePickerDataAlocacao.Name = "dateTimePickerDataAlocacao";
            this.dateTimePickerDataAlocacao.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDataAlocacao.TabIndex = 3;
            // 
            // lblDataReserva
            // 
            this.lblDataReserva.AutoSize = true;
            this.lblDataReserva.Location = new System.Drawing.Point(25, 60);
            this.lblDataReserva.Name = "lblDataReserva";
            this.lblDataReserva.Size = new System.Drawing.Size(110, 13);
            this.lblDataReserva.TabIndex = 2;
            this.lblDataReserva.Text = "Data de Requisição : ";
            // 
            // txtBoxIdAlocacao
            // 
            this.txtBoxIdAlocacao.BackColor = System.Drawing.Color.White;
            this.txtBoxIdAlocacao.Enabled = false;
            this.txtBoxIdAlocacao.Location = new System.Drawing.Point(140, 27);
            this.txtBoxIdAlocacao.Name = "txtBoxIdAlocacao";
            this.txtBoxIdAlocacao.ReadOnly = true;
            this.txtBoxIdAlocacao.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIdAlocacao.TabIndex = 1;
            // 
            // lblAlocacaoIdAlocacao
            // 
            this.lblAlocacaoIdAlocacao.AutoSize = true;
            this.lblAlocacaoIdAlocacao.Location = new System.Drawing.Point(25, 30);
            this.lblAlocacaoIdAlocacao.Name = "lblAlocacaoIdAlocacao";
            this.lblAlocacaoIdAlocacao.Size = new System.Drawing.Size(112, 13);
            this.lblAlocacaoIdAlocacao.TabIndex = 0;
            this.lblAlocacaoIdAlocacao.Text = "Código da Alocação : ";
            // 
            // menuStripAcessoAlocacao
            // 
            this.menuStripAcessoAlocacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAcessoAlocacao});
            this.menuStripAcessoAlocacao.Location = new System.Drawing.Point(0, 0);
            this.menuStripAcessoAlocacao.Name = "menuStripAcessoAlocacao";
            this.menuStripAcessoAlocacao.Size = new System.Drawing.Size(334, 24);
            this.menuStripAcessoAlocacao.TabIndex = 1;
            this.menuStripAcessoAlocacao.Text = "menuStrip1";
            // 
            // toolStripMenuItemAcessoAlocacao
            // 
            this.toolStripMenuItemAcessoAlocacao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFechar});
            this.toolStripMenuItemAcessoAlocacao.Name = "toolStripMenuItemAcessoAlocacao";
            this.toolStripMenuItemAcessoAlocacao.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItemAcessoAlocacao.Text = "Acesso";
            // 
            // toolStripMenuItemFechar
            // 
            this.toolStripMenuItemFechar.Name = "toolStripMenuItemFechar";
            this.toolStripMenuItemFechar.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItemFechar.Text = "Fechar";
            this.toolStripMenuItemFechar.Click += new System.EventHandler(this.toolStripMenuItemFechar_Click);
            // 
            // TelaAlocacaoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(334, 462);
            this.Controls.Add(this.groupBoxDadosAlocacaoCliente);
            this.Controls.Add(this.menuStripAcessoAlocacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripAcessoAlocacao;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAlocacaoProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALOCAR NOVO PRODUTO";
            this.groupBoxDadosAlocacaoCliente.ResumeLayout(false);
            this.groupBoxDadosProdutoAlocacao.ResumeLayout(false);
            this.groupBoxDadosProdutoAlocacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDadosQuantidadeProduto)).EndInit();
            this.groupBoxDadosAlocacao.ResumeLayout(false);
            this.groupBoxDadosAlocacao.PerformLayout();
            this.menuStripAcessoAlocacao.ResumeLayout(false);
            this.menuStripAcessoAlocacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadosAlocacaoCliente;
        private System.Windows.Forms.GroupBox groupBoxDadosProdutoAlocacao;
        private System.Windows.Forms.GroupBox groupBoxDadosAlocacao;
        private System.Windows.Forms.Label lblDataReserva;
        private System.Windows.Forms.TextBox txtBoxIdAlocacao;
        private System.Windows.Forms.Label lblAlocacaoIdAlocacao;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataAlocacao;
        private System.Windows.Forms.TextBox txtBoxBuscaProduto;
        private System.Windows.Forms.Label lblBuscaProduto;
        private System.Windows.Forms.Button btnBuscaProduto;
        private System.Windows.Forms.Label lbDadosTituloProduto;
        private System.Windows.Forms.TextBox txtBoxDadosTituloProduto;
        private System.Windows.Forms.TextBox txtBoxDadosIdProduto;
        private System.Windows.Forms.Label lblDadosIdProduto;
        private System.Windows.Forms.NumericUpDown numericUpDownDadosQuantidadeProduto;
        private System.Windows.Forms.Button btnReservarProduto;
        private System.Windows.Forms.Label lblDadosQuantidadeProduto;
        private System.Windows.Forms.TextBox txtBoxDadosStatusProduto;
        private System.Windows.Forms.Label lblDadosStatusProduto;
        private System.Windows.Forms.MenuStrip menuStripAcessoAlocacao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAcessoAlocacao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFechar;
        private System.Windows.Forms.ComboBox cbBoxFiltraBuscaProduto;
        private System.Windows.Forms.Label lblFiltraBuscaProduto;
    }
}