using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODALsystem
{
    public class Usuario
    {
        private int id = 0;
        private string nome = string.Empty;
        private string sexo = string.Empty;
        private string cpf = string.Empty;
        private DateTime nascimento = DateTime.Today;
        private string telefone = string.Empty;
        private string endereco = string.Empty;
        private string cep = string.Empty;
        private string email = string.Empty;
        private string status = EnumStatus.Ativo.ToString();
        private string tipo = string.Empty;
        private DateTime dataCadastro = DateTime.Today;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime Nascimento { get => nascimento; set => nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Email { get => email; set => email = value; }
        public string Status { get => status; set => status = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }


        public bool Cadastrar(Usuario objNovoUsuario)
        {
            foreach (Usuario objUsuario in Listas.ListaUsuarios)
            {
                if (!(objNovoUsuario.Nome.Equals(objUsuario.Nome) && objNovoUsuario.Cpf.Equals(objUsuario.Cpf)))
                {
                    this.Id = Listas.ListaUsuarios[Listas.ListaUsuarios.Count - 1].Id + 1;
                    this.Nome = objNovoUsuario.Nome;
                    this.Sexo = objNovoUsuario.Sexo;
                    this.Cpf = objNovoUsuario.Cpf;
                    this.Nascimento = objNovoUsuario.Nascimento;
                    this.Telefone = objNovoUsuario.Telefone;
                    this.Endereco = objNovoUsuario.Endereco;
                    this.Cep = objNovoUsuario.Cep;
                    this.Email = objNovoUsuario.Email;
                    this.Tipo = objNovoUsuario.Tipo;

                    Listas.ListaUsuarios.Add(this);
                    return true;
                }
            }
            return false;
        }

        public Usuario Consultar(Usuario objTo)
        {
            foreach (Usuario objUsuario in Listas.ListaUsuarios)
            {
                if (objTo.Id == objUsuario.Id || objTo.Nome.Equals(objUsuario.Nome) || objTo.Cpf.Equals(objUsuario.Cpf))
                {
                    return objUsuario;
                }
            }
            return null;
        }

        public bool Excluir(Usuario objTo)
        {
            foreach (Usuario objUsuario in Listas.ListaUsuarios)
            {
                if (objUsuario.Id == objTo.Id || objUsuario.Cpf.Equals(objTo.Cpf) || objUsuario.Nome.Equals(objTo.Nome))
                {
                    Listas.ListaUsuarios.Remove(objUsuario);
                    return true;
                }
            }
            return false;
        }

        public bool Editar(Usuario objTo)
        {
            foreach (Usuario objUsuario in Listas.ListaUsuarios)
            {
                if (objUsuario.Id == objTo.Id || objUsuario.Cpf.Equals(objTo.Cpf) || objUsuario.Nome.Equals(objTo.Cpf))
                {
                    objUsuario.Nome = objTo.Nome;
                    objUsuario.Telefone = objTo.Telefone;
                    objUsuario.Email = objTo.Email;
                    objUsuario.Cep = objTo.Cep;
                    objUsuario.Endereco = objTo.Endereco;

                    return true;
                }
            }
            return false;
        }

        public Usuario Logar(Login objLogin)
        {
            foreach (Usuario objUsuario in Listas.ListaUsuarios)
            {
                if (objUsuario.Id == objLogin.Id)
                {
                    return objUsuario;
                }
            }
            return null;
        }
    }
}