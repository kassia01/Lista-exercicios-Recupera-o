using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntecessorSucessor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, antecessor, sucessor;

            n1 = Convert.ToInt16(txtbN1.Text);

            antecessor = n1 - 1;
            txtbAntecessor.Text = antecessor.ToString();

            sucessor = n1 + 1;
            txtbSucessor.Text = sucessor.ToString();

        }
    }
}
