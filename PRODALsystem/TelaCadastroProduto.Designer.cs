namespace PRODALsystem
{
    partial class TelaCadastroProduto
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
            this.groupBoxDadosProduto = new System.Windows.Forms.GroupBox();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.txtBoxCadastroStatusProduto = new System.Windows.Forms.TextBox();
            this.numericUpDownCadastroQuantidadeProduto = new System.Windows.Forms.NumericUpDown();
            this.txtBoxCadastroTituloProduto = new System.Windows.Forms.TextBox();
            this.lblDataCadastroProduto = new System.Windows.Forms.Label();
            this.lblCadastroQuantidadeProduto = new System.Windows.Forms.Label();
            this.lblCadastroStatusProduto = new System.Windows.Forms.Label();
            this.lblCadastroTituloProduto = new System.Windows.Forms.Label();
            this.txtBoxCadastroIdProduto = new System.Windows.Forms.TextBox();
            this.btnAnexarImagemCadastroProduto = new System.Windows.Forms.Button();
            this.panelCadastroImagemProduto = new System.Windows.Forms.Panel();
            this.lblCadastroIdProduto = new System.Windows.Forms.Label();
            this.menuStripAcessoCadastroProduto = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemAcessoProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxDadosProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCadastroQuantidadeProduto)).BeginInit();
            this.menuStripAcessoCadastroProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDadosProduto
            // 
            this.groupBoxDadosProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxDadosProduto.Controls.Add(this.btnCadastroProduto);
            this.groupBoxDadosProduto.Controls.Add(this.txtBoxCadastroStatusProduto);
            this.groupBoxDadosProduto.Controls.Add(this.numericUpDownCadastroQuantidadeProduto);
            this.groupBoxDadosProduto.Controls.Add(this.txtBoxCadastroTituloProduto);
            this.groupBoxDadosProduto.Controls.Add(this.lblDataCadastroProduto);
            this.groupBoxDadosProduto.Controls.Add(this.lblCadastroQuantidadeProduto);
            this.groupBoxDadosProduto.Controls.Add(this.lblCadastroStatusProduto);
            this.groupBoxDadosProduto.Controls.Add(this.lblCadastroTituloProduto);
            this.groupBoxDadosProduto.Controls.Add(this.txtBoxCadastroIdProduto);
            this.groupBoxDadosProduto.Controls.Add(this.btnAnexarImagemCadastroProduto);
            this.groupBoxDadosProduto.Controls.Add(this.panelCadastroImagemProduto);
            this.groupBoxDadosProduto.Controls.Add(this.lblCadastroIdProduto);
            this.groupBoxDadosProduto.Location = new System.Drawing.Point(13, 40);
            this.groupBoxDadosProduto.Name = "groupBoxDadosProduto";
            this.groupBoxDadosProduto.Size = new System.Drawing.Size(280, 250);
            this.groupBoxDadosProduto.TabIndex = 0;
            this.groupBoxDadosProduto.TabStop = false;
            this.groupBoxDadosProduto.Text = "Dados do Novo Produto";
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCadastroProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastroProduto.Location = new System.Drawing.Point(130, 210);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(120, 25);
            this.btnCadastroProduto.TabIndex = 11;
            this.btnCadastroProduto.Text = "Salvar Produto 💾";
            this.btnCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // txtBoxCadastroStatusProduto
            // 
            this.txtBoxCadastroStatusProduto.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtBoxCadastroStatusProduto.Enabled = false;
            this.txtBoxCadastroStatusProduto.Location = new System.Drawing.Point(110, 142);
            this.txtBoxCadastroStatusProduto.Name = "txtBoxCadastroStatusProduto";
            this.txtBoxCadastroStatusProduto.ReadOnly = true;
            this.txtBoxCadastroStatusProduto.Size = new System.Drawing.Size(150, 20);
            this.txtBoxCadastroStatusProduto.TabIndex = 10;
            this.txtBoxCadastroStatusProduto.Text = "Disponível";
            // 
            // numericUpDownCadastroQuantidadeProduto
            // 
            this.numericUpDownCadastroQuantidadeProduto.Location = new System.Drawing.Point(110, 168);
            this.numericUpDownCadastroQuantidadeProduto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCadastroQuantidadeProduto.Name = "numericUpDownCadastroQuantidadeProduto";
            this.numericUpDownCadastroQuantidadeProduto.Size = new System.Drawing.Size(150, 20);
            this.numericUpDownCadastroQuantidadeProduto.TabIndex = 9;
            this.numericUpDownCadastroQuantidadeProduto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtBoxCadastroTituloProduto
            // 
            this.txtBoxCadastroTituloProduto.Location = new System.Drawing.Point(110, 116);
            this.txtBoxCadastroTituloProduto.Name = "txtBoxCadastroTituloProduto";
            this.txtBoxCadastroTituloProduto.Size = new System.Drawing.Size(150, 20);
            this.txtBoxCadastroTituloProduto.TabIndex = 8;
            // 
            // lblDataCadastroProduto
            // 
            this.lblDataCadastroProduto.AutoSize = true;
            this.lblDataCadastroProduto.Location = new System.Drawing.Point(155, 214);
            this.lblDataCadastroProduto.Name = "lblDataCadastroProduto";
            this.lblDataCadastroProduto.Size = new System.Drawing.Size(0, 13);
            this.lblDataCadastroProduto.TabIndex = 7;
            // 
            // lblCadastroQuantidadeProduto
            // 
            this.lblCadastroQuantidadeProduto.AutoSize = true;
            this.lblCadastroQuantidadeProduto.Location = new System.Drawing.Point(25, 170);
            this.lblCadastroQuantidadeProduto.Name = "lblCadastroQuantidadeProduto";
            this.lblCadastroQuantidadeProduto.Size = new System.Drawing.Size(71, 13);
            this.lblCadastroQuantidadeProduto.TabIndex = 6;
            this.lblCadastroQuantidadeProduto.Text = "Quantidade : ";
            // 
            // lblCadastroStatusProduto
            // 
            this.lblCadastroStatusProduto.AutoSize = true;
            this.lblCadastroStatusProduto.Location = new System.Drawing.Point(25, 145);
            this.lblCadastroStatusProduto.Name = "lblCadastroStatusProduto";
            this.lblCadastroStatusProduto.Size = new System.Drawing.Size(46, 13);
            this.lblCadastroStatusProduto.TabIndex = 5;
            this.lblCadastroStatusProduto.Text = "Status : ";
            // 
            // lblCadastroTituloProduto
            // 
            this.lblCadastroTituloProduto.AutoSize = true;
            this.lblCadastroTituloProduto.Location = new System.Drawing.Point(25, 120);
            this.lblCadastroTituloProduto.Name = "lblCadastroTituloProduto";
            this.lblCadastroTituloProduto.Size = new System.Drawing.Size(44, 13);
            this.lblCadastroTituloProduto.TabIndex = 4;
            this.lblCadastroTituloProduto.Text = "Título : ";
            // 
            // txtBoxCadastroIdProduto
            // 
            this.txtBoxCadastroIdProduto.BackColor = System.Drawing.Color.White;
            this.txtBoxCadastroIdProduto.Enabled = false;
            this.txtBoxCadastroIdProduto.Location = new System.Drawing.Point(190, 47);
            this.txtBoxCadastroIdProduto.Name = "txtBoxCadastroIdProduto";
            this.txtBoxCadastroIdProduto.ReadOnly = true;
            this.txtBoxCadastroIdProduto.Size = new System.Drawing.Size(70, 20);
            this.txtBoxCadastroIdProduto.TabIndex = 3;
            // 
            // btnAnexarImagemCadastroProduto
            // 
            this.btnAnexarImagemCadastroProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnexarImagemCadastroProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnexarImagemCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnexarImagemCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexarImagemCadastroProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnexarImagemCadastroProduto.Location = new System.Drawing.Point(50, 210);
            this.btnAnexarImagemCadastroProduto.Name = "btnAnexarImagemCadastroProduto";
            this.btnAnexarImagemCadastroProduto.Size = new System.Drawing.Size(70, 25);
            this.btnAnexarImagemCadastroProduto.TabIndex = 2;
            this.btnAnexarImagemCadastroProduto.Text = "Anexar 📎";
            this.btnAnexarImagemCadastroProduto.UseVisualStyleBackColor = false;
            // 
            // panelCadastroImagemProduto
            // 
            this.panelCadastroImagemProduto.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelCadastroImagemProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCadastroImagemProduto.Location = new System.Drawing.Point(20, 30);
            this.panelCadastroImagemProduto.Name = "panelCadastroImagemProduto";
            this.panelCadastroImagemProduto.Size = new System.Drawing.Size(70, 70);
            this.panelCadastroImagemProduto.TabIndex = 1;
            // 
            // lblCadastroIdProduto
            // 
            this.lblCadastroIdProduto.AutoSize = true;
            this.lblCadastroIdProduto.Location = new System.Drawing.Point(110, 50);
            this.lblCadastroIdProduto.Name = "lblCadastroIdProduto";
            this.lblCadastroIdProduto.Size = new System.Drawing.Size(82, 13);
            this.lblCadastroIdProduto.TabIndex = 0;
            this.lblCadastroIdProduto.Text = "ID do Produto : ";
            // 
            // menuStripAcessoCadastroProduto
            // 
            this.menuStripAcessoCadastroProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAcessoProduto});
            this.menuStripAcessoCadastroProduto.Location = new System.Drawing.Point(0, 0);
            this.menuStripAcessoCadastroProduto.Name = "menuStripAcessoCadastroProduto";
            this.menuStripAcessoCadastroProduto.Size = new System.Drawing.Size(305, 24);
            this.menuStripAcessoCadastroProduto.TabIndex = 1;
            this.menuStripAcessoCadastroProduto.Text = "menuStrip1";
            // 
            // toolStripMenuItemAcessoProduto
            // 
            this.toolStripMenuItemAcessoProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFechar});
            this.toolStripMenuItemAcessoProduto.Name = "toolStripMenuItemAcessoProduto";
            this.toolStripMenuItemAcessoProduto.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItemAcessoProduto.Text = "Acesso";
            // 
            // toolStripMenuItemFechar
            // 
            this.toolStripMenuItemFechar.Name = "toolStripMenuItemFechar";
            this.toolStripMenuItemFechar.Size = new System.Drawing.Size(109, 22);
            this.toolStripMenuItemFechar.Text = "Fechar";
            this.toolStripMenuItemFechar.Click += new System.EventHandler(this.toolStripMenuItemFechar_Click);
            // 
            // TelaCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(305, 307);
            this.Controls.Add(this.groupBoxDadosProduto);
            this.Controls.Add(this.menuStripAcessoCadastroProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStripAcessoCadastroProduto;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DO NOVO PRODUTO";
            this.groupBoxDadosProduto.ResumeLayout(false);
            this.groupBoxDadosProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCadastroQuantidadeProduto)).EndInit();
            this.menuStripAcessoCadastroProduto.ResumeLayout(false);
            this.menuStripAcessoCadastroProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDadosProduto;
        private System.Windows.Forms.Panel panelCadastroImagemProduto;
        private System.Windows.Forms.Label lblCadastroIdProduto;
        private System.Windows.Forms.Button btnAnexarImagemCadastroProduto;
        private System.Windows.Forms.TextBox txtBoxCadastroIdProduto;
        private System.Windows.Forms.Label lblDataCadastroProduto;
        private System.Windows.Forms.Label lblCadastroQuantidadeProduto;
        private System.Windows.Forms.Label lblCadastroStatusProduto;
        private System.Windows.Forms.Label lblCadastroTituloProduto;
        private System.Windows.Forms.TextBox txtBoxCadastroTituloProduto;
        private System.Windows.Forms.TextBox txtBoxCadastroStatusProduto;
        private System.Windows.Forms.NumericUpDown numericUpDownCadastroQuantidadeProduto;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.MenuStrip menuStripAcessoCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAcessoProduto;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFechar;
    }
}