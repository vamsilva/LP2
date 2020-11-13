using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string Aux = "";

            for (int i = 0; i < Vetor.Length; i++)
            {
                Aux = Interaction.InputBox("Digite o número na posição" + (i + 1).ToString() + ": ");

                if (!(int.TryParse(Aux, out Vetor[i])))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
            }

            Aux = "";

            for (int i = Vetor.Length - 1; i > 0; i--)
            {
                Aux += Vetor[i].ToString() + "\n";
            }

            MessageBox.Show(Aux);

        }

        private void btnExercicio2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string Aux = "";

            for (int i = 0; i < Vetor.Length; i++)
            {
                Aux = Interaction.InputBox("Digite o número " + (i + 1).ToString() + ": ");

                if (!(int.TryParse(Aux, out Vetor[i])))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
            }

            Array.Reverse(Vetor);

            Aux = "";

            for (int i = Vetor.Length - 1; i >= 0; i--)
            {
                Aux += Vetor[i].ToString() + "\n";
            }

            MessageBox.Show(Aux);

        }

        private void btnExercicio3_Click(object sender, EventArgs e)
        {
            double[] Quantidade = new double[10];
            double[] Valor = new double[10];
            double Faturamento = 0;
            string Aux = "";

            bool OK = false;

            for (int i = 0; i < Quantidade.Length; i++)
            {
                if (!OK)
                {
                    Aux = Interaction.InputBox("Digite a quantidade do produto " + (i + 1).ToString() + ": ");

                    if (!(double.TryParse(Aux, out Quantidade[i])))
                    {
                        MessageBox.Show("Número inválida!");
                        i--;
                    }
                    else
                    {
                        OK = true;
                    }
                }
         
                Aux = Interaction.InputBox("Digite o valor do produto " + (i + 1).ToString() + ": ");

                if (!(double.TryParse(Aux, out Valor[i])))
                {
                    MessageBox.Show("Número inválido!");
                    i--;
                }
                else
                {
                    OK = false;
                }
            }

            for (int i = 0; i < Quantidade.Length; i++)
            {
                Faturamento += Quantidade[i] * Valor[i];
            }

            MessageBox.Show("Faturamento do mês: R$ " + Faturamento.ToString("N2"));

        }

        private void btnExercicio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            int Total = 0;

            for (int i = 0; i < Alunos.Length - 1; i++)
            {
                Total += Alunos[i].Length;
            }

            MessageBox.Show(Total.ToString());

        }

        private void btnExercicio5_Click(object sender, EventArgs e)
        {
            string texto = "";

            ArrayList arr = new ArrayList();

            arr.Add("Ana");
            arr.Add("André");
            arr.Add("Débora");
            arr.Add("Fátima");
            arr.Add("João");
            arr.Add("Janete");
            arr.Add("Otávio");
            arr.Add("Marcelo");
            arr.Add("Pedro");
            arr.Add("Thais");

            arr.Remove("Otávio");


            for (int i = 0; i < arr.Count; i++)
            {
                texto += arr[i] + "\n";
            }

            MessageBox.Show(texto);

        }

        private void btnExercicio6_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[20, 3];

            string Aux = "";

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                  Aux = Interaction.InputBox("Digite a nota " + (j + 1).ToString() + " do aluno " + (i + 1).ToString());

                    if (!(double.TryParse(Aux, out notas[i, j])))
                    {
                        MessageBox.Show("Valor de nota inválido!");
                        j--;
                    }
                }
            }

            Aux = "";

            for (int i = 0; i < 20; i++)
            {
                Aux += "Aluno " + (i + 1).ToString() + ": média " + ((notas[i, 0] + notas[i, 1] + notas[i, 2]) / 3).ToString("N2") + "\n";
            }

                 MessageBox.Show(Aux);

        }

        private void btnExercicio7_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frm2"];

            if (fc != null)
            {
                fc.Close();
            }

            frmExercicio7 FrmExercicio7 = new frmExercicio7();
            FrmExercicio7.Show();

        }
    }
}
