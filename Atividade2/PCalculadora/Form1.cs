using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double numero1, numero2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 + numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show ("Números inválidos!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 - numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                resultado = numero1 * numero2;
                txtResultado.Text = resultado.ToString();
            }
            else
                MessageBox.Show("Números inválidos!");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out numero1) &&
                double.TryParse(txtNum2.Text, out numero2))
            {
                if (numero2 == 0)
                    MessageBox.Show("Não é possível dividir por zero!");
                else
                {
                    resultado = numero1 / numero2;
                    txtResultado.Text = resultado.ToString();
                }
            }
            else
                MessageBox.Show("Números inválidos!");
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
