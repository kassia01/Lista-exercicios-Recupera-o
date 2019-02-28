using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverterDolarParaReal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cotacao, dolar, real;
            cotacao = Convert.ToDouble(txtbCotacao.Text);
            dolar = Convert.ToDouble(txtbDolar.Text);

            real = dolar * cotacao;
           
            txtbReal.Text = real.ToString("C");  


        }
    }
}
