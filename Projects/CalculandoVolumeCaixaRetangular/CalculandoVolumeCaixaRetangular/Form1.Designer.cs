namespace CalculandoVolumeCaixaRetangular
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbAlt = new System.Windows.Forms.TextBox();
            this.txtbLarg = new System.Windows.Forms.TextBox();
            this.txtbCompri = new System.Windows.Forms.TextBox();
            this.txtbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira os dados abaixo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Largura :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comprimento :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Volume é de :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbAlt
            // 
            this.txtbAlt.Location = new System.Drawing.Point(101, 58);
            this.txtbAlt.Name = "txtbAlt";
            this.txtbAlt.Size = new System.Drawing.Size(100, 20);
            this.txtbAlt.TabIndex = 6;
            // 
            // txtbLarg
            // 
            this.txtbLarg.Location = new System.Drawing.Point(101, 99);
            this.txtbLarg.Name = "txtbLarg";
            this.txtbLarg.Size = new System.Drawing.Size(100, 20);
            this.txtbLarg.TabIndex = 7;
            // 
            // txtbCompri
            // 
            this.txtbCompri.Location = new System.Drawing.Point(101, 140);
            this.txtbCompri.Name = "txtbCompri";
            this.txtbCompri.Size = new System.Drawing.Size(100, 20);
            this.txtbCompri.TabIndex = 8;
            // 
            // txtbResultado
            // 
            this.txtbResultado.Location = new System.Drawing.Point(100, 188);
            this.txtbResultado.Name = "txtbResultado";
            this.txtbResultado.Size = new System.Drawing.Size(100, 20);
            this.txtbResultado.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtbResultado);
            this.Controls.Add(this.txtbCompri);
            this.Controls.Add(this.txtbLarg);
            this.Controls.Add(this.txtbAlt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbAlt;
        private System.Windows.Forms.TextBox txtbLarg;
        private System.Windows.Forms.TextBox txtbCompri;
        private System.Windows.Forms.TextBox txtbResultado;
    }
}

