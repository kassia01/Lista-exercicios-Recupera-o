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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso, multa, total,zero;
            peso = Convert.ToDouble(txtPeso.Text);
            zero = 0;
            total = peso - 50;

            if (peso>total)
            {
                multa = total * 4;
                txtMulta.Text = multa.ToString("C");
                txtExcesso.Text = total.ToString();
            }
            else
            {
                txtMulta.Text = zero.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
