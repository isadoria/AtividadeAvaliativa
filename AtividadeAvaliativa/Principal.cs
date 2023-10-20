using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAvaliativa
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void atividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exercício01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio1 ex1 = new Exercicio1();
            ex1.ShowDialog();
        }

        private void exercício02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio2 ex2 = new Exercicio2();
            ex2.ShowDialog();
        }

        private void exercício03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio3 ex3 = new Exercicio3();
            ex3.ShowDialog();
        }

        private void exercício04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercicio4 ex4 = new Exercicio4();
            ex4.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
