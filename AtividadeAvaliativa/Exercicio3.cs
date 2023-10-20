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
    public partial class Exercicio3 : Form
    {
        public Exercicio3()
        {
            InitializeComponent();
        }

        private void btnMudaCorDeFundo_Click(object sender, EventArgs e)
        {
            if(rdbCorAzul.Checked)
            { this.BackColor = Color.Blue; }

            if (rdbCorVermelho.Checked)
            { this.BackColor = Color.Red; }

            if (rdbCorAmarelo.Checked)
            { this.BackColor = Color.Yellow; }
        }

        private void rdbCorVerde_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
