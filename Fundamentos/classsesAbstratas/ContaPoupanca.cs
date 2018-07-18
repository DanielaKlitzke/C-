using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsesAbstratas
{
    class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor + 0.1;
        }

        public void CalculaInvestimento()
        {

        }
    }
}
