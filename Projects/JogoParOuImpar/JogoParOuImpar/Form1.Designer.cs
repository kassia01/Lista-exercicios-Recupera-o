namespace JogoParOuImpar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBoxEscolha = new System.Windows.Forms.GroupBox();
            this.radioBtnPar = new System.Windows.Forms.RadioButton();
            this.radioBtnImpar = new System.Windows.Forms.RadioButton();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.groupBoxEscolha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(66, 57);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(91, 13);
            this.lblNomeJogador.TabIndex = 0;
            this.lblNomeJogador.Text = "Nome do Jogador";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(60, 73);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(108, 20);
            this.txtNome.TabIndex = 1;
            // 
            // groupBoxEscolha
            // 
            this.groupBoxEscolha.Controls.Add(this.radioBtnImpar);
            this.groupBoxEscolha.Controls.Add(this.radioBtnPar);
            this.groupBoxEscolha.Location = new System.Drawing.Point(60, 144);
            this.groupBoxEscolha.Name = "groupBoxEscolha";
            this.groupBoxEscolha.Size = new System.Drawing.Size(134, 81);
            this.groupBoxEscolha.TabIndex = 2;
            this.groupBoxEscolha.TabStop = false;
            this.groupBoxEscolha.Text = "Escolha :";
            // 
            // radioBtnPar
            // 
            this.radioBtnPar.AutoSize = true;
            this.radioBtnPar.Location = new System.Drawing.Point(12, 38);
            this.radioBtnPar.Name = "radioBtnPar";
            this.radioBtnPar.Size = new System.Drawing.Size(41, 17);
            this.radioBtnPar.TabIndex = 0;
            this.radioBtnPar.TabStop = true;
            this.radioBtnPar.Text = "Par";
            this.radioBtnPar.UseVisualStyleBackColor = true;
            // 
            // radioBtnImpar
            // 
            this.radioBtnImpar.AutoSize = true;
            this.radioBtnImpar.Location = new System.Drawing.Point(73, 38);
            this.radioBtnImpar.Name = "radioBtnImpar";
            this.radioBtnImpar.Size = new System.Drawing.Size(51, 17);
            this.radioBtnImpar.TabIndex = 1;
            this.radioBtnImpar.TabStop = true;
            this.radioBtnImpar.Text = "Impar";
            this.radioBtnImpar.UseVisualStyleBackColor = true;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(275, 140);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(253, 156);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(81, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(162, 256);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(85, 38);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 321);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.groupBoxEscolha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNomeJogador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxEscolha.ResumeLayout(false);
            this.groupBoxEscolha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBoxEscolha;
        private System.Windows.Forms.RadioButton radioBtnImpar;
        private System.Windows.Forms.RadioButton radioBtnPar;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnJogar;
    }
}

