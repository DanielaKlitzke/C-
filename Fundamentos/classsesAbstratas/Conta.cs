using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsesAbstratas
{
    abstract class Conta
    {
        public int Numero { get; set; }

        public Cliente Cliente { get; set; }

        public double Saldo { get; protected set; }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public abstract void Saca(double valor);
       /* {
            this.Saldo -= valor;
        }*/

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

        public virtual void Atualiza(double taxa)
        {
            this.Saldo += this.Saldo * taxa;
        }
    }
}
