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

        public string viagem;
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

            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                bool pedidoTemChapa = false;


                if (pedido.IsViagem == false)
                {
                    viagem = "Não";
                }
                else if (pedido.IsViagem == true)
                {
                    viagem = "Sim";
                }

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
                    
                 
                        var item = new ListViewItem(pedido.Nome_Cliente);               // Coluna 1: Cliente
                    item.SubItems.Add(pedido.ToString());                           // Coluna 2: Pedido
                    //item.SubItems.Add(pedido.IsViagem.ToString());                  // Coluna 3: Viagem
                    item.SubItems.Add(viagem);                  // Coluna 3: Viagem

                    listViewPedidos.Items.Add(item);
                }

            }
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {

            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                if (listViewPedidos.SelectedItems.Count > 0)
                {

                    ListViewItem selecionado = listViewPedidos.SelectedItems[0];

                    listViewHistorico.Items.Insert(0, (ListViewItem)selecionado.Clone());

                    listViewPedidos.Items.Remove(selecionado);

                    pedido.StatusPedido = Status.ENTREGUE;

                    break;
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
        }
    }
}
