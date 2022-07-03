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
    public partial class TelaCadastroProduto : Form
    {
        private TelaProdutos formProdutos = new TelaProdutos();
        private Produto objProduto = new Produto();
        private static int ultimoId = 0;

        public TelaCadastroProduto()
        {
            InitializeComponent();

            this.LoadIdProduto();
        }

        private void LoadIdProduto()
        {
            ultimoId = Listas.ListaProdutos[0].Id;
            for (int i = 0; i < Listas.ListaProdutos.Count; i++)
            {
                if (Listas.ListaProdutos[i].Id > ultimoId) ultimoId = Listas.ListaProdutos[i].Id;
            }
            txtBoxCadastroIdProduto.AppendText($"{ultimoId + 1}");
        }

        //MENU ACESSO
        private void toolStripMenuItemFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja cancelar o cadastro do produto?", "CANCELAMENTO DE CADASTRO DE PRODUTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxCadastroIdProduto.Text) || string.IsNullOrEmpty(txtBoxCadastroTituloProduto.Text) ||
                    string.IsNullOrWhiteSpace(txtBoxCadastroTituloProduto.Text))
                {
                    throw new ArgumentNullException();
                }

                Produto objNovoProduto = new Produto
                {
                    Id = ultimoId + 1,
                    Titulo = txtBoxCadastroTituloProduto.Text,
                    Quantidade = (int)numericUpDownCadastroQuantidadeProduto.Value
                };

                string dadosNovoProduto = $"******* NOVO PRODUTO *******\n" +
                                            $"Produto Nº: {objNovoProduto.Id} \n" +
                                            $"Título: {objNovoProduto.Titulo} \n" +
                                            $"Status: {txtBoxCadastroStatusProduto.Text} \n" +
                                            $"Quantidade: {objNovoProduto.Quantidade}\n\n";

                if (MessageBox.Show(this, $"{dadosNovoProduto} \nDeseja salvar as alterações?", "SALVAR DADOS ALTERADOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    objProduto.Cadastrar(objNovoProduto);

                    if (MessageBox.Show("Produto cadastrado com sucesso!") == DialogResult.OK)
                    {
                        formProdutos.Refresh();
                        formProdutos.Update();
                        this.Close();
                        //Refresh/Update datagridview method [  ]
                    }
                }
            }
            catch (ArgumentNullException erro)
            {
                MessageBox.Show(this, $"ERRO: {erro.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}