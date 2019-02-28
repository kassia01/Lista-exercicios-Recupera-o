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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salario, horas, excedido, hrextras, slBruto;


            horas = Convert.ToDouble(txthora.Text);


            if (horas > 50)

            {
                excedido = horas - 50;
                hrextras = excedido * 20;
                salario = 50 * 10;
                txtExcesso.Text = hrextras.ToString("C");
                txtSalario.Text = salario.ToString("C");
                slBruto = hrextras + salario;
                txtTotal.Text = slBruto.ToString("C");

            }
            else
            {
                salario = horas * 10;
                hrextras = 0;
                txtSalario.Text = salario.ToString("C");
                txtTotal.Text = salario.ToString("C");
                txtExcesso.Text = hrextras.ToString("C");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
