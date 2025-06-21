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
    public partial class formsTela : Form
    {

        public formsTela()
        {
            InitializeComponent();
        }
        private System.Windows.Forms.Timer temporizador;


        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(
            IntPtr hWnd,
            int msg,
            int wParam,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam
                );

        private void formsTela_Load(object sender, EventArgs e)
        {
            foreach (var item in PersistenciaPedido.pedidos)
            {
                if (item.StatusPedido == Status.PRONTO || item.StatusPedido == Status.PREPARANDO)
                {
                    listBoxNomePreparando.Items.Insert(0, item.Nome_Cliente);
                }
                else if (item.StatusPedido == Status.ENTREGUE)
                {
                    ChamadaGigante chamadaGigante = new ChamadaGigante();

                    chamadaGigante.chamada(item.Nome_Cliente);
                    chamadaGigante.ShowDialog();
                    listBoxNomePronto.Items.Insert(0, item.Nome_Cliente);
                }
            }
            temporizador = new System.Windows.Forms.Timer();
            temporizador.Interval = 30000;
            temporizador.Tick += Temporizador_Tick;
            temporizador.Start();

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
            comboBoxMenu.Items.Add("cozinha");
            comboBoxMenu.Items.Add("Estoque");
            comboBoxMenu.Items.Add("Login");
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (listBoxNomePronto.Items.Count > 0)
            {
                var ultimoItem = listBoxNomePronto.Items[listBoxNomePronto.Items.Count - 1];
                foreach (var item in PersistenciaPedido.pedidos)
                {
                    ultimoItem = (item.StatusPedido = Status.FINALIZADO);
                }
                listBoxNomePronto.Items.RemoveAt(listBoxNomePronto.Items.Count - 1);
            }
        }
        private void listBoxNomePronto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Globais.VoltarLogin(this);
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
                formsCozinha formsCozinha = new formsCozinha();
                formsCozinha.Show();
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
