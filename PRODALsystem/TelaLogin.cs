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
    public partial class TelaLogin : Form
    {
        private static Usuario objUsuario = new Usuario();
        private static Login objLogin = new Login();
        private static int tentativas = 3;

        public TelaLogin()
        {
            InitializeComponent();

            //this.LoadLists();
            this.cbBoxTipoUsuario.SelectedIndex = 0;
        }

        private void LoadLists()
        {
            Listas.GerarListaClientes(Listas.ListaUsuarios);
            Listas.GerarListaAdmins(Listas.ListaUsuarios);
        }

        private void TelaLogin_Load(object sender, EventArgs e) { }

        private void PainelLogin_Paint(object sender, PaintEventArgs e) { }

        private void btnLoginAcesso_Click(object sender, EventArgs e)
        {
            Login objAutenticaLogin = new Login
            {
                LoginAcesso = txtBoxLoginUsuario.Text,
                SenhaAcesso = txtBoxLoginSenha.Text,
                Tipo = cbBoxTipoUsuario.Text
            };

            bool verifica = VerificarCampos();

            if (verifica && objLogin.ValidarAcesso(objAutenticaLogin))
            {
                this.Hide();

                if (objUsuario.Logar(objAutenticaLogin).Tipo.Equals("Administrador"))
                {
                    TelaAcessoAdministrador.IdAdmin = objUsuario.Logar(objAutenticaLogin).Id;
                    TelaAcessoAdministrador formAcessoAdm = new TelaAcessoAdministrador();
                    formAcessoAdm.Show();
                }
                else if (objUsuario.Logar(objAutenticaLogin).Tipo.Equals("Cliente"))
                {
                    TelaAcessoCliente.IdCliente = objUsuario.Logar(objAutenticaLogin).Id;
                    TelaAcessoCliente formAcessoCliente = new TelaAcessoCliente();
                    formAcessoCliente.Show();
                }
            }
            else if (verifica && !(objLogin.ValidarAcesso(objAutenticaLogin)))
            {
                if (tentativas > 1)
                {
                    MessageBox.Show(this, $"Dados incorretos!\nVocê tem {--tentativas} restantes", "ERRO NA LEITURA DE DADOS", MessageBoxButtons.OK);
                    txtBoxLoginUsuario.Focus();
                }
                else
                {
                    MessageBox.Show(this, "Você não possui mais tentativas restantes", "BLOQUEIO DE ACESSO AO SISTEMA", MessageBoxButtons.OK);
                    Environment.Exit(0);
                }
            }
        }

        private bool VerificarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBoxLoginUsuario.Text) || string.IsNullOrWhiteSpace(txtBoxLoginSenha.Text) || 
                (cbBoxTipoUsuario.SelectedIndex != 0 && cbBoxTipoUsuario.SelectedIndex != 1))
            {
                MessageBox.Show(this, $"ERRO: Preencha corretamente os campos.", "ERRO NA LEITURA DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxLoginUsuario.Focus();
                return false;
            }
            return true;
        }
    }
}
