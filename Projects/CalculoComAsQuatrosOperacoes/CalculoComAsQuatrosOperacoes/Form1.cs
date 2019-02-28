using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoComAsQuatrosOperacoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, soma, divide, subtrai, multiplica;
            n1 = Convert.ToDouble(txtbN1.Text);
            n2 = Convert.ToDouble(txtbN2.Text);

            soma = n1 + n2;
            txtbSoma.Text = soma.ToString();

            divide = n1 / n2;
            txtbDivide.Text = divide.ToString();

            subtrai = n1 - n2;
            txtbSubtrai.Text = subtrai.ToString();

            multiplica = n1 * n2;
            txtbmultiplica.Text = multiplica.ToString();
        }
    }
}
