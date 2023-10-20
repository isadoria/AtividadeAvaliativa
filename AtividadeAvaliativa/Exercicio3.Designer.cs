namespace AtividadeAvaliativa
{
    partial class Exercicio3
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
            this.rdbCorAzul = new System.Windows.Forms.RadioButton();
            this.rdbCorVermelho = new System.Windows.Forms.RadioButton();
            this.rdbCorAmarelo = new System.Windows.Forms.RadioButton();
            this.btnMudaCorDeFundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione uma opção para trocar a cor de fundo:";
            // 
            // rdbCorAzul
            // 
            this.rdbCorAzul.AutoSize = true;
            this.rdbCorAzul.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorAzul.Location = new System.Drawing.Point(218, 78);
            this.rdbCorAzul.Name = "rdbCorAzul";
            this.rdbCorAzul.Size = new System.Drawing.Size(54, 23);
            this.rdbCorAzul.TabIndex = 1;
            this.rdbCorAzul.TabStop = true;
            this.rdbCorAzul.Text = "Azul";
            this.rdbCorAzul.UseVisualStyleBackColor = true;
            this.rdbCorAzul.CheckedChanged += new System.EventHandler(this.rdbCorVerde_CheckedChanged);
            // 
            // rdbCorVermelho
            // 
            this.rdbCorVermelho.AutoSize = true;
            this.rdbCorVermelho.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorVermelho.Location = new System.Drawing.Point(359, 78);
            this.rdbCorVermelho.Name = "rdbCorVermelho";
            this.rdbCorVermelho.Size = new System.Drawing.Size(87, 23);
            this.rdbCorVermelho.TabIndex = 2;
            this.rdbCorVermelho.TabStop = true;
            this.rdbCorVermelho.Text = "Vermelho";
            this.rdbCorVermelho.UseVisualStyleBackColor = true;
            // 
            // rdbCorAmarelo
            // 
            this.rdbCorAmarelo.AutoSize = true;
            this.rdbCorAmarelo.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCorAmarelo.Location = new System.Drawing.Point(535, 78);
            this.rdbCorAmarelo.Name = "rdbCorAmarelo";
            this.rdbCorAmarelo.Size = new System.Drawing.Size(79, 23);
            this.rdbCorAmarelo.TabIndex = 3;
            this.rdbCorAmarelo.TabStop = true;
            this.rdbCorAmarelo.Text = "Amarelo";
            this.rdbCorAmarelo.UseVisualStyleBackColor = true;
            // 
            // btnMudaCorDeFundo
            // 
            this.btnMudaCorDeFundo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnMudaCorDeFundo.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMudaCorDeFundo.Location = new System.Drawing.Point(282, 140);
            this.btnMudaCorDeFundo.Name = "btnMudaCorDeFundo";
            this.btnMudaCorDeFundo.Size = new System.Drawing.Size(244, 64);
            this.btnMudaCorDeFundo.TabIndex = 4;
            this.btnMudaCorDeFundo.Text = "Trocar a cor de fundo";
            this.btnMudaCorDeFundo.UseVisualStyleBackColor = false;
            this.btnMudaCorDeFundo.Click += new System.EventHandler(this.btnMudaCorDeFundo_Click);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMudaCorDeFundo);
            this.Controls.Add(this.rdbCorAmarelo);
            this.Controls.Add(this.rdbCorVermelho);
            this.Controls.Add(this.rdbCorAzul);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbCorAzul;
        private System.Windows.Forms.RadioButton rdbCorVermelho;
        private System.Windows.Forms.RadioButton rdbCorAmarelo;
        private System.Windows.Forms.Button btnMudaCorDeFundo;
    }
}