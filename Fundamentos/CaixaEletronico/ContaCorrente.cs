using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaCorrente : Conta, ITributavel
    {
        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }

        public override bool Saca(double valor)
        {
            if (valor > this.Saldo || valor < 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= (valor + 0.1);
                return true;
            }
        }

        public static int TotalDeContas { get; set; }
        public ContaCorrente()
        {
            ContaCorrente.TotalDeContas++;
        }

        public static int ProximoNumero()
        {
            return ContaCorrente.TotalDeContas + 1;
        }

    }
}
