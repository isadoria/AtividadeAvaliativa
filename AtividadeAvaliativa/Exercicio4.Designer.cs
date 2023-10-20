namespace AtividadeAvaliativa
{
    partial class Exercicio4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkCoxa = new System.Windows.Forms.CheckBox();
            this.chkPernil = new System.Windows.Forms.CheckBox();
            this.chkLinguica = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNuggets = new System.Windows.Forms.CheckBox();
            this.chkIogurte = new System.Windows.Forms.CheckBox();
            this.chkDanone = new System.Windows.Forms.CheckBox();
            this.chkLeite = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.chkYakut = new System.Windows.Forms.CheckBox();
            this.chkAchocolatado = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione os produtos desejados:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLinguica);
            this.groupBox1.Controls.Add(this.chkNuggets);
            this.groupBox1.Controls.Add(this.chkBacon);
            this.groupBox1.Controls.Add(this.chkCoxa);
            this.groupBox1.Controls.Add(this.chkPernil);
            this.groupBox1.Location = new System.Drawing.Point(117, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBacon.Location = new System.Drawing.Point(44, 97);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(134, 23);
            this.chkBacon.TabIndex = 3;
            this.chkBacon.Text = "Bacon R$ 23,98";
            this.chkBacon.UseVisualStyleBackColor = true;
            this.chkBacon.CheckedChanged += new System.EventHandler(this.chkBacon_CheckedChanged);
            // 
            // chkCoxa
            // 
            this.chkCoxa.AutoSize = true;
            this.chkCoxa.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCoxa.Location = new System.Drawing.Point(44, 74);
            this.chkCoxa.Name = "chkCoxa";
            this.chkCoxa.Size = new System.Drawing.Size(190, 23);
            this.chkCoxa.TabIndex = 2;
            this.chkCoxa.Text = "Coxa de Frango R$ 6,88";
            this.chkCoxa.UseVisualStyleBackColor = true;
            this.chkCoxa.CheckedChanged += new System.EventHandler(this.chkCoxa_CheckedChanged);
            // 
            // chkPernil
            // 
            this.chkPernil.AutoSize = true;
            this.chkPernil.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPernil.Location = new System.Drawing.Point(44, 51);
            this.chkPernil.Name = "chkPernil";
            this.chkPernil.Size = new System.Drawing.Size(172, 23);
            this.chkPernil.TabIndex = 1;
            this.chkPernil.Text = "Pernil Suíno R$ 12,90";
            this.chkPernil.UseVisualStyleBackColor = true;
            // 
            // chkLinguica
            // 
            this.chkLinguica.AutoSize = true;
            this.chkLinguica.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLinguica.Location = new System.Drawing.Point(44, 28);
            this.chkLinguica.Name = "chkLinguica";
            this.chkLinguica.Size = new System.Drawing.Size(147, 23);
            this.chkLinguica.TabIndex = 0;
            this.chkLinguica.Text = "Linguiça R$ 17,00";
            this.chkLinguica.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAchocolatado);
            this.groupBox2.Controls.Add(this.chkYakut);
            this.groupBox2.Controls.Add(this.chkIogurte);
            this.groupBox2.Controls.Add(this.chkDanone);
            this.groupBox2.Controls.Add(this.chkLeite);
            this.groupBox2.Location = new System.Drawing.Point(426, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 201);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // chkNuggets
            // 
            this.chkNuggets.AutoSize = true;
            this.chkNuggets.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNuggets.Location = new System.Drawing.Point(44, 120);
            this.chkNuggets.Name = "chkNuggets";
            this.chkNuggets.Size = new System.Drawing.Size(147, 23);
            this.chkNuggets.TabIndex = 4;
            this.chkNuggets.Text = "Nuggets R$ 23,98";
            this.chkNuggets.UseVisualStyleBackColor = true;
            // 
            // chkIogurte
            // 
            this.chkIogurte.AutoSize = true;
            this.chkIogurte.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIogurte.Location = new System.Drawing.Point(55, 28);
            this.chkIogurte.Name = "chkIogurte";
            this.chkIogurte.Size = new System.Drawing.Size(130, 23);
            this.chkIogurte.TabIndex = 5;
            this.chkIogurte.Text = "Iogurte R$ 3,49";
            this.chkIogurte.UseVisualStyleBackColor = true;
            this.chkIogurte.CheckedChanged += new System.EventHandler(this.chkIogurte_CheckedChanged);
            // 
            // chkDanone
            // 
            this.chkDanone.AutoSize = true;
            this.chkDanone.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDanone.Location = new System.Drawing.Point(55, 51);
            this.chkDanone.Name = "chkDanone";
            this.chkDanone.Size = new System.Drawing.Size(155, 23);
            this.chkDanone.TabIndex = 6;
            this.chkDanone.Text = "Danoninho R$ 3,19";
            this.chkDanone.UseVisualStyleBackColor = true;
            this.chkDanone.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chkLeite
            // 
            this.chkLeite.AutoSize = true;
            this.chkLeite.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLeite.Location = new System.Drawing.Point(54, 74);
            this.chkLeite.Name = "chkLeite";
            this.chkLeite.Size = new System.Drawing.Size(173, 23);
            this.chkLeite.TabIndex = 7;
            this.chkLeite.Text = "Leite em Pó R$ 13,98";
            this.chkLeite.UseVisualStyleBackColor = true;
            this.chkLeite.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(197, 278);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 44);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe Fluent Icons", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(475, 284);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 27);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "R$ 0,00";
            // 
            // chkYakut
            // 
            this.chkYakut.AutoSize = true;
            this.chkYakut.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYakut.Location = new System.Drawing.Point(54, 97);
            this.chkYakut.Name = "chkYakut";
            this.chkYakut.Size = new System.Drawing.Size(122, 23);
            this.chkYakut.TabIndex = 8;
            this.chkYakut.Text = "Yakut R$ 5,49";
            this.chkYakut.UseVisualStyleBackColor = true;
            // 
            // chkAchocolatado
            // 
            this.chkAchocolatado.AutoSize = true;
            this.chkAchocolatado.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAchocolatado.Location = new System.Drawing.Point(54, 120);
            this.chkAchocolatado.Name = "chkAchocolatado";
            this.chkAchocolatado.Size = new System.Drawing.Size(172, 23);
            this.chkAchocolatado.TabIndex = 9;
            this.chkAchocolatado.Text = "Achocolatado R$ 9,98";
            this.chkAchocolatado.UseVisualStyleBackColor = true;
            this.chkAchocolatado.CheckedChanged += new System.EventHandler(this.chkAchocolatado_CheckedChanged);
            // 
            // Exercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio4";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkDanone;
        private System.Windows.Forms.CheckBox chkIogurte;
        private System.Windows.Forms.CheckBox chkNuggets;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkCoxa;
        private System.Windows.Forms.CheckBox chkPernil;
        private System.Windows.Forms.CheckBox chkLinguica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox chkLeite;
        private System.Windows.Forms.CheckBox chkAchocolatado;
        private System.Windows.Forms.CheckBox chkYakut;
    }
}