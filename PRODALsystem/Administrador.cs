using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODALsystem
{
    public class Administrador : Usuario
    {
        private string chaveAcesso = string.Empty;

        public string ChaveAcesso { get => chaveAcesso; set => chaveAcesso = value; }

        public void CriarLogin()
        {
            //Observar alterações [ ] 
        }

        public bool InativarCliente(Cliente objCliente)
        {
            if (objCliente.Status.Equals(EnumStatus.Ativo.ToString()))
            {
                objCliente.Status = EnumStatus.Inativo.ToString();
            }
            return false;
        }
    }
}