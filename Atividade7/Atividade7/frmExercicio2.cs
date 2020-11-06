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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int contador;
            double NumeroN;
            double NumeroH = 1;
            double resultado = 0;

            if (double.TryParse(txtNumeroN.Text, out NumeroN))
            {
                if (NumeroN > 0)
                {
                    for (contador = 1; contador <= NumeroN; contador++)
                    {
                        resultado = resultado + (NumeroH / contador);
                    }

                    MessageBox.Show("O resultado é: " + resultado.ToString());
                }

                else
                    MessageBox.Show("O número N deve ser maior que zero!!");
            }

            else
                MessageBox.Show("Deve ser inserido somente números!!");

        }
    }
}
