﻿namespace ConverterDolarParaReal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbReal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbDolar = new System.Windows.Forms.TextBox();
            this.txtbCotacao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Converter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite o valor da cotação do Dolar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite o valor em dolar :";
            // 
            // txtbReal
            // 
            this.txtbReal.Location = new System.Drawing.Point(163, 104);
            this.txtbReal.Name = "txtbReal";
            this.txtbReal.Size = new System.Drawing.Size(103, 20);
            this.txtbReal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor em R$ sera de:";
            // 
            // txtbDolar
            // 
            this.txtbDolar.Location = new System.Drawing.Point(285, 38);
            this.txtbDolar.Name = "txtbDolar";
            this.txtbDolar.Size = new System.Drawing.Size(100, 20);
            this.txtbDolar.TabIndex = 4;
            // 
            // txtbCotacao
            // 
            this.txtbCotacao.Location = new System.Drawing.Point(50, 38);
            this.txtbCotacao.Name = "txtbCotacao";
            this.txtbCotacao.Size = new System.Drawing.Size(104, 20);
            this.txtbCotacao.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbReal);
            this.Controls.Add(this.txtbDolar);
            this.Controls.Add(this.txtbCotacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Conversão Dolar para Real";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbReal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbDolar;
        private System.Windows.Forms.TextBox txtbCotacao;
    }
}

