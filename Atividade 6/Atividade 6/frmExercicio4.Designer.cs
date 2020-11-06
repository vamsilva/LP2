namespace Atividade_6
{
    partial class frmExercicio4
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
            this.btnNumericos = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.btnAlfabetico = new System.Windows.Forms.Button();
            this.rchTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnNumericos
            // 
            this.btnNumericos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumericos.Location = new System.Drawing.Point(73, 261);
            this.btnNumericos.Name = "btnNumericos";
            this.btnNumericos.Size = new System.Drawing.Size(165, 68);
            this.btnNumericos.TabIndex = 0;
            this.btnNumericos.Text = "Numéricos";
            this.btnNumericos.UseVisualStyleBackColor = true;
            this.btnNumericos.Click += new System.EventHandler(this.btnNumericos_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBranco.Location = new System.Drawing.Point(317, 261);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(165, 68);
            this.btnBranco.TabIndex = 1;
            this.btnBranco.Text = "Posição Primeiro  Espaço em branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // btnAlfabetico
            // 
            this.btnAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlfabetico.Location = new System.Drawing.Point(534, 261);
            this.btnAlfabetico.Name = "btnAlfabetico";
            this.btnAlfabetico.Size = new System.Drawing.Size(165, 68);
            this.btnAlfabetico.TabIndex = 2;
            this.btnAlfabetico.Text = "Alfabético";
            this.btnAlfabetico.UseVisualStyleBackColor = true;
            this.btnAlfabetico.Click += new System.EventHandler(this.btnAlfabetico_Click);
            // 
            // rchTxt
            // 
            this.rchTxt.Location = new System.Drawing.Point(169, 43);
            this.rchTxt.MaxLength = 100;
            this.rchTxt.Name = "rchTxt";
            this.rchTxt.Size = new System.Drawing.Size(461, 180);
            this.rchTxt.TabIndex = 4;
            this.rchTxt.Text = "";
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rchTxt);
            this.Controls.Add(this.btnAlfabetico);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnNumericos);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.Load += new System.EventHandler(this.frmExercicio4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNumericos;
        private System.Windows.Forms.Button btnBranco;
        private System.Windows.Forms.Button btnAlfabetico;
        private System.Windows.Forms.RichTextBox rchTxt;
    }
}