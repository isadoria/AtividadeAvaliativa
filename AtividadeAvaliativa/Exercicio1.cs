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
    public partial class Exercicio1 : Form
    {
        public Exercicio1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            if (cmbInicio.SelectedIndex < cmbFim.SelectedIndex)
            {
                for (int i = cmbInicio.SelectedIndex + 1; i <= cmbFim.SelectedIndex + 1; i++)
                {
                    lstNumeros.Items.Add(i.ToString());
                }
            }
            else
            {
                if (cmbInicio.SelectedIndex > cmbFim.SelectedIndex)
                {
                    for (int i = cmbInicio.SelectedIndex + 1; i >= cmbFim.SelectedIndex + 1; i--)
                    {
                        lstNumeros.Items.Add(i.ToString());
                    }

                }
            }
        }

        private void cmbFim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstNumeros.Items.Clear();

            if (cmbInicio.SelectedIndex < cmbFim.SelectedIndex)
            {
                for (int i = cmbInicio.SelectedIndex + 1; i <= cmbFim.SelectedIndex + 1; i++)
                {
                    lstNumeros.Items.Add(i.ToString());
                }
            }
            else
            {
                if (cmbInicio.SelectedIndex > cmbFim.SelectedIndex)
                {
                    for (int i = cmbInicio.SelectedIndex + 1; i >= cmbFim.SelectedIndex + 1; i--)
                    {
                        lstNumeros.Items.Add(i.ToString());
                    }

                }
            }

        }
    }
}
