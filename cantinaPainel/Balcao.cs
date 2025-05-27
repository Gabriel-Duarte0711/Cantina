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

                    var item = new ListViewItem(pedido.Nome_Cliente);
                    item.SubItems.Add(pedido.ToString());
                    item.SubItems.Add(viagem);
                    item.Tag = pedido;

                    listViewHistorico.Items.Insert(0, item);
                }
            }
        }


        private void formsBalcao_Load(object sender, EventArgs e)
        {

            listViewPedidos.View = View.Details;
            listViewHistorico.View = View.Details;

            listViewPedidos.FullRowSelect = true;
            listViewHistorico.FullRowSelect = true;

            listViewPedidos.GridLines = true;
            listViewHistorico.GridLines = true;

            listViewPedidos.Columns.Add("Cliente", 125);
            listViewHistorico.Columns.Add("Cliente", 125);

            listViewPedidos.Columns.Add("Pedido", 550, HorizontalAlignment.Center);
            listViewHistorico.Columns.Add("Pedido", 550, HorizontalAlignment.Center);

            listViewPedidos.Columns.Add("Viagem", 100);
            listViewHistorico.Columns.Add("Viagem", 100);



            listViewHistorico.FullRowSelect = true;
            listViewHistorico.MultiSelect = false;
            listViewHistorico.HideSelection = true;

            listViewPedidos.Items.Clear();
            listViewHistorico.Items.Clear();
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


                        var item = new ListViewItem(pedido.Nome_Cliente);               // Coluna 1: Cliente
                        item.SubItems.Add(pedido.ToString());                           // Coluna 2: Pedido
                        item.SubItems.Add(viagem);                                      // Coluna 3: Viagem

                        item.Tag = pedido;

                        listViewPedidos.Items.Add(item);
                    }
                }
                
            }
            CarregarHistorico();
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {

            if (listViewHistorico.Items.Count > 5)
            {
                listViewHistorico.Items.RemoveAt(6);

            }


            if (listViewPedidos.SelectedItems.Count > 0)
            {
              
                ListViewItem selecionado = listViewPedidos.SelectedItems[0];

                var pedidoReal = selecionado.Tag as Pedido;
                if(pedidoReal != null)
                {

                    pedidoReal.StatusPedido = Status.ENTREGUE;

                    var itemHistorico = (ListViewItem)selecionado.Clone();

                    itemHistorico.Tag = pedidoReal;
                    
                    listViewHistorico.Items.Insert(0, itemHistorico);

                    listViewPedidos.Items.Remove(selecionado);
                }
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
            listViewHistorico.SelectedItems.Clear();
           if(listViewHistorico.Items.Count > 5)
            {
                listViewHistorico.Items.RemoveAt(4);
            }
        }
    }
}
