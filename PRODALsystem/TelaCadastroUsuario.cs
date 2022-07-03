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
    public partial class TelaCadastroUsuario : Form
    {
        private Usuario objUsuario = new Usuario();
        private Login objLogin = new Login();
        private RadioButton SelectedRBSexo = new RadioButton();

        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        private void TelaCadastro_Load(object sender, EventArgs e) { }

        //MENU DE ACESSO
        private void toolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair sem salvar os dados do usuário?", "MENSAGEM GERADA PELO SISTEMA", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }

        //DADOS PESSOAIS
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Você precisa escolher uma opção");

            }
            else if (rb.Checked)
            {
                SelectedRBSexo = rb;
            }
        }

        private void cbBoxCadastroTipoUsuario_SelectedIndexChanged(object sender, EventArgs e) { }

        //BOTAO
        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                var objNovoUsuario = new Usuario
                {
                    Nome = txtBoxCadastroNome.Text,
                    Cpf = txtBoxCadastroCpf.Text,
                    Sexo = SelectedRBSexo.Text,
                    Nascimento = dateTimePickerCadastroNascimento.Value,
                    Telefone = txtBoxCadastroTelefone.Text,
                    Email = txtBoxCadastroEmail.Text,
                    Endereco = txtBoxCadastroEndereco.Text,
                    Cep = txtBoxCadastroCep.Text,
                    Tipo = cbBoxCadastroTipoUsuario.Text,
                };
                var objNovoLogin = new Login
                {
                    LoginAcesso = txtBoxCadastroLogin.Text,
                    SenhaAcesso = txtBoxCadastroSenha.Text,
                    Tipo = cbBoxCadastroTipoUsuario.Text
                };

                string novoUsuario = $"********** NOVO USUÁRIO **********\n" +
                                     $"Nº ID:      {Listas.ListaUsuarios[Listas.ListaUsuarios.Count - 1].Id + 1}\n" +
                                     $"Nome:       {txtBoxCadastroNome.Text}\n" +
                                     $"CPF:        {txtBoxCadastroCpf.Text}\n" +
                                     $"Sexo:       {SelectedRBSexo.Text}\n" +
                                     $"Nascimento: {dateTimePickerCadastroNascimento.Text}\n" +
                                     $"Telefone:   {txtBoxCadastroTelefone.Text}\n" +
                                     $"Email:      {txtBoxCadastroEmail.Text}\n" +
                                     $"Endereço:   {txtBoxCadastroEndereco.Text}\n" +
                                     $"Cep:        {txtBoxCadastroCep.Text}\n\n" +
                                     $"* ACESSO * \n" +
                                     $"Tipo:       {cbBoxCadastroTipoUsuario.Text}\n" +
                                     $"Login:      {txtBoxCadastroLogin.Text}\n" +
                                     $"Senha:      {txtBoxCadastroSenha.Text}\n\n";

                if (MessageBox.Show(this, $"{novoUsuario} \nDeseja salvar os dados do usuário?", "CONFIRMAÇÃO DE CADASTRO DE USUÁRIOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objUsuario.Cadastrar(objNovoUsuario);
                    objLogin.CadastrarLogin(objNovoLogin);
                    MessageBox.Show(this, "Cadastro finalizado com sucesso!\n", "", MessageBoxButtons.OK);
                }
                //TelaAcesso reload => load event pode receber um número como parâmetro de execução
            }

        }

        private bool VerificarCampos()
        {
            if (string.IsNullOrEmpty(txtBoxCadastroNome.Text) || string.IsNullOrEmpty(txtBoxCadastroCpf.Text) ||
                string.IsNullOrEmpty(SelectedRBSexo.Text) || string.IsNullOrEmpty(dateTimePickerCadastroNascimento.Text) ||
                string.IsNullOrEmpty(txtBoxCadastroTelefone.Text) || string.IsNullOrEmpty(txtBoxCadastroEmail.Text) ||
                string.IsNullOrEmpty(txtBoxCadastroEndereco.Text) || string.IsNullOrEmpty(txtBoxCadastroCep.Text) ||
                string.IsNullOrEmpty(cbBoxCadastroTipoUsuario.Text) || string.IsNullOrEmpty(txtBoxCadastroLogin.Text) ||
                string.IsNullOrEmpty(txtBoxCadastroSenha.Text) || string.IsNullOrEmpty(txtBoxCadastroConfirmacaoSenha.Text))
            {
                MessageBox.Show(this, $"ERRO: Preencha corretamente os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxCadastroNome.Focus();
                return false;
            }
            return true;
        }

        private bool ValidacaoString(string str, int tamanho)
        {
            if (str.Length < tamanho || str.Length != tamanho) return false;

            bool validador = true;
            for (int cont = 1; cont < tamanho && validador; cont++)
            {
                if (str[cont] == str[0]) validador = false;
            }

            if (validador || str.Equals("12345678909") || str.Trim().ToUpper().Equals("ABCDEFGHIJK")) return false;

            return true;
        }

        private bool ValidacaoNome(string nome)
        {
            string valor = nome.Trim().ToUpper();

            bool validaNome = ValidacaoString(nome, 10);

            return validaNome;
        }

        private bool ValidacaoCpf(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");

            bool validaCpf = ValidacaoString(valor, 11);

            if (validaCpf)
            {
                int[] numCpf = new int[11];
                for (int cont = 0; cont < 11; cont++)
                {
                    numCpf[cont] = Int32.Parse(valor[cont].ToString());
                }

                //Continuar método de validação de CPF[ ]

                return true;
            }

            return false;
        }

        private bool ValidacaoTelefone(string telefone)
        {
            bool validaTel = ValidacaoString(telefone, 11);

            if (validaTel)
            {
                return true;
            }

            return false;
        }
    }
}