using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPesoIdeal
{
    public partial class Form1 : Form
    {
        double Altura, PesoAtual, PesoIdeal;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPesoAtual.Clear();
            txtPesoIdeal.Clear();
        }

        private void txtAltura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out Altura) &&
                double.TryParse(txtPesoAtual.Text, out PesoAtual))
            {

                if (btnFeminino.Checked)
                {
                    PesoIdeal = (62.1 * Altura) - 44.7;
                    PesoIdeal = Math.Round(PesoIdeal, 2);
                    txtPesoIdeal.Text = PesoIdeal.ToString();
                }

                if (btnMasculino.Checked)
                {
                    PesoIdeal = (72.7 * Altura) - 58;
                    PesoIdeal = Math.Round(PesoIdeal, 2);
                    txtPesoIdeal.Text = PesoIdeal.ToString();
                }
            }


            if (PesoAtual > PesoIdeal)
                MessageBox.Show("Regime obrigatório já!");

            else
            {
                if (PesoAtual == PesoIdeal)
                    MessageBox.Show("Você está com peso ideal!");

                else
                    if (PesoAtual < PesoIdeal)
                        MessageBox.Show("Coma bastante!");
            }

        }


      
    }
}
