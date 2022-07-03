namespace PRODALsystem
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.cbBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.lblLoginTipoUsuario = new System.Windows.Forms.Label();
            this.btnLoginAcesso = new System.Windows.Forms.Button();
            this.txtBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.txtBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.lblLoginSenha = new System.Windows.Forms.Label();
            this.lblLoginUsuario = new System.Windows.Forms.Label();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxLogin.Controls.Add(this.cbBoxTipoUsuario);
            this.groupBoxLogin.Controls.Add(this.lblLoginTipoUsuario);
            this.groupBoxLogin.Controls.Add(this.btnLoginAcesso);
            this.groupBoxLogin.Controls.Add(this.txtBoxLoginSenha);
            this.groupBoxLogin.Controls.Add(this.txtBoxLoginUsuario);
            this.groupBoxLogin.Controls.Add(this.lblLoginSenha);
            this.groupBoxLogin.Controls.Add(this.lblLoginUsuario);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(28, 23);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(270, 250);
            this.groupBoxLogin.TabIndex = 8;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Login";
            // 
            // cbBoxTipoUsuario
            // 
            this.cbBoxTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxTipoUsuario.FormattingEnabled = true;
            this.cbBoxTipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Cliente"});
            this.cbBoxTipoUsuario.Location = new System.Drawing.Point(65, 153);
            this.cbBoxTipoUsuario.Name = "cbBoxTipoUsuario";
            this.cbBoxTipoUsuario.Size = new System.Drawing.Size(150, 23);
            this.cbBoxTipoUsuario.TabIndex = 13;
            // 
            // lblLoginTipoUsuario
            // 
            this.lblLoginTipoUsuario.AutoSize = true;
            this.lblLoginTipoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginTipoUsuario.Location = new System.Drawing.Point(35, 133);
            this.lblLoginTipoUsuario.Name = "lblLoginTipoUsuario";
            this.lblLoginTipoUsuario.Size = new System.Drawing.Size(94, 15);
            this.lblLoginTipoUsuario.TabIndex = 12;
            this.lblLoginTipoUsuario.Text = "Tipo de Usuário";
            // 
            // btnLoginAcesso
            // 
            this.btnLoginAcesso.BackColor = System.Drawing.Color.Green;
            this.btnLoginAcesso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginAcesso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginAcesso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoginAcesso.Location = new System.Drawing.Point(95, 199);
            this.btnLoginAcesso.Name = "btnLoginAcesso";
            this.btnLoginAcesso.Padding = new System.Windows.Forms.Padding(2);
            this.btnLoginAcesso.Size = new System.Drawing.Size(90, 30);
            this.btnLoginAcesso.TabIndex = 11;
            this.btnLoginAcesso.Text = "Acessar";
            this.btnLoginAcesso.UseVisualStyleBackColor = false;
            this.btnLoginAcesso.Click += new System.EventHandler(this.btnLoginAcesso_Click);
            // 
            // txtBoxLoginSenha
            // 
            this.txtBoxLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginSenha.Location = new System.Drawing.Point(65, 103);
            this.txtBoxLoginSenha.Name = "txtBoxLoginSenha";
            this.txtBoxLoginSenha.PasswordChar = '*';
            this.txtBoxLoginSenha.Size = new System.Drawing.Size(150, 21);
            this.txtBoxLoginSenha.TabIndex = 10;
            // 
            // txtBoxLoginUsuario
            // 
            this.txtBoxLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLoginUsuario.Location = new System.Drawing.Point(65, 53);
            this.txtBoxLoginUsuario.Name = "txtBoxLoginUsuario";
            this.txtBoxLoginUsuario.Size = new System.Drawing.Size(150, 21);
            this.txtBoxLoginUsuario.TabIndex = 9;
            // 
            // lblLoginSenha
            // 
            this.lblLoginSenha.AutoSize = true;
            this.lblLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginSenha.Location = new System.Drawing.Point(35, 83);
            this.lblLoginSenha.Name = "lblLoginSenha";
            this.lblLoginSenha.Size = new System.Drawing.Size(43, 15);
            this.lblLoginSenha.TabIndex = 8;
            this.lblLoginSenha.Text = "Senha";
            // 
            // lblLoginUsuario
            // 
            this.lblLoginUsuario.AutoSize = true;
            this.lblLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginUsuario.Location = new System.Drawing.Point(35, 33);
            this.lblLoginUsuario.Name = "lblLoginUsuario";
            this.lblLoginUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblLoginUsuario.TabIndex = 7;
            this.lblLoginUsuario.Text = "Usuário";
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(331, 307);
            this.Controls.Add(this.groupBoxLogin);
            this.Location = new System.Drawing.Point(600, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACESSO AO SISTEMA";
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.ComboBox cbBoxTipoUsuario;
        private System.Windows.Forms.Label lblLoginTipoUsuario;
        private System.Windows.Forms.Button btnLoginAcesso;
        private System.Windows.Forms.TextBox txtBoxLoginSenha;
        private System.Windows.Forms.TextBox txtBoxLoginUsuario;
        private System.Windows.Forms.Label lblLoginSenha;
        private System.Windows.Forms.Label lblLoginUsuario;
    }
}