using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Atividade_8
{
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] Nome = new string[10];
            string Aux = "";
            int[] Caracter = new int[10];

            for (int i = 0; i < Nome.Length; i++)
            {
                Aux = Interaction.InputBox("Digite " + (i + 1).ToString() + "º nome completo:");

                if (Aux != "")
                {
                    Nome[i] = Aux;
                    Aux = Nome[i].Replace(" ", "");
                    Caracter[i] = Aux.Length;

                    listView1.Items.Add("O nome " + Nome[i] + " tem " + Caracter[i] + " caracteres.");
                }
                else
                {
                    MessageBox.Show("Nome não pode estar em branco!");
                    i--;
                }
            }

        }
    }
}
