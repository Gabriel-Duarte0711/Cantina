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
        int numero = 0;
        List<Pedido> entregue = new List<Pedido>();
        private void CarregarHistorico()
        {
            entregue.Clear();
            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                if (pedido.StatusPedido == Status.ENTREGUE)
                {
                    entregue.Insert(0, pedido);

                    if (entregue.Count > 5)
                    {
                        entregue.RemoveAt(entregue.Count - 1);
                    }
                }
            }
            listBoxHistorico.Items.Clear();

            foreach (var pedido in entregue)
            {
                string descricao = $"{pedido}";
                listBoxHistorico.Items.Add(descricao);
            }
        }


        private void formsBalcao_Load(object sender, EventArgs e)
        {
            PersistenciaPedido.LoadListFromFile();

            listBoxHistorico.Enabled = false;
            Produto produtoSelecionado = (Produto)listBoxPedidos.SelectedItem;
            listBoxPedidos.Items.Clear();
            listBoxHistorico.Items.Clear();
            CarregarHistorico();
            foreach (var pedido in PersistenciaPedido.pedidos)
            {
                MessageBox.Show(pedido.CodigoPedido.ToString());
                string viagem = pedido.IsViagem ? "Sim" : "Não";

                if (pedido.StatusPedido == Status.PRONTO)
                {
                    listBoxPedidos.Items.Add(pedido);
                }

            }
          
            numero = listBoxPedidos.Items.Count;
            lblContadorPedidos.Text = numero.ToString();
            lblContadorPedidos.Text.Equals(numero);

        }


        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listBoxHistorico.Items.Count >= 5)
            {
                listBoxHistorico.Items.RemoveAt(4);
            }

            var pedidoSelecionado = listBoxPedidos.SelectedItem as Pedido;

            if (pedidoSelecionado != null)
            {
                if (pedidoSelecionado.IsViagem == true)
                {
                    MessageBox.Show("pedido para viagem");
                }
                pedidoSelecionado.StatusPedido = Status.ENTREGUE;
                entregue.Add(pedidoSelecionado);
                listBoxHistorico.Items.Insert(0, pedidoSelecionado);
                listBoxPedidos.Items.Remove(pedidoSelecionado);

                numero = numero - 1;
                lblContadorPedidos.Text = numero.ToString();
            }
        }





        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            formsTela formsTela = new formsTela();
            formsTela.Show();
            this.Hide();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblContadorPedidos_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
