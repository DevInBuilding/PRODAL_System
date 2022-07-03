using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRODALsystem
{
    public class Login : Usuario
    {
        private string loginAcesso = string.Empty;
        private string senhaAcesso = string.Empty;

        public string LoginAcesso { get => loginAcesso; set => loginAcesso = value; }
        public string SenhaAcesso { get => senhaAcesso; set => senhaAcesso = value; }


        public bool CadastrarLogin(Login objTo)
        {
            foreach (Login objLogin in Listas.ListaLogins)
            {
                if (objLogin.Id != objTo.Id && !(objLogin.LoginAcesso.Equals(objTo.LoginAcesso)))
                {
                    this.Id = Listas.ListaUsuarios[Listas.ListaUsuarios.Count - 1].Id + 1;
                    this.LoginAcesso = objTo.LoginAcesso;
                    this.SenhaAcesso = objTo.SenhaAcesso;
                    this.Tipo = objTo.Tipo;

                    Listas.ListaLogins.Add(this);
                    return true;
                }
            }
            return false;
        }

        public bool ValidarAcesso(Login objTo)
        {
            foreach (Login objLogin in Listas.ListaLogins)
            {
                if (objTo.LoginAcesso.Equals(objLogin.LoginAcesso) &&
                        objTo.SenhaAcesso.Equals(objLogin.SenhaAcesso) &&
                        objTo.Tipo.Equals(objLogin.Tipo))
                {
                    objTo.Id = objLogin.Id;
                    return true;
                }
            }
            return false;
        }

        public bool EditarLogin(Login objTo)
        {
            foreach (Login objLogin in Listas.ListaLogins)
            {
                if (objTo.Id == objLogin.Id)
                {
                    objLogin.SenhaAcesso = objTo.SenhaAcesso;
                    return true;
                }
            }
            return false;
        }

    }
}
