using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_6
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }

        private void frmExercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnNumericos_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int numeros = 0;
            for (contador=0; contador<rchTxt.Text.Length;contador++)
            {
                if (char.IsNumber(rchTxt.Text[contador]))

                {
                    numeros += 1;
                }
            }
            MessageBox.Show("A quantidade de números é: " + numeros.ToString());
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int posicaoBranco = 0;
            while (contador <rchTxt.Text.Length)
            {
                if(char.IsWhiteSpace(rchTxt.Text[contador]))
                {
                    posicaoBranco = contador;
                    break;

                }

                contador++;
            }
            MessageBox.Show("O primeiro caracter branco está na posição:" + 
                posicaoBranco.ToString());

        }

        private void btnAlfabetico_Click(object sender, EventArgs e)
        {
            int contador = 0;
            foreach (char chara in rchTxt.Text)
            {
                if (Char.IsLetter(chara))
                {
                    contador += 1;
                }
            }
            MessageBox.Show("O texto tem " + contador.ToString() + "caracteres alfabéticos");
        }
    }
}
