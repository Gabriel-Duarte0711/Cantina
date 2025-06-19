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

            formsLogin formsLogin = new formsLogin();
            this.Close();
            formsLogin.Show();
        }


        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(
            IntPtr hWnd,
            int msg,
            int wParam,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam
                );
        private void formsCozinha_Load(object sender, EventArgs e)
        {
            try
            {
                PersistenciaPedido.LoadListFromFile();
                listBoxChapa.Items.Clear(); // Limpa antes de adicionar

                foreach (var pedido in PersistenciaPedido.pedidos)
                {
                    if (pedido.StatusPedido == Status.PREPARANDO)
                    {
                        listBoxChapa.Items.Add(pedido);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao carregar dados");
            }

            if (loginAdm.adm == false)
            {
                comboBoxMenu.Visible = false;
            }
            if (loginAdm.adm == true)
            {
                comboBoxMenu.Visible = true;
            }

            SendMessage(this.comboBoxMenu.Handle, CB_SETCUEBANNER, 0, "Menu");
            comboBoxMenu.Items.Add("Adm");
            comboBoxMenu.Items.Add("Pedido");
            comboBoxMenu.Items.Add("Balcão");
            comboBoxMenu.Items.Add("Chamada");
            comboBoxMenu.Items.Add("Estoque");
            comboBoxMenu.Items.Add("Login");
        }

        private void btnFeito_Click(object sender, EventArgs e)
        {
            try
            {
                var pedidoSelecionado = listBoxChapa.SelectedItem as Pedido;
                if (pedidoSelecionado != null)
                {
                    pedidoSelecionado.StatusPedido = Status.PRONTO;
                    listBoxChapa.Items.Remove(pedidoSelecionado);
                    PersistenciaPedido.saveToFile();
                    listBoxChapa.SelectedIndex = -1;
                }
            }
            catch
            {
                MessageBox.Show("Erro ao processar pedido");
            }
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
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
                formsBalcao formsBalcao = new formsBalcao();
                formsBalcao.Show();
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
    }
}