﻿using System;
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
    public partial class Exercicio2 : Form
    {
        public Exercicio2()
        {
            InitializeComponent();
        }

        private void Exercicio2_Load(object sender, EventArgs e)
        {

        }

        private void txtTexto_KeyUp(object sender, KeyEventArgs e)
        {
            lblCaixaAlta.Text = txtTexto.Text.ToUpper();
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCaixaAlta_Click(object sender, EventArgs e)
        {

        }
    }
}
