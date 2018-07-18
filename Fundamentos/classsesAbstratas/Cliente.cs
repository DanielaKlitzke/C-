using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsesAbstratas
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public bool Emancipado { get; set; }
        public string rg;
        public string endereco;
        public int Idade { get; set; }

        public bool podeAbrirConta()
        {
            var maiorDeIdade = (this.Idade >= 18);
            var emancipado = (this.Emancipado);
            var temCpf = !string.IsNullOrEmpty(this.Cpf);

            return (maiorDeIdade || emancipado) && temCpf;
        }
    }
}
