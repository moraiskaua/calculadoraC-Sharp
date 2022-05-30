using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class frmCalculadora : Form
    {
        decimal valor1, valor2 = 0;
        string operacao = "";

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            
            if (txtResultado.Text != "") { 
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                if (operacao == "Soma")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                }else if (operacao == "Subtracao")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);
                }
                else if (operacao == "Multiplicacao")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);
                }
                else if (operacao == "Divisao")
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }

            }else
            {
                MessageBox.Show("Não é possivel obter o resultado de um valor nulo.");
            }

        }
        private void btnNumero0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Subtracao";
                lblOperacao.Text = "-";
            }else
            {
                MessageBox.Show("Não é possivel subtrair um valor nulo.");
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Multiplicacao";
                lblOperacao.Text = "x";
            }else
            {
                MessageBox.Show("Não é possivel multiplicar um valor nulo.");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Divisao";
                lblOperacao.Text = "÷";
            }else
            {
                MessageBox.Show("Não é possivel dividir um valor nulo.");
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Soma";
                lblOperacao.Text = "+";
            }else
            {
                MessageBox.Show("Não é possivel somar um valor nulo.");
            }
        }
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void btnApaga_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "") 
            { 
                txtResultado.Text = txtResultado.Text.Substring(0, txtResultado.Text.Length - 1);
            }else
            {
                MessageBox.Show("Não é possivel apagar um número nulo.");
            }
        }

        private void btnNumeroNegativo_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                txtResultado.Text = (decimal.Parse(txtResultado.Text) * -1).ToString();
            }

        }

        private void btnNumeroVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains('.'))
                txtResultado.Text += ".";
        }
    }
}
