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
    public partial class TelaAcessoCliente : Form
    {
        public static int IdCliente = 0;

        private Usuario objUsuario = new Usuario();
        //private Cliente objCliente = new Cliente();

        public TelaAcessoCliente()
        {
            InitializeComponent();

            this.LoadDataClientDescription();
            //this.CreateColumssGridAlocacoes();
            //this.LoadRowsGridAlocacoes();
        }

        //SESSAO DESCRICAO
        private void LoadDataClientDescription()
        {
            foreach (Usuario objDescUsuario in Listas.ListaUsuarios)
            {
                if (objDescUsuario.Id == IdCliente)
                {
                    objUsuario = objDescUsuario;

                    int idade = DateTime.Today.Year - objUsuario.Nascimento.Year;

                    txtBoxIdCliente.Text = objUsuario.Id.ToString();
                    txtBoxStatusCliente.Text = objUsuario.Status;
                    txtBoxIdadeCliente.Text = idade.ToString();
                    txtBoxNomeCliente.Text = objUsuario.Nome;
                    txtBoxCpfCliente.Text = objUsuario.Cpf;
                    txtBoxEmailCliente.Text = objUsuario.Email;
                    txtBoxTelefoneCliente.Text = objUsuario.Telefone;
                }
            }
        }

        private void btnFiltroAlocacoesCliente_Click(object sender, EventArgs e) { }


        private void toolStripMenuItemEdicaoCadastroCliente_Click(object sender, EventArgs e)
        {
            TelaEdicaoDadosCadastrais.IdUsuario = objUsuario.Id;
            TelaEdicaoDadosCadastrais formEdicaoCadastro = new TelaEdicaoDadosCadastrais();
            formEdicaoCadastro.Show();
        }

        private void toolStripMenuItemEditarDadosLogin_Click(object sender, EventArgs e)
        {
            TelaEdicaoDadosLogin.IdUsuario = objUsuario.Id;
            TelaEdicaoDadosLogin formEdicaoLogin = new TelaEdicaoDadosLogin();
            formEdicaoLogin.Show();
        }

        private void toolStripMenuItemAlocaProdutoCliente_Click(object sender, EventArgs e)
        {
            TelaAlocacaoProduto formAlocacao = new TelaAlocacaoProduto();
            formAlocacao.Show();
        }

        private void toolStripMenuItemAlocacoesCliente_Click(object sender, EventArgs e) { }

        private void txtBoxBuscaAlocacoesCliente_TextChanged(object sender, EventArgs e) { }

        private void btnBuscaAlocacoesCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscaAlocacoesCliente.Text))
            {
                MessageBox.Show(this, "ERRO: Preencha o campo de busca corretamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string valBusca = txtBoxBuscaAlocacoesCliente.Text;
                DGVAlocacoesCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                bool resultado = false;
                foreach (DataGridViewRow row in DGVAlocacoesCliente.Rows)
                {
                    DGVAlocacoesCliente.Rows[row.Index].Selected = false;
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null &&
                             row.Cells[i].Value.ToString().ToUpper().Replace(" ", "").Equals(valBusca.ToUpper().Replace(" ", "")) )
                        {
                            DGVAlocacoesCliente.Rows[row.Index].Selected = true;
                            resultado = true;
                            break;
                        }
                    }
                }
                if (!resultado)
                {
                    MessageBox.Show("Não foi possível localizar a alocação");
                    return;
                }
            }
        }

        //SAIR DO SISTEMA
        private void toolStripMenuItemSairCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair do sistema?", "MENSAGEM GERADA PELO SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var formLogin = Application.OpenForms.OfType<TelaLogin>().Single();
                this.Hide();
                formLogin.Show();
            }
        }
    }
}