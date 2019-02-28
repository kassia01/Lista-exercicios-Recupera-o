using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 calculoMedia = new Form2();
            calculoMedia.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 maiorNumero = new Form3();
            maiorNumero.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 maiorMenorNumero = new Form4();
            maiorMenorNumero.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 balanca = new Form5();
           balanca.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 calculoSalario = new Form6();
          calculoSalario.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 subsidio  = new Form7();
            subsidio.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form8 desconto = new Form8();
            desconto.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form9 natacao = new Form9();
           natacao.ShowDialog();
        }
    }
}
