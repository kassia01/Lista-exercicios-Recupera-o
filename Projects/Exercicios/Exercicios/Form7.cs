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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string radioButton1;
            radioButton1 = ("Subsídio é de R$ 25,00");
            label2.Text = radioButton1.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string radioButton2;
            radioButton2 = ("Subsídio é de R$ 35,00");
            label2.Text = radioButton2.ToString();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string radioButton3;
            radioButton3 = ("Subsídio é de R$ 50,00");
            label2.Text = radioButton3.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
