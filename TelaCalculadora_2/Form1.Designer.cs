namespace TelaCalculadora_2
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.telaCalculo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.limpar = new System.Windows.Forms.Button();
            this.limparTudo = new System.Windows.Forms.Button();
            this.mais = new System.Windows.Forms.Button();
            this.menos = new System.Windows.Forms.Button();
            this.nove = new System.Windows.Forms.Button();
            this.oito = new System.Windows.Forms.Button();
            this.sete = new System.Windows.Forms.Button();
            this.multiplicacao = new System.Windows.Forms.Button();
            this.seis = new System.Windows.Forms.Button();
            this.cinco = new System.Windows.Forms.Button();
            this.quatro = new System.Windows.Forms.Button();
            this.dividir = new System.Windows.Forms.Button();
            this.tres = new System.Windows.Forms.Button();
            this.dois = new System.Windows.Forms.Button();
            this.um = new System.Windows.Forms.Button();
            this.igual = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.virgula = new System.Windows.Forms.Button();
            this.maisMenos = new System.Windows.Forms.Button();
            this.porcento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // telaCalculo
            // 
            this.telaCalculo.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telaCalculo.Location = new System.Drawing.Point(31, 96);
            this.telaCalculo.Name = "telaCalculo";
            this.telaCalculo.Size = new System.Drawing.Size(390, 42);
            this.telaCalculo.TabIndex = 0;
            this.telaCalculo.TextChanged += new System.EventHandler(this.telaCalculo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(116, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULADORA";
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.AliceBlue;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.Location = new System.Drawing.Point(130, 159);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(93, 75);
            this.limpar.TabIndex = 3;
            this.limpar.Text = "C";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // limparTudo
            // 
            this.limparTudo.BackColor = System.Drawing.Color.AliceBlue;
            this.limparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparTudo.Location = new System.Drawing.Point(229, 159);
            this.limparTudo.Name = "limparTudo";
            this.limparTudo.Size = new System.Drawing.Size(93, 75);
            this.limparTudo.TabIndex = 4;
            this.limparTudo.Text = "CE";
            this.limparTudo.UseVisualStyleBackColor = false;
            this.limparTudo.Click += new System.EventHandler(this.limparTudo_Click);
            // 
            // mais
            // 
            this.mais.BackColor = System.Drawing.Color.AliceBlue;
            this.mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais.Location = new System.Drawing.Point(328, 159);
            this.mais.Name = "mais";
            this.mais.Size = new System.Drawing.Size(93, 75);
            this.mais.TabIndex = 5;
            this.mais.Text = "MAIS (+)";
            this.mais.UseVisualStyleBackColor = false;
            this.mais.Click += new System.EventHandler(this.mais_Click);
            // 
            // menos
            // 
            this.menos.BackColor = System.Drawing.Color.AliceBlue;
            this.menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menos.Location = new System.Drawing.Point(328, 249);
            this.menos.Name = "menos";
            this.menos.Size = new System.Drawing.Size(93, 75);
            this.menos.TabIndex = 9;
            this.menos.Text = "MENOS (-)";
            this.menos.UseVisualStyleBackColor = false;
            this.menos.Click += new System.EventHandler(this.menos_Click);
            // 
            // nove
            // 
            this.nove.BackColor = System.Drawing.Color.AliceBlue;
            this.nove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nove.Location = new System.Drawing.Point(229, 249);
            this.nove.Name = "nove";
            this.nove.Size = new System.Drawing.Size(93, 75);
            this.nove.TabIndex = 8;
            this.nove.Text = "9";
            this.nove.UseVisualStyleBackColor = false;
            this.nove.Click += new System.EventHandler(this.nove_Click);
            // 
            // oito
            // 
            this.oito.BackColor = System.Drawing.Color.AliceBlue;
            this.oito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oito.Location = new System.Drawing.Point(130, 249);
            this.oito.Name = "oito";
            this.oito.Size = new System.Drawing.Size(93, 75);
            this.oito.TabIndex = 7;
            this.oito.Text = "8";
            this.oito.UseVisualStyleBackColor = false;
            this.oito.Click += new System.EventHandler(this.oito_Click);
            // 
            // sete
            // 
            this.sete.BackColor = System.Drawing.Color.AliceBlue;
            this.sete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sete.Location = new System.Drawing.Point(31, 249);
            this.sete.Name = "sete";
            this.sete.Size = new System.Drawing.Size(93, 75);
            this.sete.TabIndex = 6;
            this.sete.Text = "7";
            this.sete.UseVisualStyleBackColor = false;
            this.sete.Click += new System.EventHandler(this.sete_Click);
            // 
            // multiplicacao
            // 
            this.multiplicacao.BackColor = System.Drawing.Color.AliceBlue;
            this.multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacao.Location = new System.Drawing.Point(328, 345);
            this.multiplicacao.Name = "multiplicacao";
            this.multiplicacao.Size = new System.Drawing.Size(93, 75);
            this.multiplicacao.TabIndex = 13;
            this.multiplicacao.Text = "MULTI.(*)";
            this.multiplicacao.UseVisualStyleBackColor = false;
            this.multiplicacao.Click += new System.EventHandler(this.multiplicacao_Click);
            // 
            // seis
            // 
            this.seis.BackColor = System.Drawing.Color.AliceBlue;
            this.seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seis.Location = new System.Drawing.Point(229, 345);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(93, 75);
            this.seis.TabIndex = 12;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = false;
            this.seis.Click += new System.EventHandler(this.seis_Click);
            // 
            // cinco
            // 
            this.cinco.BackColor = System.Drawing.Color.AliceBlue;
            this.cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinco.Location = new System.Drawing.Point(130, 345);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(93, 75);
            this.cinco.TabIndex = 11;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = false;
            this.cinco.Click += new System.EventHandler(this.cinco_Click);
            // 
            // quatro
            // 
            this.quatro.BackColor = System.Drawing.Color.AliceBlue;
            this.quatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quatro.Location = new System.Drawing.Point(31, 345);
            this.quatro.Name = "quatro";
            this.quatro.Size = new System.Drawing.Size(93, 75);
            this.quatro.TabIndex = 10;
            this.quatro.Text = "4";
            this.quatro.UseVisualStyleBackColor = false;
            this.quatro.Click += new System.EventHandler(this.quatro_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.AliceBlue;
            this.dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dividir.Location = new System.Drawing.Point(328, 439);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(93, 75);
            this.dividir.TabIndex = 17;
            this.dividir.Text = "DIVIDIR(\\)";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.dividir_Click);
            // 
            // tres
            // 
            this.tres.BackColor = System.Drawing.Color.AliceBlue;
            this.tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tres.Location = new System.Drawing.Point(229, 439);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(93, 75);
            this.tres.TabIndex = 16;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = false;
            this.tres.Click += new System.EventHandler(this.tres_Click);
            // 
            // dois
            // 
            this.dois.BackColor = System.Drawing.Color.AliceBlue;
            this.dois.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dois.Location = new System.Drawing.Point(130, 439);
            this.dois.Name = "dois";
            this.dois.Size = new System.Drawing.Size(93, 75);
            this.dois.TabIndex = 15;
            this.dois.Text = "2";
            this.dois.UseVisualStyleBackColor = false;
            this.dois.Click += new System.EventHandler(this.dois_Click);
            // 
            // um
            // 
            this.um.BackColor = System.Drawing.Color.AliceBlue;
            this.um.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.um.Location = new System.Drawing.Point(31, 439);
            this.um.Name = "um";
            this.um.Size = new System.Drawing.Size(93, 75);
            this.um.TabIndex = 14;
            this.um.Text = "1";
            this.um.UseVisualStyleBackColor = false;
            this.um.Click += new System.EventHandler(this.um_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.AliceBlue;
            this.igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.igual.Location = new System.Drawing.Point(328, 531);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(93, 75);
            this.igual.TabIndex = 21;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.igual_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.AliceBlue;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zero.Location = new System.Drawing.Point(130, 531);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(93, 75);
            this.zero.TabIndex = 19;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // virgula
            // 
            this.virgula.BackColor = System.Drawing.Color.AliceBlue;
            this.virgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgula.Location = new System.Drawing.Point(229, 531);
            this.virgula.Name = "virgula";
            this.virgula.Size = new System.Drawing.Size(93, 75);
            this.virgula.TabIndex = 22;
            this.virgula.Text = ",";
            this.virgula.UseVisualStyleBackColor = false;
            this.virgula.Click += new System.EventHandler(this.virgula_Click);
            // 
            // maisMenos
            // 
            this.maisMenos.BackColor = System.Drawing.Color.AliceBlue;
            this.maisMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maisMenos.Location = new System.Drawing.Point(31, 531);
            this.maisMenos.Name = "maisMenos";
            this.maisMenos.Size = new System.Drawing.Size(93, 75);
            this.maisMenos.TabIndex = 23;
            this.maisMenos.Text = "_/+";
            this.maisMenos.UseVisualStyleBackColor = false;
            // 
            // porcento
            // 
            this.porcento.BackColor = System.Drawing.Color.AliceBlue;
            this.porcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcento.Location = new System.Drawing.Point(31, 159);
            this.porcento.Name = "porcento";
            this.porcento.Size = new System.Drawing.Size(93, 75);
            this.porcento.TabIndex = 24;
            this.porcento.Text = "%";
            this.porcento.UseVisualStyleBackColor = false;
            this.porcento.Click += new System.EventHandler(this.porcento_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.porcento);
            this.Controls.Add(this.maisMenos);
            this.Controls.Add(this.virgula);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dois);
            this.Controls.Add(this.um);
            this.Controls.Add(this.multiplicacao);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.quatro);
            this.Controls.Add(this.menos);
            this.Controls.Add(this.nove);
            this.Controls.Add(this.oito);
            this.Controls.Add(this.sete);
            this.Controls.Add(this.mais);
            this.Controls.Add(this.limparTudo);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telaCalculo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.MinimumSize = new System.Drawing.Size(500, 700);
            this.Name = "Calculadora";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "CALCULADORA_TI20N";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox telaCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button limparTudo;
        private System.Windows.Forms.Button mais;
        private System.Windows.Forms.Button menos;
        private System.Windows.Forms.Button nove;
        private System.Windows.Forms.Button oito;
        private System.Windows.Forms.Button sete;
        private System.Windows.Forms.Button multiplicacao;
        private System.Windows.Forms.Button seis;
        private System.Windows.Forms.Button cinco;
        private System.Windows.Forms.Button quatro;
        private System.Windows.Forms.Button dividir;
        private System.Windows.Forms.Button tres;
        private System.Windows.Forms.Button dois;
        private System.Windows.Forms.Button um;
        private System.Windows.Forms.Button igual;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button virgula;
        private System.Windows.Forms.Button maisMenos;
        private System.Windows.Forms.Button porcento;
    }
}

