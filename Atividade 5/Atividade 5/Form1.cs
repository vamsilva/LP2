using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NomeFuncionario = txtNome.Text;
            string texto = "";
            double SalarioBruto, SalarioLiquido, SalarioFamilia, DescontoINSS, DescontoIRPF = 0;
            int NumeroFilho;

            SalarioBruto = 0;
            SalarioLiquido = 0;
            SalarioFamilia = 0;
            DescontoINSS = 0;
            DescontoIRPF = 0;

            if ((NomeFuncionario != "") &&
                (double.TryParse(txtSalarioBruto.Text, out SalarioBruto) &&
                    (int.TryParse(txtNumeroFilho.Text, out NumeroFilho))))

            {
                if (SalarioBruto <= 800.47)
                {
                    DescontoINSS = SalarioBruto * 7.65 / 100;
                    txtAliquotaINSS.Text = "7.65%";
                    txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                }

                else if (SalarioBruto >= 800.48 && SalarioBruto <= 1400.77)
                {
                    DescontoINSS = SalarioBruto * 9.00 / 100;
                    txtAliquotaINSS.Text = "9.00%";
                    txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                }

                else if (SalarioBruto >= 1400.78 && SalarioBruto <= 2801.56)
                {
 
                    DescontoINSS = SalarioBruto * 11.00 / 100;
                    txtAliquotaINSS.Text = "11.00%";
                    txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                }

                else if (SalarioBruto > 2801.56)
                {
                    DescontoINSS = 308.17;
                    txtAliquotaINSS.Text = "R$308.17 (Teto)";
                    txtDescontoINSS.Text = DescontoINSS.ToString("N2");
                }



                if (SalarioBruto <= 1257.12)
                {
                    DescontoIRPF = 0;
                    txtAliquotaIRPF.Text = "0%";
                    txtDescontoIRPF.Text = DescontoIRPF.ToString("N2");
                }

                else if (SalarioBruto >= 1257.13 && SalarioBruto <= 2512.08)
                {
                    DescontoIRPF = SalarioBruto * 15.00 / 100;
                    txtAliquotaIRPF.Text = "15.00%";
                    txtDescontoIRPF.Text = DescontoIRPF.ToString("N2");
                }


                else if (SalarioBruto > 2512.08)
                {
                    DescontoIRPF = SalarioBruto * 27.5 / 100;
                    txtAliquotaIRPF.Text = "27.5%";
                    txtDescontoIRPF.Text = DescontoIRPF.ToString("N2");
                }



                if (SalarioBruto <= 435.52)
                {
                    SalarioFamilia = NumeroFilho * 22.33;
                    txtSalarioFamilia.Text = SalarioFamilia.ToString("N2");
                }

                else if (SalarioBruto >= 435.53 && SalarioBruto <= 654.61)
                {
                    SalarioFamilia = NumeroFilho * 15.74;
                    txtSalarioFamilia.Text = SalarioFamilia.ToString("N2");
                }

                else if (SalarioBruto > 654.61)
                {
                    SalarioFamilia = 0;
                    txtSalarioFamilia.Text = SalarioFamilia.ToString("N2");
                }


                SalarioLiquido = SalarioBruto + SalarioFamilia - DescontoINSS - DescontoIRPF;
                    txtSalarioLiquido.Text = SalarioLiquido.ToString("N2");


                texto = "Os descontos do salário";
                if (rrbtnF.Checked)
                    texto = texto + " da Sra " + NomeFuncionario ; 
                else 
                    texto = texto + "do Sr " + NomeFuncionario;

                if (chkCasado.Checked)
                    texto = texto + ", que é casado(a), "; 
                else 
                    texto=texto + ", que é solteiro(a), ";

                if (NumeroFilho > 0)
                    texto = texto + "que tem" + NumeroFilho + " filho(s) são:";
                else 
                    texto=texto + "que não tem filhos são:";

             
                lblDados.Text = texto;


            }

            else
                MessageBox.Show("Preencha todos os campos!!");
        }
    }
}