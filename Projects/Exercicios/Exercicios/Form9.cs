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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);
            if (idade > 5 && idade <= 7) 
            {
                txtClassificacao.Text = (" INFANTIL A ");
            }
            else if (idade>7 && idade<=11)
            {
                txtClassificacao.Text = (" INFANTIL B ");
            }
            else if (idade > 12 && idade <= 13)
            {
                txtClassificacao.Text = (" JUVENIL A ");
            }
            else if (idade > 13 && idade <= 17)
            {
                txtClassificacao.Text = (" JUVENIL B ");
            }
            else
            {
                txtClassificacao.Text = (" ADULTO ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
