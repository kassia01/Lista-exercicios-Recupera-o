using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDeAdivinhacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int valorComputador, valorJogador;
            StreamWriter arquivo;
            String caminho = "c:\\Teste\\Placar.txt";
            arquivo = File.AppendText(caminho);
           
            Random dados = new Random();
            valorComputador = dados.Next(0, 11);
            valorJogador = Convert.ToInt32(txtValor.Text);
            if (valorComputador == valorJogador)
            {

                MessageBox.Show("VENCEU" + valorComputador.ToString());
                arquivo.Write(txtNome.Text);
                arquivo.WriteLine(" Ganhou ");
                arquivo.WriteLine();
                txtNome.Text = " ";
                txtValor.Text = " ";
                lblQtdTentativas.Text = "0";
            }
            else
            {
                MessageBox.Show(" Perdeu " + valorComputador.ToString());
                lblQtdTentativas.Text = (Convert.ToInt32(lblQtdTentativas.Text) + 1).ToString();
            }
            if (Convert.ToInt32(lblQtdTentativas.Text)==3)
            {
                MessageBox.Show(" Fim de Jogo ");
                arquivo.Write(txtNome.Text);
                arquivo.WriteLine(" Perdeu ");
                arquivo.WriteLine();
                txtNome.Text = " ";
                txtValor.Text = " ";
                lblQtdTentativas.Text = "0";

            }
            arquivo.Close();
        }

        private void btnPlacar_Click(object sender, EventArgs e)
        {
            string caminho = "c:\\Teste\\Placar.txt ";
            System.Diagnostics.Process.Start(" notepad ", caminho);
        }
    }
}
