using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();
            cp.Deposita(10);
            ci.Deposita(100);
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            t.Acumula(cp);
            t.Acumula(ci);

            MessageBox.Show("Tributos " + t.Total);

            GerenciadorDeImposto gerenciador = new GerenciadorDeImposto();
            ContaPoupanca cp2 = new ContaPoupanca();
            SeguroDeVida sv = new SeguroDeVida();
            gerenciador.Adiciona(cp);
            gerenciador.Adiciona(sv);
            MessageBox.Show("Total: " + gerenciador.Total);

        }
    }
}
