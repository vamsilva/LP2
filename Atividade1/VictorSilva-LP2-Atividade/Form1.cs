using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VictorSilva_LP2_Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Clear();
            txtVolume.Clear();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Altura, Raio;
            if (double.TryParse(txtAltura.Text, out Altura) && (double.TryParse(txtRaio.Text, out Raio)))
            {
                double Volume;
                Volume = Math.PI * Math.Pow(Raio, 2) * Raio;
                txtVolume.Text = Volume.ToString("N2");

            }else MessageBox.Show("Os valores não são válidos");
        }
    }
}
