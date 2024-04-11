using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Funcional
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "7";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "8";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxResultado.Text != "")
            {
                valor1 = decimal.Parse(textBoxResultado.Text, CultureInfo.InvariantCulture);
                textBoxResultado.Text = "";
                operacao = "SOMA";
                labelOperacao.Text = "+";
            }
            else
            {

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text += "9";
        }
    }
}
