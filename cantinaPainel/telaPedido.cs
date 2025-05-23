using System.ComponentModel;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cantinaPainel
{
    public partial class formsPedido : Form
    {
        public formsPedido()
        {
            InitializeComponent();
        }

        private double totalPedido = 0;
        private double totalTroco = 0;
        private string nome;
        public string metodoPgmt;
        string check = "Local";
        List<Produto> extrato2 = new();
        private void listAdicionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAdicionar.SelectedIndex != -1)
            {
                numericQuantidade.Value = 1;
                numericQuantidade.Enabled = true;
            }
        }

        private void listPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPedido.SelectedIndex != -1)
            {
                Produto produtoSelecionado = (Produto)listPedido.SelectedItem;
                numericQuantidade.Value = produtoSelecionado.Quantidade;
                numericQuantidade.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            listAdicionar.Items.Add(new Produto(1, "Pão de Queijo", 3.50, false));

            listAdicionar.Items.Add(new Produto(2, "Coxinha ", 5.00, false));

            listAdicionar.Items.Add(new Produto(3, "Pastel de Carne", 6.00, true));

            listAdicionar.Items.Add(new Produto(4, "Pastel de Queijo", 5.50, true));

            listAdicionar.Items.Add(new Produto(5, "Suco Natural (300ml)", 4.00, false));

            listAdicionar.Items.Add(new Produto(6, "Refrigerante Lata", 4.50, false));

            listAdicionar.Items.Add(new Produto(7, "Hamburguer Simples", 8.00, true));

            listAdicionar.Items.Add(new Produto(8, "Hambúrguer com Queijo", 9.00, true));

            listAdicionar.Items.Add(new Produto(9, "X-Tudo", 12.00, true));

            listAdicionar.Items.Add(new Produto(10, "Água Mineral (500ml)", 2.50, false));

            comboBoxPagamento.Items.Add("Pix");
            comboBoxPagamento.Items.Add("Dinheiro");
            comboBoxPagamento.Items.Add("Crédito");
            comboBoxPagamento.Items.Add("Débito");
            comboBoxPagamento.Items.Add("Va");
            comboBoxPagamento.Items.Add("Vr");
            comboBoxPagamento.SelectedIndex = 0;

            //txtBoxTroco.ReadOnly = true;
            txtBoxTroco.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (listAdicionar.SelectedIndex != -1 && numericQuantidade.Value > 0)
            {
                double quant = (double)numericQuantidade.Value;
                Produto produtoSelecionado = (Produto)listAdicionar.SelectedItem;
                Produto novoItem = new Produto(produtoSelecionado.Codigo, produtoSelecionado.Item, produtoSelecionado.Preco, produtoSelecionado.IsChapa);
                novoItem.Quantidade = (int)numericQuantidade.Value;
                listPedido.Items.Add(novoItem);
                extrato2.Add(novoItem);
                totalPedido += novoItem.Preco * quant;

                total.Text = $"O total e: R${totalPedido:f2}";
                listAdicionar.SelectedIndex = -1;
                numericQuantidade.Value = 0;
            }
            else if (numericQuantidade.Value <= 0)
            {
                MessageBox.Show("tem que adicionar ao menos uma unidade");
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listPedido.SelectedIndex != -1 & numericQuantidade.Value > 0)
            {

                double quant = (double)numericQuantidade.Value;
                Produto produtoSelecionado = (Produto)listPedido.SelectedItem;

                if (listPedido.SelectedIndex != -1)
                {
                    numericQuantidade.Value = produtoSelecionado.Quantidade;
                }
                listPedido.Items.Remove(produtoSelecionado);
                extrato2.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco * quant;
                total.Text = $"O total e: R${totalPedido:f2}";

                listPedido.SelectedIndex = -1;
                numericQuantidade.Value = 0;
            }
            else if (numericQuantidade.Value <= 0)
            {
                MessageBox.Show("tem que adicionar ao menos uma unidade");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtBoxNome.Text.Length > 0 && listPedido.Items.Count != 0 && metodoPgmt != null)
            {

                DateTime hora = DateTime.Now;
                Pedido pedido = new Pedido();
                pedido.Nome_Cliente = (txtBoxNome.Text);
                pedido.StatusPedido = Status.PREPARANDO;
                pedido.IsViagem = checkBox1.Checked;
                pedido.extrato = listPedido.Items.Cast<Produto>().ToList();
                PersistenciaPedido.pedidos.Add(pedido);
                txtBoxNome.Clear();

                listPedido.Items.Clear();


                string Extrato = string.Join("\n", extrato2);
                MessageBox.Show($"Cliente: {pedido.Nome_Cliente} \n{Extrato}\n \no total é: {totalPedido:f2}\nPedido para: {check}\nPago no: {metodoPgmt}\ndata: {hora}");
                total.Text = $"O total e: R${totalPedido = 0}";


                extrato2.Clear();
                txtBoxTroco.Clear();
                numericTroco.Value = 0;
                checkBox1.Checked = false;
            }
            else if (txtBoxNome.Text.Length == 0)
            {
                MessageBox.Show("Digite o nome");
            }
            else if (listPedido.Items.Count == 0)
            {
                MessageBox.Show("Carrinho esta vazio");
            }
        }



        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formsLogin formlogin = new formsLogin();
            formlogin.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTroco_Click(object sender, EventArgs e)
        {

            double troco = (double)numericTroco.Value;
            if (troco >= totalPedido)
            {
                totalTroco = troco - totalPedido;
                txtBoxTroco.Text = $"R$: {totalTroco:f2}";
                metodoPgmt = "Dinheiro";
            }
            else
            {
                MessageBox.Show("troco insuficiente");
            }

        }

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrarTroco = false;
            if (comboBoxPagamento.SelectedIndex == 1)
            {
                mostrarTroco = true;
            }

            else if (comboBoxPagamento.SelectedIndex == 0)
            {
                mostrarTroco = false;
                metodoPgmt = "Pix";
            }

            else if (comboBoxPagamento.SelectedIndex == 2)
            {
                mostrarTroco = false;
                metodoPgmt = "Crédito";
            }
            else if (comboBoxPagamento.SelectedIndex == 3)
            {
                mostrarTroco = false;
                metodoPgmt = "Débito";
            }
            else if (comboBoxPagamento.SelectedIndex == 4)
            {
                mostrarTroco = false;
                metodoPgmt = "Va";
            }
            else if (comboBoxPagamento.SelectedIndex == 5)
            {
                mostrarTroco = false;
                metodoPgmt = "Vr";
            }
            numericTroco.Visible = mostrarTroco;
            txtBoxTroco.Visible = mostrarTroco;
            btnTroco.Visible = mostrarTroco;
            label6.Visible = mostrarTroco;
            label7.Visible = mostrarTroco;
            txtBoxTroco.Enabled = mostrarTroco;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            formsBalcao formbalcao = new formsBalcao();
            formbalcao.Show();
            this.Hide();
        }

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericTroco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                check = "Viagem";
            }
            else
            {
                check = "Local";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formsCozinha formsCozinha = new formsCozinha();
            formsCozinha.Show();
            this.Hide();
        }
    }
}
