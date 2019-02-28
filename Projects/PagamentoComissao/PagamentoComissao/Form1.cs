using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagamentoComissao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double quantidade, valor, total,comissao ;

            quantidade = Convert.ToDouble(txtbQuantidade.Text);
            valor = Convert.ToDouble(txbValor.Text);
            total = quantidade * valor;
            comissao = (total * 5) / 100;

           txtbComissao.Text = comissao.ToString("C");
       }
        
    }
}
