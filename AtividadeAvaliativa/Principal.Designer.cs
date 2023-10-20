namespace AtividadeAvaliativa
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.atividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício01ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício02ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício03ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício04ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atividadesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atividadesToolStripMenuItem
            // 
            this.atividadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício01ToolStripMenuItem,
            this.exercício02ToolStripMenuItem,
            this.exercício03ToolStripMenuItem,
            this.exercício04ToolStripMenuItem});
            this.atividadesToolStripMenuItem.Font = new System.Drawing.Font("Segoe Fluent Icons", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atividadesToolStripMenuItem.Name = "atividadesToolStripMenuItem";
            this.atividadesToolStripMenuItem.Size = new System.Drawing.Size(88, 25);
            this.atividadesToolStripMenuItem.Text = "Atividades";
            this.atividadesToolStripMenuItem.Click += new System.EventHandler(this.atividadesToolStripMenuItem_Click);
            // 
            // exercício01ToolStripMenuItem
            // 
            this.exercício01ToolStripMenuItem.Name = "exercício01ToolStripMenuItem";
            this.exercício01ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exercício01ToolStripMenuItem.Text = "Exercício 01";
            this.exercício01ToolStripMenuItem.Click += new System.EventHandler(this.exercício01ToolStripMenuItem_Click);
            // 
            // exercício02ToolStripMenuItem
            // 
            this.exercício02ToolStripMenuItem.Name = "exercício02ToolStripMenuItem";
            this.exercício02ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exercício02ToolStripMenuItem.Text = "Exercício 02";
            this.exercício02ToolStripMenuItem.Click += new System.EventHandler(this.exercício02ToolStripMenuItem_Click);
            // 
            // exercício03ToolStripMenuItem
            // 
            this.exercício03ToolStripMenuItem.Name = "exercício03ToolStripMenuItem";
            this.exercício03ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exercício03ToolStripMenuItem.Text = "Exercício 03";
            this.exercício03ToolStripMenuItem.Click += new System.EventHandler(this.exercício03ToolStripMenuItem_Click);
            // 
            // exercício04ToolStripMenuItem
            // 
            this.exercício04ToolStripMenuItem.Name = "exercício04ToolStripMenuItem";
            this.exercício04ToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.exercício04ToolStripMenuItem.Text = "Exercício 04";
            this.exercício04ToolStripMenuItem.Click += new System.EventHandler(this.exercício04ToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Isadora Costa Silveira Dória";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício01ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício02ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício03ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício04ToolStripMenuItem;
    }
}

