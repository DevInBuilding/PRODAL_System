using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODALsystem
{
    public partial class TelaEdicaoDadosLogin : Form
    {
        public static int IdUsuario = 0;

        private Login objLogin = new Login();

        public TelaEdicaoDadosLogin()
        {
            InitializeComponent();

            this.LoadDataPasswordDescription();
        }

        //MENU DE ACESSO
        private void toolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair sem alterar a senha?", "CANCELAMENTO DE EDIÇÃO DE LOGIN", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        //CARREGAR ID
        public void LoadDataPasswordDescription()
        {
            foreach (Login objEditLogin in Listas.ListaLogins)
            {
                if (IdUsuario == objEditLogin.Id)
                {
                    objLogin = objEditLogin;

                    txtBoxEdicaoLoginIdCliente.Text = objLogin.Id.ToString();
                }
            }
        }


        //BOTAO SALVAR
        private void btnSalvarNovaSenha_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEdicaoLoginSenhaAntigaCliente.Text) || string.IsNullOrWhiteSpace(txtBoxEdicaoLoginNovaSenhaCliente.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEdicaoLoginConfirmacaoSenhaCliente.Text) || !(txtBoxEdicaoLoginSenhaAntigaCliente.Text).Equals(objLogin.SenhaAcesso) ||
                        !(txtBoxEdicaoLoginNovaSenhaCliente.Text).Equals(txtBoxEdicaoLoginConfirmacaoSenhaCliente.Text))
            {
                MessageBox.Show(this, "ERRO: Preencha os campos corretamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxEdicaoLoginSenhaAntigaCliente.Focus();

            }
            else
            {
                var objEditLogin = new Login
                {
                    Id = objLogin.Id,
                    SenhaAcesso = txtBoxEdicaoLoginNovaSenhaCliente.Text
                };

                if (MessageBox.Show(this, "Confirma a alteração dos dados do login?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    objLogin.EditarLogin(objEditLogin);
                    MessageBox.Show("Senha alterada com sucesso");
                    this.Close();
                }
            }
        }
    }
}