using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODALsystem
{
    public enum EnumStatusProduto
    {
        Disponivel,
        Indisponivel
    }

    public class Produto
    {
        private int id = 0;
        private string titulo = string.Empty;
        private string statusProduto = string.Empty;
        private int quantidade = 0;
        private DateTime dataCadastro = DateTime.Now;

        public int Id { get => id; set => id = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string StatusProduto { get => statusProduto; set => statusProduto = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }


        public void Cadastrar(Produto objTo)
        {
            this.Id = objTo.Id;
            this.Titulo = objTo.Titulo;
            this.StatusProduto = EnumStatusProduto.Disponivel.ToString();
            this.Quantidade = objTo.Quantidade;
            this.DataCadastro = DateTime.Now;

            Listas.ListaProdutos.Add(this);
        }

        public bool EditarProduto(Produto objTo)
        {
            foreach (Produto objProduto in Listas.ListaProdutos)
            {
                if (objTo.id == objProduto.id)
                {
                    objProduto.Titulo = objTo.Titulo;
                    objProduto.Quantidade = objTo.Quantidade;
                    objProduto.StatusProduto = objTo.StatusProduto;
                    return true;
                }
            }
            return false;
        }

        public bool ExcluirProduto(Produto objTo)
        {
            foreach (Produto objProduto in Listas.ListaProdutos)
            {
                if (objTo.Id == objProduto.Id)
                {
                    Listas.ListaProdutos.Remove(objProduto);
                    return true;
                }
            }
            return false;
        }

        public Produto ConsultarProduto(Produto objTo)
        {
            foreach (Produto objProduto in Listas.ListaProdutos)
            {
                if ((objTo.Titulo).Equals(objProduto.Titulo))
                {
                    return objProduto;
                }
            }
            return null;
        }
    }
}
