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

        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(
            IntPtr hWnd,
            int msg,
            int wParam,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam
        );
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
                string viagem = pedido.IsViagem ? "Sim" : "Não";

                if (pedido.StatusPedido == Status.PRONTO)
                {
                    listBoxPedidos.Items.Add(pedido);
                }

            }

            if (loginAdm.adm == false)
            {
                comboBoxMenu.Visible = false;
            }
            if (loginAdm.adm == true)
            {
                comboBoxMenu.Visible = true;
            }
            numero = listBoxPedidos.Items.Count;
            lblContadorPedidos.Text = numero.ToString();
            lblContadorPedidos.Text.Equals(numero);
            SendMessage(this.comboBoxMenu.Handle, CB_SETCUEBANNER, 0, "Menu");
            comboBoxMenu.Items.Add("Adm");
            comboBoxMenu.Items.Add("Pedido");
            comboBoxMenu.Items.Add("Cozinha");
            comboBoxMenu.Items.Add("Chamada");
            comboBoxMenu.Items.Add("Estoque");
            comboBoxMenu.Items.Add("Login");
        }


        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (listBoxHistorico.Items.Count >= 5)
            {
                listBoxHistorico.Items.RemoveAt(4);
                PersistenciaPedido.saveToFile();
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
                PersistenciaPedido.saveToFile();

                numero = numero - 1;
                lblContadorPedidos.Text = numero.ToString();
            }
        }





        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            formsLogin formsLogin = new formsLogin();
            formsLogin.Show();
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

        private void lblContadorPedidos_Click(object sender, EventArgs e)
        {

        }

        private void panelMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listBoxPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMenu.SelectedIndex == 0)
            {
                formsAdm formsAdm = new formsAdm();
                formsAdm.Show();
                this.Close();
                comboBoxMenu.SelectedIndex = -1;
            }
            else if (comboBoxMenu.SelectedIndex == 1)
            {
                formsPedido formsPedido = new formsPedido();
                formsPedido.Show();
                this.Close();
                comboBoxMenu.SelectedIndex = -1;
            }
            else if (comboBoxMenu.SelectedIndex == 2)
            {
                formsCozinha formsCozinha = new formsCozinha();
                formsCozinha.Show();
                this.Close();
                comboBoxMenu.SelectedIndex = -1;
            }
            else if (comboBoxMenu.SelectedIndex == 3)
            {
                formsTela formsTela = new formsTela();
                formsTela.Show();
                this.Close();
                comboBoxMenu.SelectedIndex = -1;
            }
            else if (comboBoxMenu.SelectedIndex == 4)
            {
                formsEstoque formsEstoque = new formsEstoque();
                formsEstoque.Show();
                this.Close();
                comboBoxMenu.SelectedIndex = -1;
            }
            else if (comboBoxMenu.SelectedIndex == 5)
            {
                formsLogin formsLogin = new formsLogin();
                formsLogin.Show();
                this.Close();
                comboBoxMenu.SelectedIndex = -1;
            }

        }

        private void panelButtons_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
