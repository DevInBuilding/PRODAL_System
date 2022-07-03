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
    public partial class TelaEdicaoDadosProduto : Form
    {
        private Produto objProduto = new Produto();
        private static int IdProduto = 0;

        public TelaEdicaoDadosProduto()
        {
            InitializeComponent();
            this.LoadDataTextDescription(objProduto);
        }

        private void LoadDataTextDescription(Produto objProduto)
        {
            var formProdutos = Application.OpenForms.OfType<TelaProdutos>().Single();
            IdProduto = formProdutos.GetProductID();

            foreach (Produto objEdicaoProduto in Listas.ListaProdutos)
            {
                if (IdProduto == objEdicaoProduto.Id)
                {
                    txtBoxEdicaoTituloProduto.Text = objEdicaoProduto.Titulo.ToString();
                    txtBoxEdicaoIdProduto.Text = objEdicaoProduto.Id.ToString();
                    cbBoxEdicaoStatusProduto.SelectedIndex = (objEdicaoProduto.StatusProduto.Equals(EnumStatusProduto.Disponivel.ToString())) ? 0 : 1;
                    numericUpDownEdicaoQuantidadeProduto.Value = objEdicaoProduto.Quantidade;

                    txtBoxEdicaoTituloProduto.Focus();
                }
            }
        }

        private void btnEdicaoSalvarDadosProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxEdicaoIdProduto.Text) || string.IsNullOrEmpty(txtBoxEdicaoTituloProduto.Text) ||
                string.IsNullOrWhiteSpace(txtBoxEdicaoTituloProduto.Text) || string.IsNullOrEmpty(cbBoxEdicaoStatusProduto.Text) ||
                string.IsNullOrWhiteSpace(cbBoxEdicaoStatusProduto.Text))
            {
                MessageBox.Show(this, $"ERRO: Preencha corretamente os campos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cbBoxEdicaoStatusProduto.SelectedIndex != 0 && cbBoxEdicaoStatusProduto.SelectedIndex != 1)
                {
                    MessageBox.Show("Selecione um tipo de status de produto");
                    cbBoxEdicaoStatusProduto.Focus();
                }
                else
                {
                    Produto ObjEdicaoProduto = new Produto
                    {
                        Id = IdProduto,
                        Titulo = txtBoxEdicaoTituloProduto.Text,
                        StatusProduto = cbBoxEdicaoStatusProduto.Text,
                        Quantidade = (int)numericUpDownEdicaoQuantidadeProduto.Value
                    };
                    string dadosAlteradosProduto = $"******* ALTERAÇÕES *******\n" +
                                                    $"Produto Nº: {ObjEdicaoProduto.Id} \n" +
                                                    $"Título: {ObjEdicaoProduto.Titulo} \n" +
                                                    $"Status: {ObjEdicaoProduto.StatusProduto} \n" +
                                                    $"Quantidade: {ObjEdicaoProduto.Quantidade}\n\n";

                    if (MessageBox.Show(this, $"{dadosAlteradosProduto} \nDeseja salvar as alterações?", "SALVAR DADOS ALTERADOS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        objProduto.EditarProduto(ObjEdicaoProduto);

                        if (MessageBox.Show("Alterações realizadas com sucesso!") == DialogResult.OK)
                        {
                            //Refresh();
                            this.Close();
                        }
                    }
                }
            }
        }

        private void toolStripMenuItemFecharEdicaoProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Deseja sair sem salvar as alterações?", "CANCELAMENTO DE EDIÇÃO DE DADOS", MessageBoxButtons.YesNo) == DialogResult.Yes) this.Close();
        }
    }
}