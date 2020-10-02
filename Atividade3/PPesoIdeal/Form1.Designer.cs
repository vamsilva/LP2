namespace PPesoIdeal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxSexo = new System.Windows.Forms.GroupBox();
            this.btnFeminino = new System.Windows.Forms.RadioButton();
            this.btnMasculino = new System.Windows.Forms.RadioButton();
            this.txtAltura = new System.Windows.Forms.MaskedTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtPesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.txtPesoIdeal = new System.Windows.Forms.MaskedTextBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.boxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso Atual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso Ideal";
            // 
            // boxSexo
            // 
            this.boxSexo.Controls.Add(this.btnFeminino);
            this.boxSexo.Controls.Add(this.btnMasculino);
            this.boxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxSexo.Location = new System.Drawing.Point(541, 131);
            this.boxSexo.Name = "boxSexo";
            this.boxSexo.Size = new System.Drawing.Size(199, 100);
            this.boxSexo.TabIndex = 6;
            this.boxSexo.TabStop = false;
            this.boxSexo.Text = "Sexo";
            // 
            // btnFeminino
            // 
            this.btnFeminino.AutoSize = true;
            this.btnFeminino.Location = new System.Drawing.Point(34, 66);
            this.btnFeminino.Name = "btnFeminino";
            this.btnFeminino.Size = new System.Drawing.Size(118, 29);
            this.btnFeminino.TabIndex = 8;
            this.btnFeminino.TabStop = true;
            this.btnFeminino.Text = "Feminino";
            this.btnFeminino.UseVisualStyleBackColor = true;
            // 
            // btnMasculino
            // 
            this.btnMasculino.AutoSize = true;
            this.btnMasculino.Location = new System.Drawing.Point(34, 33);
            this.btnMasculino.Name = "btnMasculino";
            this.btnMasculino.Size = new System.Drawing.Size(124, 29);
            this.btnMasculino.TabIndex = 7;
            this.btnMasculino.TabStop = true;
            this.btnMasculino.Text = "Marculino";
            this.btnMasculino.UseVisualStyleBackColor = true;
            this.btnMasculino.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(301, 136);
            this.txtAltura.Mask = "0.00";
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(158, 31);
            this.txtAltura.TabIndex = 9;
            this.txtAltura.ValidatingType = typeof(int);
            this.txtAltura.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtAltura_MaskInputRejected);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(219, 328);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 45);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(353, 328);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(106, 45);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(484, 328);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 45);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtPesoAtual
            // 
            this.txtPesoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoAtual.Location = new System.Drawing.Point(301, 185);
            this.txtPesoAtual.Mask = "00.00";
            this.txtPesoAtual.Name = "txtPesoAtual";
            this.txtPesoAtual.Size = new System.Drawing.Size(158, 31);
            this.txtPesoAtual.TabIndex = 13;
            this.txtPesoAtual.ValidatingType = typeof(int);
            this.txtPesoAtual.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtPesoIdeal
            // 
            this.txtPesoIdeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoIdeal.Location = new System.Drawing.Point(301, 231);
            this.txtPesoIdeal.Mask = "00.00";
            this.txtPesoIdeal.Name = "txtPesoIdeal";
            this.txtPesoIdeal.Size = new System.Drawing.Size(158, 31);
            this.txtPesoIdeal.TabIndex = 14;
            this.txtPesoIdeal.ValidatingType = typeof(int);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(91, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(637, 55);
            this.Titulo.TabIndex = 15;
            this.Titulo.Text = "Calcule seu peso ideal aqui!!";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.txtPesoIdeal);
            this.Controls.Add(this.txtPesoAtual);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.boxSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxSexo.ResumeLayout(false);
            this.boxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox boxSexo;
        private System.Windows.Forms.RadioButton btnMasculino;
        private System.Windows.Forms.RadioButton btnFeminino;
        private System.Windows.Forms.MaskedTextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.MaskedTextBox txtPesoAtual;
        private System.Windows.Forms.MaskedTextBox txtPesoIdeal;
        private System.Windows.Forms.Label Titulo;
    }
}

