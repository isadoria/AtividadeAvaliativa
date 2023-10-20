namespace AtividadeAvaliativa
{
    partial class Exercicio1
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
            this.cmbInicio = new System.Windows.Forms.ComboBox();
            this.cmbFim = new System.Windows.Forms.ComboBox();
            this.lstNumeros = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbInicio
            // 
            this.cmbInicio.FormattingEnabled = true;
            this.cmbInicio.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbInicio.Location = new System.Drawing.Point(115, 23);
            this.cmbInicio.Name = "cmbInicio";
            this.cmbInicio.Size = new System.Drawing.Size(121, 21);
            this.cmbInicio.TabIndex = 0;
            this.cmbInicio.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbFim
            // 
            this.cmbFim.FormattingEnabled = true;
            this.cmbFim.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbFim.Location = new System.Drawing.Point(319, 23);
            this.cmbFim.Name = "cmbFim";
            this.cmbFim.Size = new System.Drawing.Size(121, 21);
            this.cmbFim.TabIndex = 1;
            this.cmbFim.SelectedIndexChanged += new System.EventHandler(this.cmbFim_SelectedIndexChanged);
            // 
            // lstNumeros
            // 
            this.lstNumeros.FormattingEnabled = true;
            this.lstNumeros.Location = new System.Drawing.Point(115, 61);
            this.lstNumeros.Name = "lstNumeros";
            this.lstNumeros.Size = new System.Drawing.Size(325, 238);
            this.lstNumeros.TabIndex = 2;
            // 
            // Exercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstNumeros);
            this.Controls.Add(this.cmbFim);
            this.Controls.Add(this.cmbInicio);
            this.Name = "Exercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInicio;
        private System.Windows.Forms.ComboBox cmbFim;
        private System.Windows.Forms.ListBox lstNumeros;
    }
}