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
    public partial class TelaProdutos : Form
    {
        private Produto objProduto = new Produto();
        private ToolTip toolTipMessage = new ToolTip();

        public TelaProdutos()
        {
            InitializeComponent();

            this.CreateColumssGridProdutos();
            this.LoadRowsGridProdutos();
        }

        //MENU ACESSO
        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja mesmo sair?", "MENSAGEM GERADA PELO SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        //SESSAO PESQUISA        
        private void SearchProductsDGV(Produto objProd)
        {
            objProduto.ConsultarProduto(objProd);
        }

        private void cbBoxFiltroProdutos_MouseEnter(object sender, EventArgs e)
        {
            toolTipMessage.SetToolTip(cbBoxFiltroProdutos, "Selecione um tipo de filtro");
        }
        private void txtBoxPesquisaListaProdutos_MouseEnter(object sender, EventArgs e)
        {
            toolTipMessage.SetToolTip(txtBoxBuscaProduto, "Insira o código ou o título do produto, conforme selecionado no filtro");
        }

        private void btnPesquisaListaProdutos_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxBuscaProduto.Text))
            {
                MessageBox.Show(this, "ERRO: Preencha o campo de busca corretamente.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string valBusca = txtBoxBuscaProduto.Text;
                DGVListaProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                bool resultado = false;
                foreach (DataGridViewRow row in DGVListaProdutos.Rows)
                {
                    DGVListaProdutos.Rows[row.Index].Selected = false;
                    for (int i = 0; i < 2; i++)
                    {
                        if (row.Cells[i].Value != null && (row.Cells[i].Value.ToString().Equals(valBusca) ||
                             row.Cells[i].Value.ToString().ToUpper().Replace(" ", "").Equals(valBusca.ToUpper().Replace(" ", ""))))
                        {
                            DGVListaProdutos.Rows[row.Index].Selected = true;                            
                            objProduto = (Produto)DGVListaProdutos.Rows[row.Index].DataBoundItem;
                            LoadDataProductDescription(objProduto);
                            resultado = true;
                            break;
                        }
                    }
                }
                if (!resultado)
                {
                    MessageBox.Show("Não foi possível localizar o produto");
                    return;
                }
            }
        }

        private void tsMenuItemAcessoProdutos_Click(object sender, EventArgs e) { }

        //DGV - TABELA DE PRODUTOS
        private void CreateColumssGridProdutos()
        {
            DGVListaProdutos.AutoGenerateColumns = false;
            DGVListaProdutos.AllowUserToAddRows = false;
            DGVListaProdutos.Columns.Clear();

            AddColumn("Id", "Código", "IdProduto");
            AddColumn("Titulo", "Título do Produto", "TituloProduto");
            AddColumn("Quantidade", "Quantidade", "QuantidadeProduto");
            AddColumn("StatusProduto", "Status", "StatusProduto");
            AddColumn("DataCadastro", "Data de Cadastro", "DataCadastroProduto");
        }
        private void AddColumn(string propertyName, string headerText, string columnName)
        {
            DGVListaProdutos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = propertyName,
                HeaderText = headerText,
                Name = columnName,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }


        private void LoadRowsGridProdutos()
        {
            DGVListaProdutos.DataSource = Listas.ListaProdutos;
        }

        private void DGVListaProdutos_SelectionChanged(object sender, EventArgs e)
        {
            this.DGVListaProdutos_GetProdutoByRow();
        }
        private void DGVListaProdutos_GetProdutoByRow()
        {
            if (DGVListaProdutos.CurrentRow != null && DGVListaProdutos.CurrentRow.DataBoundItem != null)
            {
                objProduto = (Produto)DGVListaProdutos.CurrentRow.DataBoundItem;
                LoadDataProductDescription(objProduto);
            }
        }

        //SESSAO DESCRICAO
        private void LoadDataProductDescription(Produto objProduto)
        {
            lblDescricaoTituloProduto.Text = objProduto.Titulo.ToString();
            txtBoxDescricaoIdProduto.Text = objProduto.Id.ToString();
            txtBoxDescricaoStatusProduto.Text = objProduto.StatusProduto.ToString();
            txtBoxDescricaoQuantidadeProduto.Text = objProduto.Quantidade.ToString();
            txtBoxDescricaoDataCadastroProduto.Text = objProduto.DataCadastro.ToString();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxDescricaoIdProduto.Text) || string.IsNullOrEmpty(txtBoxDescricaoStatusProduto.Text) ||
                string.IsNullOrEmpty(lblDescricaoQuantidadeProduto.Text) || string.IsNullOrEmpty(txtBoxDescricaoDataCadastroProduto.Text))
            {
                MessageBox.Show(this, $"ERRO: Não há produto selecionado para exclusão.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var objExclusaoProduto = new Produto();
                objExclusaoProduto = objProduto;

                if (MessageBox.Show(this, $"Tem certeza que deseja excluir o produto '{objExclusaoProduto.Titulo}' do sistema?",
                    "EXCLUSÃO DE PRODUTO DO SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    //Confirmar senha para ação [ ]
                    //objProduto.ExcluirProduto(objExclusaoProduto);           
                    MessageBox.Show(this, "Produto excluído com sucesso.", "EXCLUSÃO EFETUADA", MessageBoxButtons.OK);
                }
            }
        }

        private void DGVListaProdutos_Reload()
        {
            this.LoadRowsGridProdutos();
            this.DGVListaProdutos_GetProdutoByRow();
            //DGVListaProdutos.Update();
            //DGVListaProdutos.Refresh();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxDescricaoIdProduto.Text) || string.IsNullOrEmpty(txtBoxDescricaoStatusProduto.Text) ||
                string.IsNullOrEmpty(lblDescricaoQuantidadeProduto.Text) || string.IsNullOrEmpty(txtBoxDescricaoDataCadastroProduto.Text))
            {
                MessageBox.Show(this, $"ERRO: Não há produto selecionado para edição.\n", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            TelaEdicaoDadosProduto formEdicaoProduto = new TelaEdicaoDadosProduto();
            formEdicaoProduto.Show();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            TelaCadastroProduto formCadastroProduto = new TelaCadastroProduto();
            formCadastroProduto.Show();
        }

        //GET_ID
        public int GetProductID()
        {
            return objProduto.Id;
        }
    }
}