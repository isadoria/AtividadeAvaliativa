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
    public partial class Exercicio4 : Form
    {
        public Exercicio4()
        {
            InitializeComponent();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkBacon_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAchocolatado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkIogurte_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkCoxa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total=0;

            if(chkLinguica.Checked) { total += 17; }
            if(chkPernil.Checked) { total+=12.90; }
            if(chkCoxa.Checked) { total += 6.88; }
            if(chkBacon.Checked) { total += 23.98; }
            if(chkNuggets.Checked) { total += 23.98; }
            if(chkIogurte.Checked) { total += 3.49; }
            if(chkDanone.Checked) { total += 3.19; }
            if(chkLeite.Checked) { total += 13.98; }
            if(chkYakut.Checked) { total += 5.49; }
            if(chkAchocolatado.Checked) { total += 9.98; }
            
            lblTotal.Text = total.ToString("C");
        }
    }
}
