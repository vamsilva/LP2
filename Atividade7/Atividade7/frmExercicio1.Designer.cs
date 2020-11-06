namespace Atividade7
{
    partial class frmExercicio1
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
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnLetraR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(232, 52);
            this.rchTxt.MaxLength = 100;
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(317, 140);
            this.rchTxt.TabIndex = 0;
            this.rchTxt.Text = "";
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(119, 260);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(165, 74);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Espaço em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnLetraR
            // 
            this.btnLetraR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetraR.Location = new System.Drawing.Point(335, 260);
            this.btnLetraR.Name = "btnLetraR";
            this.btnLetraR.Size = new System.Drawing.Size(165, 74);
            this.btnLetraR.TabIndex = 2;
            this.btnLetraR.Text = "Letra R";
            this.btnLetraR.UseVisualStyleBackColor = true;
            this.btnLetraR.Click += new System.EventHandler(this.btnLetraR_Click);
            // 
            // btnPares
            // 
            this.btnPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPares.Location = new System.Drawing.Point(544, 260);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(165, 74);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Pares de letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetraR);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.rchTxt);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTxt;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnLetraR;
        private System.Windows.Forms.Button btnPares;
    }
}