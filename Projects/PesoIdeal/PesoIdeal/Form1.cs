﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        RadioButton rbnSelecionado = null;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }
            private void SetPesoIdeal()
        {
            try
            {
                double altura = Convert.ToDouble(txtAltura.Text);
                double pesoIdeal;
                if (rbnSelecionado.Text.Equals("Masculino"))
                {
                    pesoIdeal = (72.7 * altura) - 58;
                    lblPesoIdeal.Text = pesoIdeal.ToString("N");
                }
                else
                {
                    pesoIdeal = (62.1 * altura) - 44.7;
                    lblPesoIdeal.Text = pesoIdeal.ToString("N");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Selecione o sexo e informe a altura corretamente", "Atenção!", MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void rbnFeminino_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rbn = (RadioButton)sender;
            if (rbn.Checked)
            {
                rbnSelecionado = rbn;
                SetPesoIdeal();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

       
    }

