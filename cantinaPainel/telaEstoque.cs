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
    public partial class formsEstoque : Form
    {

        public formsEstoque()
        {
            InitializeComponent();
        }
        //private void AtualizarLista()
        //{
        //    int selectedIndex = listBoxEstoque.SelectedIndex;

        //    listBoxEstoque.Items.Clear();

        //    foreach (Estoque estoque in PersistenciaEstoque.estoqueGeral)
        //    {
        //        if (estoque.Produto.IsAtivo)
        //        {
        //            listBoxEstoque.Items.Add(estoque);
        //        }
        //    }

        //    // Restaurar seleção se ainda válida
        //    if (selectedIndex >= 0 && selectedIndex < listBoxEstoque.Items.Count)
        //    {
        //        listBoxEstoque.SelectedIndex = selectedIndex;
        //    }
        //}
        private void AtualizarLista()
        {
            listBoxEstoque.SelectedIndexChanged -= listBoxEstoque_SelectedIndexChanged;

            int selectedIndex = listBoxEstoque.SelectedIndex;
            listBoxEstoque.DataSource = null;
            listBoxEstoque.DataSource = PersistenciaEstoque.estoqueGeral;

            listBoxEstoque.SelectedIndex = -1;

            listBoxEstoque.SelectedIndexChanged += listBoxEstoque_SelectedIndexChanged;

            if (selectedIndex >= 0 && selectedIndex < listBoxEstoque.Items.Count)
            {
                listBoxEstoque.SelectedIndex = selectedIndex;
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
        private void telaEstoque_Load(object sender, EventArgs e)
        {
            PersistenciaEstoque.LoadListFromFile();

            if (PersistenciaEstoque.estoqueGeral.Count == 0)
            {
                PersistenciaEstoque.InicializarEstoque();
            }

            AtualizarLista();

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
            comboBoxMenu.Items.Add("Chamada");
            comboBoxMenu.Items.Add("Login");
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int quantidadeAdicionar = (int)numericUpDown1.Value;

            // Aqui está a correção principal:
            Estoque estoqueSelecionado = (Estoque)listBoxEstoque.SelectedItem;

            if (estoqueSelecionado != null && quantidadeAdicionar > 0)
            {
                estoqueSelecionado.AdicionarQuantidade(quantidadeAdicionar);
                PersistenciaEstoque.saveToFile();
                AtualizarLista();

                listBoxEstoque.SelectedIndex = -1;
                numericUpDown1.Value = 0;


            }
            else
            {
                MessageBox.Show("Selecione um item válido e uma quantidade maior que 0.");
            }
        }

        private void listBoxEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxEstoque.SelectedItem != null)
            {
                numericUpDown1.Value = 1;
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int quantidadeRemover = (int)numericUpDown1.Value;
            Estoque estoqueSelecionado = (Estoque)listBoxEstoque.SelectedItem;

            // ✅ VERIFICAÇÃO MELHORADA
            if (estoqueSelecionado?.Produto != null && quantidadeRemover > 0 && estoqueSelecionado.Quantidade >= quantidadeRemover)
            {
                estoqueSelecionado.RemoverQuantidade(quantidadeRemover);
                PersistenciaEstoque.saveToFile();

                listBoxEstoque.SelectedIndex = -1;
                AtualizarLista();
                numericUpDown1.Value = 0;
            }
            else
            {
                MessageBox.Show("Selecione um item válido e uma quantidade maior que 0.");
            }
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
                formsTela formsTela = new formsTela();
                formsTela.Show();
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
