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
                Cardapio produtoSelecionado = (Cardapio)listPedido.SelectedItem;
                numericQuantidade.Value = produtoSelecionado.Quantidade;
                numericQuantidade.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            listAdicionar.Items.Add(new Cardapio("Pão de Queijo", 3.50));

            listAdicionar.Items.Add(new Cardapio("Coxinha ", 5.00));

            listAdicionar.Items.Add(new Cardapio("Pastel de Carne", 6.00));

            listAdicionar.Items.Add(new Cardapio("Pastel de Queijo", 5.50));

            listAdicionar.Items.Add(new Cardapio("Suco Natural (300ml)", 4.00));

            listAdicionar.Items.Add(new Cardapio("Refrigerante Lata", 4.50));

            listAdicionar.Items.Add(new Cardapio("Hamburguer Simples", 8.00));

            listAdicionar.Items.Add(new Cardapio("Hambúrguer com Queijo", 9.00));

            listAdicionar.Items.Add(new Cardapio("X-Tudo", 12.00));

            listAdicionar.Items.Add(new Cardapio("Água Mineral (500ml)", 2.50));



            comboBoxPagamento.Items.Add("Pix");
            comboBoxPagamento.Items.Add("Dinheiro");
            comboBoxPagamento.Items.Add("Crédito");
            comboBoxPagamento.Items.Add("Débito");
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
                Cardapio produtoSelecionado = (Cardapio)listAdicionar.SelectedItem;
                Cardapio novoItem = new Cardapio(produtoSelecionado.Produto, produtoSelecionado.Preco);
                novoItem.Quantidade = (int)numericQuantidade.Value;
                listPedido.Items.Add(novoItem);
                Globais.extrato.Add(novoItem);
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
                Cardapio produtoSelecionado = (Cardapio)listPedido.SelectedItem;

                if (listPedido.SelectedIndex != -1)
                {
                    numericQuantidade.Value = produtoSelecionado.Quantidade;
                }
                listPedido.Items.Remove(produtoSelecionado);
                Globais.extrato.Remove(produtoSelecionado);
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
            if (txtBoxNome.Text.Length > 0 && listPedido.Items.Count != 0)
            {

                listPedido.Items.Clear();
                string Extrato = string.Join("\n", Globais.extrato);
                MessageBox.Show($"Extrato:\n{Extrato}\n\no total e: {totalPedido:f2}");
                total.Text = $"O total e: R${totalPedido = 0}";
                txtBoxNome.Clear();
                txtBoxTroco.Clear();
                numericTroco.Value = 0;
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

        private void btnExtrato_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTroco_Click(object sender, EventArgs e)
        {
            double troco = (double)numericTroco.Value;
            totalTroco = troco - totalPedido;
            txtBoxTroco.Text = $"R$: {totalTroco:f2}";
        }

        private void comboBoxPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrarTroco = comboBoxPagamento.SelectedIndex == 1;

            numericTroco.Visible = mostrarTroco;
            txtBoxTroco.Visible = mostrarTroco;
            btnTroco.Visible = mostrarTroco;
            label6.Visible = mostrarTroco;
            label7.Visible = mostrarTroco;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formsBalcao formbalcao = new formsBalcao();
            formbalcao.Show();
            this.Hide();
        }

        private void numericTroco_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
