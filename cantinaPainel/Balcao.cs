using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        private void CarregarHistorico()
        {
            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.StatusPedido.Equals(Status.ENTREGUE))
                {
                    string viagem = pedido.IsViagem ? "Sim" : "Não";
                    listBoxHistorico.Items.Insert(0,pedido);
                }
            }
        }


        private void formsBalcao_Load(object sender, EventArgs e)
        {
            listBoxHistorico.Enabled = false;
            Produto produtoSelecionado = (Produto)listBoxPedidos.SelectedItem;
            listBoxPedidos.Items.Clear();
            listBoxHistorico.Items.Clear();
            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                bool pedidoTemChapa = false;
                string viagem = pedido.IsViagem ? "Sim" : "Não";

                foreach (var produto in pedido.extrato)
                {
                    if (produto.IsChapa)
                    {
                        pedidoTemChapa = true;
                        break;
                    }
                }
                if (!pedidoTemChapa)
                {
                    pedido.StatusPedido.Equals(Status.PRONTO);

                    if (!pedido.StatusPedido.Equals(Status.ENTREGUE))
                    {
                        //listBoxPedidos.Items.Add($"Código: {pedido.CodigoPedido} Pedido: {pedido.ToString()}");
                        listBoxPedidos.Items.Add(pedido);
                    }
                }

            }
            CarregarHistorico();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listBoxHistorico.Items.Count >= 5)
            {
                listBoxHistorico.Items.RemoveAt(4);

            }

            var pedidoSelecionado = listBoxPedidos.SelectedItem as Pedido;
            //var pedidoSelecionado = (Pedido)listBoxPedidos.SelectedItem;
            if (pedidoSelecionado != null)
            {
                //MessageBox.Show($"Pedido selecionado: {pedidoSelecionado.CodigoPedido}");
                pedidoSelecionado.StatusPedido = Status.ENTREGUE;
            }

            if (pedidoSelecionado != null)
            {       
                
                listBoxHistorico.Items.Insert(0, pedidoSelecionado);
                listBoxPedidos.Items.Remove(pedidoSelecionado);
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

        private void listViewHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxHistorico.SelectedItems.Clear();
            if (listBoxHistorico.Items.Count > 5)
            {
                listBoxHistorico.Items.RemoveAt(4);
            }
        }

        private void listBoxHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
