using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classsesAbstratas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPounpanca = new ContaPoupanca();

            contaCorrente.Deposita(100);
            contaPounpanca.Deposita(100);

            contaCorrente.Saca(10);
        }
    }
}
