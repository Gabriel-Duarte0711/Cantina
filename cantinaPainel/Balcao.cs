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
using static System.Windows.Forms.LinkLabel;
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
            listBoxHistorico.Enabled = false;
            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                bool pedidoTemChapa = false;

                foreach (var produto in pedido.extrato)
                {
                    if (produto.IsChapa)
                    {
                        pedidoTemChapa = true;
                        return;
                    }
                }

                if (!pedidoTemChapa)
                {
                    
                    listBoxPedidos.Items.Add($"\n{pedido.ToString()}");

                }

            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedIndex != -1)
            {
                listBoxHistorico.Items.Insert(0,listBoxPedidos.SelectedItem);
                listBoxPedidos.Items.RemoveAt(listBoxPedidos.SelectedIndex);
                listBoxPedidos.SelectedIndex = -1;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formsPedido formpedido = new formsPedido();
            formpedido.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
