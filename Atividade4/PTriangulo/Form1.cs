using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTriangulo
{
    public partial class Form1 : Form
    {
        double lado1, lado2, lado3;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLado1.Clear();
            txtLado2.Clear();
            txtLado3.Clear();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;

            if (double.TryParse(txtLado1.Text, out lado1) &&
                    (double.TryParse(txtLado2.Text, out lado2) &&
                        (double.TryParse(txtLado3.Text, out lado3))))
                if
                    ((lado1 == 0 || lado2 == 0 || lado3 == 0) || (lado1 + lado2 < lado3 || lado1 + lado3 < lado2 || lado2 + lado3 < lado1))
                    MessageBox.Show("Valores inválidos!!");
                else
                {
                    if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
                        MessageBox.Show("É um triângulo equilátero");
                    else
                    {
                        if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
                            MessageBox.Show("É um triângulo escaleno");
                        else
                            MessageBox.Show("É um triângulo isósceles");
                    }
                }
           else
               MessageBox.Show("Falha no preenchimento. Preencha todos os campos com números.");

        }
    }
}