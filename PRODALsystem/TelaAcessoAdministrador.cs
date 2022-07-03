using System;
using System.Collections;
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
    public partial class TelaAcessoAdministrador : Form
    {
        public static int IdAdmin = 0;

        private Usuario objUsuario = new Usuario();
        private Alocacao objAlocacao = new Alocacao();
        private ToolTip toolTipMessage = new ToolTip();


        public TelaAcessoAdministrador()
        {
            InitializeComponent();

            this.LoadDataAdminDescription();
            this.CreateColumssGridAlocacoes();
            this.LoadRowsGridAlocacoes();
        }

        private void txtBoxIdAdm_TextChanged(object sender, EventArgs e) { }

        private void txtBoxNomeCliente_TextChanged(object sender, EventArgs e) { }

        private void txtBoxEmailAdm_TextChanged(object sender, EventArgs e) { }

        private void txtBoxCpfAdm_TextChanged(object sender, EventArgs e) { }

        private void txtBoxIdadeAdm_TextChanged(object sender, EventArgs e) { }

        //SESSÃO DESCRIÇÃO
        private void LoadDataAdminDescription()
        {
            foreach (Usuario objUser in Listas.ListaUsuarios)
            {
                if (IdAdmin == objUser.Id)
                {
                    int idade = DateTime.Today.Year - objUser.Nascimento.Year;

                    txtBoxIdAdm.Text = objUser.Id.ToString();
                    txtBoxIdadeAdm.Text = idade.ToString();
                    txtBoxNomeAdm.Text = objUser.Nome.ToString();
                    txtBoxEmailAdm.Text = objUser.Email.ToString();
                    txtBoxCpfAdm.Text = $"***.{objUser.Cpf.Substring(4, 6).ToString()}*-**";
                }
            }
        }

        //SESSÃO MENU
        private void toolStripMenuItemInativarCliente_Click(object sender, EventArgs e) { }

        private void dataGridViewRequisicaoAlocacoes_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void toolStripMenuItemCadastrarUsuario_Click(object sender, EventArgs e)
        {
            TelaCadastroUsuario formCadastroUsuario = new TelaCadastroUsuario();
            formCadastroUsuario.Show();
        }

        private void toolStripMenuItemEditarCadastroAdm_Click(object sender, EventArgs e)
        {
            TelaEdicaoDadosCadastrais.IdUsuario = IdAdmin;
            TelaEdicaoDadosCadastrais formEdicaoCadastro = new TelaEdicaoDadosCadastrais();
            formEdicaoCadastro.Show();
        }

        private void toolStripMenuItemSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair do sistema?", "MENSAGEM GERADA PELO SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var formLogin = Application.OpenForms.OfType<TelaLogin>().Single();
                this.Hide();
                formLogin.Refresh();
                formLogin.Show();                
            }
        }

        private void toolStripMenuItemConsultarClientes_Click(object sender, EventArgs e)
        {
            TelaConsultaClientes formConsultaClientes = new TelaConsultaClientes();
            formConsultaClientes.Show();
        }

        private void toolStripMenuItemAlteraSenha_Click(object sender, EventArgs e)
        {
            TelaEdicaoDadosLogin.IdUsuario = IdAdmin;
            TelaEdicaoDadosLogin formAlteracaoSenha = new TelaEdicaoDadosLogin();
            formAlteracaoSenha.Show();
        }

        private void toolStripMenuItemConsultarProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos formProdutos = new TelaProdutos();
            formProdutos.Show();
        }

        private void toolStripMenuItemCadastrarProduto_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto formCadastroProduto = new TelaCadastroProduto();
            formCadastroProduto.Show();
        }


        //SESSAO PESQUISA DE ALOCACAO
        private void txtBoxBuscaAlocacao_MouseEnter(object sender, EventArgs e)
        {
            toolTipMessage.SetToolTip(this.txtBoxBuscaAlocacao, "Digite o Código da Alocação ou ID do Cliente, de acordo com o filtro selecionado");
        }

        private void cbBoxFiltroAlocacao_MouseEnter(object sender, EventArgs e)
        {
            toolTipMessage.SetToolTip(this.cbBoxFiltroAlocacao, "Selecione um tipo de filtro");
        }

        private void btnBuscaAlocacao_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscaAlocacao.Text))
            {
                MessageBox.Show(this, "ERRO: Preencha corretamente o campo de busca.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string valBusca = txtBoxBuscaAlocacao.Text;
                DGVRequisicoesAlocacao.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                bool resultado = false;
                foreach (DataGridViewRow row in DGVRequisicoesAlocacao.Rows)
                {
                    DGVRequisicoesAlocacao.Rows[row.Index].Selected = false;
                    for (int i = 0; i < 3; i++)
                    {
                        if ( row.Cells[i].Value != null && (row.Cells[i].Value.ToString().Equals(valBusca) || 
                             row.Cells[i].Value.ToString().ToUpper().Replace(" ", "").Equals(valBusca.ToUpper().Replace(" ", ""))) )
                        {
                            DGVRequisicoesAlocacao.Rows[row.Index].Selected = true;
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

        //SESSÃO REQUISIÇÕES
        private void CreateColumssGridAlocacoes()
        {
            DGVRequisicoesAlocacao.AutoGenerateColumns = false;
            DGVRequisicoesAlocacao.AllowUserToAddRows = false;
            DGVRequisicoesAlocacao.Columns.Clear();

            AddColumn("CodigoAlocacao", "Nº Alocação", "CodigoAlocacao");
            AddColumn("NomeCliente", "Nome do Cliente", "NomeCliente");
            AddColumn("TituloProduto", "Título do Produto", "TituloProduto");
            AddColumn("QuantidadeAlocada", "Quantidade", "QuantidadeAlocada");
            AddColumn("DataRequisicao", "Data da Requisição", "DataRequisicao");
            AddColumn("StatusAlocacao", "Status", "StatusAlocacao");
        }
        private void AddColumn(string propertyName, string headerText, string columnName)
        {
            DGVRequisicoesAlocacao.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = propertyName,
                HeaderText = headerText,
                Name = columnName,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }

        private void LoadRowsGridAlocacoes()
        {
            DGVRequisicoesAlocacao.DataSource = Listas.ListaAlocacoes;
        }

        //RELOAD
        public void Reload_TelaAcesso(int counter)
        {
            if (counter < 0)
            {
                this.Refresh();
            }
        }

    }
}
