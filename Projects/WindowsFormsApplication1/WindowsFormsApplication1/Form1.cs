using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A, P, imc;


            P = Convert.ToDouble(txtbPeso.Text);
            A = Convert.ToDouble(txtbAlt.Text);


            imc = (P / (A * A));


            if (imc < 18)

                MessageBox.Show("PESO ABAIXO DO NORMAL");

            else if (imc >= 18 && imc <= 25)

                MessageBox.Show("Peso normal");

            else if (imc > 25 && imc <= 30)


                MessageBox.Show("Sobre o Peso");

            else if (imc > 30 && imc <= 35)

                MessageBox.Show("Grau de Obesidade I");

            else if (imc > 35 && imc <= 40)

                MessageBox.Show("Grau de Obesidade II");

            else if (imc > 40)

                MessageBox.Show("Obesidade Grau III");




        }
    }
}
