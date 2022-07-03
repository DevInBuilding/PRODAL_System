using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODALsystem
{
    public static class Listas
    {
        public static List<Usuario> ListaUsuarios = new List<Usuario>() {
            new Usuario{
                Id = 1,
                Nome = "Lucas Barros",
                Sexo = "Masculino",
                Cpf = Convert.ToUInt64("32165498355").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1999,08,11),
                Telefone = Convert.ToUInt64("98987654321").ToString(@"(00)\00000\-0000"),
                Endereco = "R. Duque Bacelar, Cd.Athenas Park III, B13, AP001, Parque Athenas, São Luís, MA",
                Cep = "65072-023",
                Email = "lbarros@ceapema.org.br",
                Tipo = "Administrador"
            },
            new Usuario{
                Id = 2,
                Nome = "Bruna Santos",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("77641598375").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1983,06,15),
                Telefone = Convert.ToUInt64("98986754231").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. General Arthur Carvalho, nº 04, Turu, São Luís, MA",
                Cep = "65000-000",
                Email = "bsantos@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Usuario{
                Id = 3,
                Nome = "Joana Bezerra",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("33321456378").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1988,02,02),
                Telefone = Convert.ToUInt64("98973024321").ToString(@"(00)\00000\-0000"),
                Endereco = "R. Afogados, nº 33, Centro, São Luís, MA",
                Cep = "65000-000",
                Email = "jbezerra@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Usuario{
                Id = 4,
                Nome = "Edem Bastos",
                Sexo = "Masculino",
                Cpf = Convert.ToUInt64("87956421310").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1995,10,15),
                Telefone = Convert.ToUInt64("98977045236").ToString(@"(00)\00000\-0000"),
                Endereco = "Av.Mato Grosso, nº 10, Habitacional Turu, São Luís, MA",
                Cep = "65010-052",
                Email = "ebastos@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Usuario{
                Id = 5,
                Nome = "Danilo Ferreira",
                Sexo = "Masculino",
                Cpf = Convert.ToUInt64("54689712344").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1985,07,07),
                Telefone = Convert.ToUInt64("98988010203").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. Mário Andreazza, nº 14, Recanto Fialho, São Luís, MA",
                Cep = "65000-000",
                Email = "dferreira@ceapema.org.br",
                Tipo = "Administrador"
            }
        };

        public static List<Produto> ListaProdutos = new List<Produto>()
        {
            new Produto{
                Id = 1,
                Titulo = "Notebook",
                Quantidade = 89,
                StatusProduto = EnumStatusProduto.Disponivel.ToString(),
                DataCadastro = DateTime.Today
            },
            new Produto{
                Id = 2,
                Titulo = "DataShow",
                Quantidade = 94,
                StatusProduto = EnumStatusProduto.Disponivel.ToString(),
                DataCadastro = DateTime.Today
            },
            new Produto{
                Id = 3,
                Titulo = "Caixa de Som",
                Quantidade = 71,
                StatusProduto = EnumStatusProduto.Disponivel.ToString(),
                DataCadastro = DateTime.Today
            },
            new Produto{
                Id = 4,
                Titulo = "Monitor",
                Quantidade = 45,
                StatusProduto = EnumStatusProduto.Disponivel.ToString(),
                DataCadastro = DateTime.Today
            },
            new Produto{
                Id = 5,
                Titulo = "Gabinete",
                Quantidade = 19,
                StatusProduto = EnumStatusProduto.Disponivel.ToString(),
                DataCadastro = DateTime.Today
            }
        };

        public static List<Login> ListaLogins = new List<Login>()
        {
            new Login{
                Id = ListaUsuarios[0].Id,
                LoginAcesso = "lbarros",
                SenhaAcesso = "adm111",
                Tipo = "Administrador"
            },
            new Login{
                Id = ListaUsuarios[1].Id,
                LoginAcesso = "bsantos",
                SenhaAcesso = "cli111",
                Tipo = "Cliente"
            },
            new Login{
                Id = ListaUsuarios[2].Id,
                LoginAcesso = "jbezerra",
                SenhaAcesso = "cli222",
                Tipo = "Cliente"
            },
            new Login{
                Id = ListaUsuarios[3].Id,
                LoginAcesso = "ebastos",
                SenhaAcesso = "cli333",
                Tipo = "Cliente"
            },
            new Login{
                Id = ListaUsuarios[4].Id,
                LoginAcesso = "dferreira",
                SenhaAcesso = "adm222",
                Tipo = "Administrador"
            }
        };

        public static List<Alocacao> ListaAlocacoes = new List<Alocacao>()
        {
            new Alocacao
            {
                CodigoAlocacao = 1,
                IdCliente = Listas.ListaUsuarios[0].Id,
                NomeCliente = Listas.ListaUsuarios[0].Nome,
                IdProduto = Listas.ListaProdutos[2].Id,
                TituloProduto = Listas.ListaProdutos[2].Titulo,
                QuantidadeAlocada = 26,
                DataRequisicao = DateTime.Now,
                StatusAlocacao = EnumStatusAlocacao.Reservado.ToString()
            },
            new Alocacao
            {
                CodigoAlocacao = 2,
                IdCliente = Listas.ListaUsuarios[1].Id,
                NomeCliente = Listas.ListaUsuarios[1].Nome,
                IdProduto = Listas.ListaProdutos[3].Id,
                TituloProduto = Listas.ListaProdutos[3].Titulo,
                QuantidadeAlocada = 18,
                DataRequisicao = DateTime.Now,
                StatusAlocacao = EnumStatusAlocacao.Reservado.ToString()
            },
            new Alocacao
            {
                CodigoAlocacao = 3,
                IdCliente = Listas.ListaUsuarios[2].Id,
                NomeCliente = Listas.ListaUsuarios[2].Nome,
                IdProduto = Listas.ListaProdutos[1].Id,
                TituloProduto = Listas.ListaProdutos[1].Titulo,
                QuantidadeAlocada = 31,
                DataRequisicao = DateTime.Now,
                StatusAlocacao = EnumStatusAlocacao.Reservado.ToString()
            },
            new Alocacao
            {
                CodigoAlocacao = 4,
                IdCliente = Listas.ListaUsuarios[3].Id,
                NomeCliente = Listas.ListaUsuarios[3].Nome,
                IdProduto = Listas.ListaProdutos[4].Id,
                TituloProduto = Listas.ListaProdutos[4].Titulo,
                QuantidadeAlocada = 15,
                DataRequisicao = DateTime.Now,
                StatusAlocacao = EnumStatusAlocacao.Reservado.ToString()
            },
            new Alocacao
            {
                CodigoAlocacao = 5,
                IdCliente = Listas.ListaUsuarios[4].Id,
                NomeCliente = Listas.ListaUsuarios[4].Nome,
                IdProduto = Listas.ListaProdutos[0].Id,
                TituloProduto = Listas.ListaProdutos[0].Titulo,
                QuantidadeAlocada = 33,
                DataRequisicao = DateTime.Now,
                StatusAlocacao = EnumStatusAlocacao.Reservado.ToString()
            }
            //Caso um usuário seja inativado do sistema, a alocação deste deixará de existir?
        };

        public static List<Cliente> ListaClientes = new List<Cliente>()
        {
            new Cliente
            {
                Id = ListaUsuarios[0].Id,
                Nome = "Bruna Santos",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("77641598375").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1983,06,15),
                Telefone = Convert.ToUInt64("98986754231").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. General Arthur Carvalho, nº 04, Turu, São Luís, MA",
                Cep = "65000-000",
                Email = "bsantos@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Cliente
            {
                Id = 2,
                Nome = "Bruna Santos",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("77641598375").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1983,06,15),
                Telefone = Convert.ToUInt64("98986754231").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. General Arthur Carvalho, nº 04, Turu, São Luís, MA",
                Cep = "65000-000",
                Email = "bsantos@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Cliente
            {
                Id = 2,
                Nome = "Bruna Santos",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("77641598375").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1983,06,15),
                Telefone = Convert.ToUInt64("98986754231").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. General Arthur Carvalho, nº 04, Turu, São Luís, MA",
                Cep = "65000-000",
                Email = "bsantos@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Cliente
            {
                Id = 2,
                Nome = "Bruna Santos",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("77641598375").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1983,06,15),
                Telefone = Convert.ToUInt64("98986754231").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. General Arthur Carvalho, nº 04, Turu, São Luís, MA",
                Cep = "65000-000",
                Email = "bsantos@ceapema.org.br",
                Tipo = "Cliente"
            },
            new Cliente
            {
                Id = 2,
                Nome = "Bruna Santos",
                Sexo = "Feminino",
                Cpf = Convert.ToUInt64("77641598375").ToString(@"000\.000\.000\-00"),
                Nascimento = new DateTime(1983,06,15),
                Telefone = Convert.ToUInt64("98986754231").ToString(@"(00)\00000\-0000"),
                Endereco = "Av. General Arthur Carvalho, nº 04, Turu, São Luís, MA",
                Cep = "65000-000",
                Email = "bsantos@ceapema.org.br",
                Tipo = "Cliente"
            }
        };

        public static List<Cliente> GerarListaClientes(List<Usuario> listaUsuarios)
        {
            foreach (Usuario objUsuario in listaUsuarios)
            {
                if (objUsuario.Tipo.Equals("Cliente"))
                {
                    ListaClientes.Add((Cliente)objUsuario);
                }
            }
            return ListaClientes;
        }

        public static List<Administrador> ListaAdministradores = new List<Administrador>();

        public static List<Administrador> GerarListaAdmins(List<Usuario> listaUsuarios)
        {
            foreach (Usuario objUsuario in listaUsuarios)
            {
                if (objUsuario.Tipo.Equals("Adminstrador"))
                {
                    ListaAdministradores.Add((Administrador)objUsuario);
                }
            }
            return ListaAdministradores;
        }

    }
}