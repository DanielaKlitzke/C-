using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsesAbstratas
{
    abstract class TotalizadorDeContas
    {
        public double Total { get; private set; }

        public void Soma(Conta conta)
        {
            this.Total += conta.Saldo;
        }
    }
}
