using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomaDoQuadrado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, soma;
            n1 = Convert.ToDouble(txtbN1.Text);
            n2 = Convert.ToDouble(txtbN2.Text);
            n3 = Convert.ToDouble(txtbN3.Text);
            n4 = Convert.ToDouble(txtbN4.Text);

            soma = (n1 * n1) + (n2 * n2) + (n3 * n3) + (n4 * n4);

          txtbSoma.Text = soma.ToString();

        }
    }
}
