﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace cantinaPainel
{
    public partial class formsAdm : Form
    {
        public formsAdm()
        {
            InitializeComponent();
        }

        private void txtBoxAddProdito_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtBoxAddProduto != null) 
            {
                listBoxTest.Items.Add(txtBoxAddProduto.Text);
            }
        }
    }
}
