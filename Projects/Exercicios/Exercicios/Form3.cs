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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            num1 = Convert.ToInt32(txtbN1.Text);
            num2 = Convert.ToInt32(txtbN2.Text);
            num3 = Convert.ToInt32(txtbN3.Text);

            if ((num1 > num2) && (num2 > num3))
            {
                txtbMaior.Text=num1.ToString();
            }
            else if ((num1 < num2) && (num2 > num3))
            {
                txtbMaior.Text = num2.ToString();
            }
            else
                txtbMaior.Text = num3.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
