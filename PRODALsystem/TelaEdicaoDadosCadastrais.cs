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
    public partial class TelaEdicaoDadosCadastrais : Form
    {
        public static int IdUsuario = 0;
        private Usuario objUsuario = new Usuario();

        public TelaEdicaoDadosCadastrais()
        {
            InitializeComponent();

            this.LoadDataUserDescription();
        }

        private void toolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair sem alterar os dados cadastrais?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        private void LoadDataUserDescription()
        {
            foreach (Usuario objDescUsuario in Listas.ListaUsuarios)
            {
                if (objDescUsuario.Id == IdUsuario)
                {
                    objUsuario = objDescUsuario;

                    txtBoxEdicaoIdUsuario.Text = objDescUsuario.Id.ToString();
                    txtBoxEdicaoStatusUsuario.Text = objDescUsuario.Status;
                    txtBoxEdicaoNomeUsuario.Text = objDescUsuario.Nome;
                    txtBoxEdicaoCpfUsuario.Text = objDescUsuario.Cpf;
                    txtBoxEdicaoSexoUsuario.Text = objDescUsuario.Sexo;
                    txtBoxEdicaoNascimentoUsuario.Text = objDescUsuario.Nascimento.ToString();
                    txtBoxEdicaoTelefoneUsuario.Text = objDescUsuario.Telefone;
                    txtBoxEdicaoEmailUsuario.Text = objDescUsuario.Email;
                    txtBoxEdicaoEnderecoUsuario.Text = objDescUsuario.Endereco;
                    txtBoxEdicaoCepUsuario.Text = objDescUsuario.Cep;
                }
            }
        }

        private void btnEdicaoSalvarAlteracaoCadastroUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxEdicaoNomeUsuario.Text) || string.IsNullOrWhiteSpace(txtBoxEdicaoTelefoneUsuario.Text) ||
               string.IsNullOrWhiteSpace(txtBoxEdicaoEmailUsuario.Text) || string.IsNullOrWhiteSpace(txtBoxEdicaoEnderecoUsuario.Text) ||
               string.IsNullOrWhiteSpace(txtBoxEdicaoCepUsuario.Text))
            {
                MessageBox.Show(this, "ERRO: Preencha corretamente os campos", "ERRO NA LEITURA DE DADOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxEdicaoNomeUsuario.Focus();
            }
            else
            {
                var objEditUsuario = new Usuario
                {
                    Id = objUsuario.Id,
                    Nome = txtBoxEdicaoNomeUsuario.Text,
                    Telefone = txtBoxEdicaoTelefoneUsuario.Text,
                    Email = txtBoxEdicaoEmailUsuario.Text,
                    Endereco = txtBoxEdicaoEnderecoUsuario.Text,
                    Cep = txtBoxEdicaoCepUsuario.Text
                };
                string descAlteracao = $"******** ALTERAÇÕES ********                   \n" +
                                        $"Id:       {objUsuario.Id}                     \n" +
                                        $"Nome:     {txtBoxEdicaoNomeUsuario.Text}      \n" +
                                        $"Telefone: {txtBoxEdicaoTelefoneUsuario.Text}  \n" +
                                        $"E-mail:   {txtBoxEdicaoEmailUsuario.Text}     \n" +
                                        $"Endereço: {txtBoxEdicaoEnderecoUsuario.Text}  \n" +
                                        $"CEP:      {txtBoxEdicaoCepUsuario.Text}       \n\n";

                if (MessageBox.Show(this, $"{descAlteracao} \nDeseja salvar os dados alterados?", "ALTERAÇÃO DE DADOS CADASTRAIS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objUsuario.Editar(objEditUsuario);
                    MessageBox.Show("Dados alterados com sucesso.");
                    //Refresh()
                    IdUsuario = 0;
                    this.Close();
                }
            }
        }
    }
}