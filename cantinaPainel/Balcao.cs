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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.FlowDirection = FlowDirection.LeftToRight;
            flow.WrapContents = true;
            flow.AutoScroll = true;
            flow.Padding = new Padding(10);

            // Cria 3 ListBox e adiciona itens
            for (int i = 1; i <= 5; i++)
            {
                ListBox listBox = new ListBox();
                listBox.Width = 150;
                listBox.Height = 100;

                listBox.Items.Add($"{Globais.extrato}{i}");

                flow.Controls.Add(listBox);
            }

            this.Controls.Add(flow);
        }
    }
}
