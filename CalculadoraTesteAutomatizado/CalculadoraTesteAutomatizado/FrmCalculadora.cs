using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTesteAutomatizado
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            Calculadora.Somar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            Calculadora.Subtrair(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            Calculadora.Multiplicar(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            Calculadora.Dividir(decimal.Parse(txtNum1.Text), decimal.Parse(txtNum2.Text));
        }
    }
}
