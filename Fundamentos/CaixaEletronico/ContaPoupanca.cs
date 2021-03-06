﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class ContaPoupanca : Conta, ITributavel
    {
        public override bool Saca(double valor)
        {
            if (valor > this.Saldo || valor < 0)
            {
                return false;
            }
            else
            {
                this.Saldo -= valor;
                return true;
            }
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }

    }
}
