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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int Branco = 0;

            while (contador < rchTxt.Text.Length)
            {
                if (char.IsWhiteSpace(rchTxt.Text[contador]))
                {
                    Branco = Branco + 1;
                }
                contador++;
            }

            MessageBox.Show("A quantidade de espaços em branco é: " + Branco.ToString());

        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int par = 0;
            char caracter = '\0';

            foreach (char c in rchTxt.Text)
            {
                if (Char.ToUpper(c) == caracter)
                {
                    par++;
                }
                caracter = Char.ToUpper(c);
            }

            MessageBox.Show("O número de letras que são pares é: " + par.ToString());

        }

        private void btnLetraR_Click(object sender, EventArgs e)
        {
            rchTxt.Text = rchTxt.Text.ToUpper();

            int contador = 0;
            int letraR = 0;

            for (contador = 0; contador < rchTxt.Text.Length; contador++)
            {
                if (rchTxt.Text[contador] == 'R')
                {
                    letraR = letraR + 1;
                }
            }

            MessageBox.Show("A quantidade de R é: " + letraR.ToString());

        }
    }
}
