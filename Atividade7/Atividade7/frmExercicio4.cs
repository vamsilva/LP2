using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade7
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double salario, producao, gratificacao, SalarioBruto, A = 0, B = 0, C = 0, D = 0;

            txtNome.Text = txtNome.Text.ToUpper();

            if ((txtNome.Text != string.Empty) &&
                (txtNumero.Text != string.Empty) &&
                (txtCargo.Text != string.Empty))
            {
                    salario = Convert.ToDouble(txtSalario.Text);
                    A = salario;

                if (double.TryParse(txtProd.Text, out producao) &&
                    double.TryParse(txtGratificacao.Text, out gratificacao))
                {
                    if (producao >= 100)
                    {
                        B = 1;
                    }


                    if (producao >= 120)
                    {
                        C = 1;
                    }


                    if (producao >= 150)
                    {
                        D = 1;
                    }

                    SalarioBruto = A + (A * ((0.05 * B) + (0.1 * C) + (0.1 * D))) + gratificacao;

                    if (SalarioBruto >= 7000 && producao < 150)
                    {
                        MessageBox.Show("Salário incompatível");
                    }
                    else
                        txtSalarioBruto.Text = SalarioBruto.ToString();
                }
            }
            else
                MessageBox.Show("Favor preencher todos os campos.");
        }
    }
}
