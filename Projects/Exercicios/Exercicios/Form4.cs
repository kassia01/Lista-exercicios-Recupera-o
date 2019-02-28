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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            num1 = Convert.ToInt32(txtN1.Text);
            num2 = Convert.ToInt32(txtN2.Text);

            if (num1 > num2)
            {
                lblResposta.Text = ("O número ," + num1 + ", é o Maior número");
            }
            else
                lblResposta.Text = ("O número ," + num1 + ", é o Menor número");





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
