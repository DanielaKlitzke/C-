using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public String nome;
        public String rg;
        public String endereco;
        public int idade;

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }
    }
}
