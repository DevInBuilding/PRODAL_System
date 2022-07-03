using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODALsystem
{
    public enum EnumStatus
    {
        Ativo,
        Inativo
    }

    public class Cliente : Usuario
    {
        public bool Inativar()
        {
            if (this.Status.Equals(EnumStatus.Ativo.ToString()))
            {
                this.Status = EnumStatus.Inativo.ToString();
                return true;
            }
            return false;
        }

        public void InativarCliente(Cliente objCliente)
        {
            objCliente.Status = EnumStatus.Inativo.ToString();
        }

        public void AtivarCliente(Cliente objCliente)
        {
            objCliente.Status = EnumStatus.Ativo.ToString();
        }

        //public void QuitarPendencias() { }

    }
}