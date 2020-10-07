namespace Atividade_5
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblNumeroFilho = new System.Windows.Forms.Label();
            this.lblAliquotaINSS = new System.Windows.Forms.Label();
            this.lblAliquotaIRPF = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.rrbtnF = new System.Windows.Forms.RadioButton();
            this.rrbtnM = new System.Windows.Forms.RadioButton();
            this.chkCasado = new System.Windows.Forms.CheckBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIRPF = new System.Windows.Forms.Label();
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtNumeroFilho = new System.Windows.Forms.TextBox();
            this.txtAliquotaIRPF = new System.Windows.Forms.TextBox();
            this.txtSalarioFamilia = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.txtDescontoIRPF = new System.Windows.Forms.TextBox();
            this.txtAliquotaINSS = new System.Windows.Forms.MaskedTextBox();
            this.lblDados = new System.Windows.Forms.Label();
            this.gboxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 37);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(187, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome do funcionário";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(43, 93);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(116, 24);
            this.lblSalarioBruto.TabIndex = 1;
            this.lblSalarioBruto.Text = "Salário Bruto";
            // 
            // lblNumeroFilho
            // 
            this.lblNumeroFilho.AutoSize = true;
            this.lblNumeroFilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFilho.Location = new System.Drawing.Point(43, 149);
            this.lblNumeroFilho.Name = "lblNumeroFilho";
            this.lblNumeroFilho.Size = new System.Drawing.Size(154, 24);
            this.lblNumeroFilho.TabIndex = 2;
            this.lblNumeroFilho.Text = "Número de filhos";
            // 
            // lblAliquotaINSS
            // 
            this.lblAliquotaINSS.AutoSize = true;
            this.lblAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaINSS.Location = new System.Drawing.Point(43, 320);
            this.lblAliquotaINSS.Name = "lblAliquotaINSS";
            this.lblAliquotaINSS.Size = new System.Drawing.Size(119, 24);
            this.lblAliquotaINSS.TabIndex = 3;
            this.lblAliquotaINSS.Text = "Alíquito INSS";
            // 
            // lblAliquotaIRPF
            // 
            this.lblAliquotaIRPF.AutoSize = true;
            this.lblAliquotaIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAliquotaIRPF.Location = new System.Drawing.Point(43, 364);
            this.lblAliquotaIRPF.Name = "lblAliquotaIRPF";
            this.lblAliquotaIRPF.Size = new System.Drawing.Size(117, 24);
            this.lblAliquotaIRPF.TabIndex = 4;
            this.lblAliquotaIRPF.Text = "Alíquita IRPF";
            // 
            // lblSalarioFamilia
            // 
            this.lblSalarioFamilia.AutoSize = true;
            this.lblSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFamilia.Location = new System.Drawing.Point(43, 406);
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            this.lblSalarioFamilia.Size = new System.Drawing.Size(132, 24);
            this.lblSalarioFamilia.TabIndex = 5;
            this.lblSalarioFamilia.Text = "Salário Família";
            this.lblSalarioFamilia.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(43, 453);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(134, 24);
            this.lblSalarioLiquido.TabIndex = 6;
            this.lblSalarioLiquido.Text = "Salário Líquido";
            // 
            // rrbtnF
            // 
            this.rrbtnF.AutoSize = true;
            this.rrbtnF.Checked = true;
            this.rrbtnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrbtnF.Location = new System.Drawing.Point(68, 28);
            this.rrbtnF.Name = "rrbtnF";
            this.rrbtnF.Size = new System.Drawing.Size(40, 28);
            this.rrbtnF.TabIndex = 7;
            this.rrbtnF.TabStop = true;
            this.rrbtnF.Text = "F";
            this.rrbtnF.UseVisualStyleBackColor = true;
            // 
            // rrbtnM
            // 
            this.rrbtnM.AutoSize = true;
            this.rrbtnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rrbtnM.Location = new System.Drawing.Point(68, 60);
            this.rrbtnM.Name = "rrbtnM";
            this.rrbtnM.Size = new System.Drawing.Size(44, 28);
            this.rrbtnM.TabIndex = 8;
            this.rrbtnM.Text = "M";
            this.rrbtnM.UseVisualStyleBackColor = true;
            // 
            // chkCasado
            // 
            this.chkCasado.AutoSize = true;
            this.chkCasado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCasado.Location = new System.Drawing.Point(763, 188);
            this.chkCasado.Name = "chkCasado";
            this.chkCasado.Size = new System.Drawing.Size(93, 28);
            this.chkCasado.TabIndex = 9;
            this.chkCasado.Text = "Casado";
            this.chkCasado.UseVisualStyleBackColor = true;
            // 
            // lblDescontoINSS
            // 
            this.lblDescontoINSS.AutoSize = true;
            this.lblDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoINSS.Location = new System.Drawing.Point(515, 312);
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            this.lblDescontoINSS.Size = new System.Drawing.Size(137, 24);
            this.lblDescontoINSS.TabIndex = 10;
            this.lblDescontoINSS.Text = "Desconto INSS";
            // 
            // lblDescontoIRPF
            // 
            this.lblDescontoIRPF.AutoSize = true;
            this.lblDescontoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescontoIRPF.Location = new System.Drawing.Point(515, 364);
            this.lblDescontoIRPF.Name = "lblDescontoIRPF";
            this.lblDescontoIRPF.Size = new System.Drawing.Size(136, 24);
            this.lblDescontoIRPF.TabIndex = 11;
            this.lblDescontoIRPF.Text = "Desconto IRPF";
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rrbtnM);
            this.gboxSexo.Controls.Add(this.rrbtnF);
            this.gboxSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSexo.Location = new System.Drawing.Point(744, 49);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Size = new System.Drawing.Size(154, 94);
            this.gboxSexo.TabIndex = 12;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(256, 30);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(439, 31);
            this.txtNome.TabIndex = 13;
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(256, 86);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(439, 31);
            this.txtSalarioBruto.TabIndex = 14;
            // 
            // txtNumeroFilho
            // 
            this.txtNumeroFilho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFilho.Location = new System.Drawing.Point(256, 142);
            this.txtNumeroFilho.Name = "txtNumeroFilho";
            this.txtNumeroFilho.Size = new System.Drawing.Size(201, 31);
            this.txtNumeroFilho.TabIndex = 15;
            // 
            // txtAliquotaIRPF
            // 
            this.txtAliquotaIRPF.Enabled = false;
            this.txtAliquotaIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaIRPF.Location = new System.Drawing.Point(249, 357);
            this.txtAliquotaIRPF.Name = "txtAliquotaIRPF";
            this.txtAliquotaIRPF.Size = new System.Drawing.Size(201, 31);
            this.txtAliquotaIRPF.TabIndex = 16;
            // 
            // txtSalarioFamilia
            // 
            this.txtSalarioFamilia.Enabled = false;
            this.txtSalarioFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioFamilia.Location = new System.Drawing.Point(249, 399);
            this.txtSalarioFamilia.Name = "txtSalarioFamilia";
            this.txtSalarioFamilia.Size = new System.Drawing.Size(201, 31);
            this.txtSalarioFamilia.TabIndex = 17;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioLiquido.Location = new System.Drawing.Point(249, 446);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(201, 31);
            this.txtSalarioLiquido.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(413, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Verificar Desconto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescontoINSS
            // 
            this.txtDescontoINSS.Enabled = false;
            this.txtDescontoINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoINSS.Location = new System.Drawing.Point(697, 305);
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            this.txtDescontoINSS.Size = new System.Drawing.Size(201, 31);
            this.txtDescontoINSS.TabIndex = 21;
            // 
            // txtDescontoIRPF
            // 
            this.txtDescontoIRPF.Enabled = false;
            this.txtDescontoIRPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescontoIRPF.Location = new System.Drawing.Point(697, 357);
            this.txtDescontoIRPF.Name = "txtDescontoIRPF";
            this.txtDescontoIRPF.Size = new System.Drawing.Size(201, 31);
            this.txtDescontoIRPF.TabIndex = 22;
            // 
            // txtAliquotaINSS
            // 
            this.txtAliquotaINSS.Enabled = false;
            this.txtAliquotaINSS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAliquotaINSS.Location = new System.Drawing.Point(249, 305);
            this.txtAliquotaINSS.Name = "txtAliquotaINSS";
            this.txtAliquotaINSS.Size = new System.Drawing.Size(201, 31);
            this.txtAliquotaINSS.TabIndex = 23;
            // 
            // lblDados
            // 
            this.lblDados.AutoSize = true;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.Location = new System.Drawing.Point(43, 259);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(832, 24);
            this.lblDados.TabIndex = 24;
            this.lblDados.Text = "---------------------------------------------------------------------------------" +
    "--------------------------------------------------------";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 509);
            this.Controls.Add(this.lblDados);
            this.Controls.Add(this.txtAliquotaINSS);
            this.Controls.Add(this.txtDescontoIRPF);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtSalarioFamilia);
            this.Controls.Add(this.txtAliquotaIRPF);
            this.Controls.Add(this.txtNumeroFilho);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.gboxSexo);
            this.Controls.Add(this.lblDescontoIRPF);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.chkCasado);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblAliquotaIRPF);
            this.Controls.Add(this.lblAliquotaINSS);
            this.Controls.Add(this.lblNumeroFilho);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblNumeroFilho;
        private System.Windows.Forms.Label lblAliquotaINSS;
        private System.Windows.Forms.Label lblAliquotaIRPF;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.RadioButton rrbtnF;
        private System.Windows.Forms.RadioButton rrbtnM;
        private System.Windows.Forms.CheckBox chkCasado;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIRPF;
        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtNumeroFilho;
        private System.Windows.Forms.TextBox txtAliquotaIRPF;
        private System.Windows.Forms.TextBox txtSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.TextBox txtDescontoIRPF;
        private System.Windows.Forms.MaskedTextBox txtAliquotaINSS;
        private System.Windows.Forms.Label lblDados;
    }
}

