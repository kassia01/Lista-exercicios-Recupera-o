using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadradoDaDiferença
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, total, diferenca;
            a = Convert.ToDouble(txtbN1.Text);
            b = Convert.ToDouble(txtbN2.Text);

            total = a - b;
            diferenca = total * total;
            txtbDiferenca.Text = diferenca.ToString();
            
        }
    }
}
