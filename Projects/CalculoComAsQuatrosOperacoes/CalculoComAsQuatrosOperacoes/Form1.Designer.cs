namespace CalculoComAsQuatrosOperacoes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbN1 = new System.Windows.Forms.TextBox();
            this.txtbN2 = new System.Windows.Forms.TextBox();
            this.txtbSoma = new System.Windows.Forms.TextBox();
            this.txtbSubtrai = new System.Windows.Forms.TextBox();
            this.txtbmultiplica = new System.Windows.Forms.TextBox();
            this.txtbDivide = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite 2 números : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1° :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2° :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Somando será =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subtraindo será =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-1, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Multiplicando será =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dividindo será =";
            // 
            // txtbN1
            // 
            this.txtbN1.Location = new System.Drawing.Point(12, 48);
            this.txtbN1.Name = "txtbN1";
            this.txtbN1.Size = new System.Drawing.Size(100, 20);
            this.txtbN1.TabIndex = 7;
            // 
            // txtbN2
            // 
            this.txtbN2.Location = new System.Drawing.Point(161, 48);
            this.txtbN2.Name = "txtbN2";
            this.txtbN2.Size = new System.Drawing.Size(100, 20);
            this.txtbN2.TabIndex = 8;
            // 
            // txtbSoma
            // 
            this.txtbSoma.Location = new System.Drawing.Point(114, 99);
            this.txtbSoma.Name = "txtbSoma";
            this.txtbSoma.Size = new System.Drawing.Size(100, 20);
            this.txtbSoma.TabIndex = 9;
            // 
            // txtbSubtrai
            // 
            this.txtbSubtrai.Location = new System.Drawing.Point(114, 132);
            this.txtbSubtrai.Name = "txtbSubtrai";
            this.txtbSubtrai.Size = new System.Drawing.Size(100, 20);
            this.txtbSubtrai.TabIndex = 10;
            // 
            // txtbmultiplica
            // 
            this.txtbmultiplica.Location = new System.Drawing.Point(114, 163);
            this.txtbmultiplica.Name = "txtbmultiplica";
            this.txtbmultiplica.Size = new System.Drawing.Size(100, 20);
            this.txtbmultiplica.TabIndex = 11;
            // 
            // txtbDivide
            // 
            this.txtbDivide.Location = new System.Drawing.Point(114, 204);
            this.txtbDivide.Name = "txtbDivide";
            this.txtbDivide.Size = new System.Drawing.Size(100, 20);
            this.txtbDivide.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 274);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbDivide);
            this.Controls.Add(this.txtbmultiplica);
            this.Controls.Add(this.txtbSubtrai);
            this.Controls.Add(this.txtbSoma);
            this.Controls.Add(this.txtbN2);
            this.Controls.Add(this.txtbN1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculando com as 4 operações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbN1;
        private System.Windows.Forms.TextBox txtbN2;
        private System.Windows.Forms.TextBox txtbSoma;
        private System.Windows.Forms.TextBox txtbSubtrai;
        private System.Windows.Forms.TextBox txtbmultiplica;
        private System.Windows.Forms.TextBox txtbDivide;
        private System.Windows.Forms.Button button1;
    }
}

