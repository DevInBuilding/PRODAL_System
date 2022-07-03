using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODALsystem
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.Run(new TelaLogin());
            //Application.Run(new TelaCadastroUsuario());

            //Application.Run(new TelaAcessoCliente());

            //Application.Run(new TelaEdicaoDadosCadastrais());
            //Application.Run(new TelaEdicaoDadosLogin());
            //Application.Run(new TelaAlocacaoProdutos());

            //Application.Run(new TelaAcessoAdministrador());
            //Application.Run(new TelaConsultaClientesCadastrados());

            //Application.Run(new TelaProdutos());
            //Application.Run(new TelaEdicaoDadosProduto());
            //Application.Run(new TelaCadastroProduto());
        }

    }
}
