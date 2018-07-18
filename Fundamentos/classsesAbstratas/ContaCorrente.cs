using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsesAbstratas
{
    class ContaCorrente : Conta
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor;
        }
        /* public override void Atualiza(double taxa)
         {
             this.Saldo += this.Saldo * 2 * taxa;
         }*/
    }
}
