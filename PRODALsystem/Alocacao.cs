using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODALsystem
{
    public enum EnumStatusAlocacao
    {
        Reservado,
        Alocado,
        Devolvido,
        Cancelado
    }

    public class Alocacao
    {
        //Substituir Usuario por Cliente:
        private Usuario objUsuario = new Usuario();
        private Produto objProduto;

        private int codigoAlocacao = 0;
        private int idCliente = 0;
        private string nomeCliente = string.Empty;
        private int idProduto = 0;
        private string tituloProduto = string.Empty;
        private int quantidadeAlocada = 0;
        private DateTime dataLocacao = new DateTime();
        private DateTime dataRequisicao = new DateTime();
        private DateTime dataDevolucao = new DateTime();
        private string statusAlocacao = string.Empty;


        public Usuario ObjUsuario { get => objUsuario; set => objUsuario = value; }

        public int CodigoAlocacao { get => codigoAlocacao; set => codigoAlocacao = value; }
        public Produto ObjProduto { get => objProduto; set => objProduto = value; }
        public DateTime DataLocacao { get => dataLocacao; set => dataLocacao = value; }
        public DateTime DataRequisicao { get => dataRequisicao; set => dataRequisicao = value; }
        public DateTime DataDevolucao { get => dataDevolucao; set => dataDevolucao = value; }
        public string StatusAlocacao { get => statusAlocacao; set => statusAlocacao = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int QuantidadeAlocada { get => quantidadeAlocada; set => quantidadeAlocada = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string TituloProduto { get => tituloProduto; set => tituloProduto = value; }

        //public void Reservar(Alocacao, Usuario, Produto)

        public void Reservar(Alocacao objTo)
        {
            if (ObjUsuario.Status.Equals(EnumStatus.Ativo.ToString()))
            {
                this.CodigoAlocacao = Listas.ListaAlocacoes.Count + 1;
                this.IdCliente = objTo.ObjUsuario.Id;
                this.NomeCliente = objTo.ObjUsuario.Nome;
                this.IdProduto = objTo.ObjProduto.Id;
                this.TituloProduto = objTo.ObjProduto.Titulo;
                this.QuantidadeAlocada = objTo.QuantidadeAlocada;
                this.DataRequisicao = DateTime.Now;
                this.StatusAlocacao = EnumStatusAlocacao.Reservado.ToString();

                Listas.ListaAlocacoes.Add(this);
            }
        }

        public bool ExcluirAlocacao(Alocacao objTo)
        {
            foreach (Alocacao objAlocacao in Listas.ListaAlocacoes)
            {
                if (objTo.CodigoAlocacao == objAlocacao.CodigoAlocacao)
                {
                    Listas.ListaAlocacoes.Remove(objAlocacao);
                    return true;
                }
            }
            return false;
        }

        public Alocacao ConsultarAlocacao(Alocacao objTo)
        {
            foreach (Alocacao objAlocacao in Listas.ListaAlocacoes)
            {
                if (objTo.CodigoAlocacao == objAlocacao.CodigoAlocacao)
                {
                    return objAlocacao;
                }
            }
            return null;
        }

        public bool DespacharAlocacao() { return false; }

        public bool DevolverAlocacao() { return false; }

        public bool CancelarAlocacao(Alocacao objAlocacao)
        {
            if (!objAlocacao.StatusAlocacao.Equals(EnumStatusAlocacao.Cancelado.ToString()))
            {
                objAlocacao.StatusAlocacao = EnumStatusAlocacao.Cancelado.ToString();
                //Cancelados = Excluídos?
                return true;
            }
            return false;
        }

        private double CalcularValorEmprestimo(Produto objProduto, Cliente objCliente, int dias)
        {
            if (objProduto.StatusProduto.Equals(EnumStatusProduto.Disponivel.ToString()) && objCliente.Status.Equals(EnumStatus.Ativo.ToString()))
            {
                return dias * 5.25;
            }
            return -1;
        }

    }
}