using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantinaPainel
{
    public partial class formsCozinha : Form
    {
        public formsCozinha()
        {
            InitializeComponent();
        }

        private void listBoxChapa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formsPedido formpedido = new formsPedido();
            formpedido.Show();
        }

        private void formsCozinha_Load(object sender, EventArgs e)
        {
            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                bool pedidoTemChapa = false;

                foreach (var produto in pedido.extrato)
                {
                    if (produto.IsChapa)
                    {
                        pedidoTemChapa = true;
                        break;
                    }
                }

                if (pedidoTemChapa)
                {
                    pedido.StatusPedido = Status.PREPARANDO;
                    listBoxChapa.Items.Add($"\n{pedido.SomenteChapas()}");

                }

            }
        }

        private void btnFeito_Click(object sender, EventArgs e)
        { 
        }
    }    
}

