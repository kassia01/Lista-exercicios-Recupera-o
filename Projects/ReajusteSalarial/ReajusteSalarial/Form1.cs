using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReajusteSalarial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, total;

            a = Convert.ToDouble(txtbSalario.Text);
            b = Convert.ToDouble(txtbreajuste.Text);


            total = (a * b / 100) + a;

            txtbtotal.Text = total.ToString("C");
        }
    }
}
