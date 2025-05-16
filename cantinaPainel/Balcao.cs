using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cantinaPainel
{
    public partial class formsBalcao : Form
    {
        public formsBalcao()
        {
            InitializeComponent();
        }
        private void formsBalcao_Load(object sender, EventArgs e)
        {


            string Extrato = string.Join("\n", Globais.extrato);
            string Nomes = string.Join("\n", Globais.nomes);


            foreach (var nomes in Globais.nomes)
            {
                listBox1.Items.Add(nomes);
            }


            foreach (var extrato in Globais.extrato)
            {
                listBox1.Items.Add(extrato);
            }

        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formsPedido formpedido = new formsPedido();
            formpedido.Show();
        }
    }
}
