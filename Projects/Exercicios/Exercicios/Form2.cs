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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, media;

            n1 = Convert.ToDouble(txtbN1.Text);
            n2 = Convert.ToDouble(txtbN2.Text);
            n3 = Convert.ToDouble(txtbN3.Text);
            n4 = Convert.ToDouble(txtbN4.Text);

            media = (n1 + n2 + n3 + n4) / 4;
            txtbMedia.Text = media.ToString();
            if (media >= 6)
            {
                txtSituacao.Text = (txtbNome.Text + " ,você foi aprovado!");
            }
            else
            {
                txtSituacao.Text = (txtbNome.Text + " , você foi reprovado!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
