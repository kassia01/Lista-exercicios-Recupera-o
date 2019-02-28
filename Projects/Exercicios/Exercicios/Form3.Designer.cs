namespace Exercicios
{
    partial class Form3
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
            this.txtbN1 = new System.Windows.Forms.TextBox();
            this.txtbN2 = new System.Windows.Forms.TextBox();
            this.txtbN3 = new System.Windows.Forms.TextBox();
            this.txtbMaior = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite 3 números e te mostrarei o Maior ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1° número :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "2° número :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "3° número :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maior número é :";
            // 
            // txtbN1
            // 
            this.txtbN1.Location = new System.Drawing.Point(119, 65);
            this.txtbN1.Name = "txtbN1";
            this.txtbN1.Size = new System.Drawing.Size(100, 20);
            this.txtbN1.TabIndex = 5;
            // 
            // txtbN2
            // 
            this.txtbN2.Location = new System.Drawing.Point(119, 98);
            this.txtbN2.Name = "txtbN2";
            this.txtbN2.Size = new System.Drawing.Size(100, 20);
            this.txtbN2.TabIndex = 6;
            // 
            // txtbN3
            // 
            this.txtbN3.Location = new System.Drawing.Point(119, 139);
            this.txtbN3.Name = "txtbN3";
            this.txtbN3.Size = new System.Drawing.Size(100, 20);
            this.txtbN3.TabIndex = 7;
            // 
            // txtbMaior
            // 
            this.txtbMaior.Location = new System.Drawing.Point(119, 192);
            this.txtbMaior.Name = "txtbMaior";
            this.txtbMaior.Size = new System.Drawing.Size(107, 20);
            this.txtbMaior.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Verificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "SAIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbMaior);
            this.Controls.Add(this.txtbN3);
            this.Controls.Add(this.txtbN2);
            this.Controls.Add(this.txtbN1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Maior Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbN1;
        private System.Windows.Forms.TextBox txtbN2;
        private System.Windows.Forms.TextBox txtbN3;
        private System.Windows.Forms.TextBox txtbMaior;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}