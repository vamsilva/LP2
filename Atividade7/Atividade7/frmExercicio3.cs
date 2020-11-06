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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string TextoNormal, TextoSemEspaco, reverso;

            TextoNormal = txtPalavra.Text.ToUpper();
            TextoSemEspaco = TextoNormal.Replace(" ", "");

            reverso = new string(TextoSemEspaco.Reverse().ToArray());

            if (TextoSemEspaco == reverso)
            {
                MessageBox.Show("É um palíndromo!");
            }

            else
                MessageBox.Show("Não é um palíndromo!");
        }
    }
}
