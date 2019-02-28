using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculandoVolumeCaixaRetangular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double alt, larg, comp, total;
            alt = Convert.ToDouble(txtbAlt.Text);
            larg = Convert.ToDouble(txtbLarg.Text);
            comp = Convert.ToDouble(txtbCompri.Text);

            total = comp * larg * alt;

            txtbResultado.Text = total.ToString();
        }
    }
}
