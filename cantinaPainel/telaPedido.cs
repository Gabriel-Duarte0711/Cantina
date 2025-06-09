using System.ComponentModel;
using System.Numerics;
using System.Text.Json;
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
            foreach (var item in PersistenciaProduto.itemEstoque)
            {
                listAdicionar.Items.Add(item);
            }
            PersistenciaEstoque.LoadListFromFile();
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
            int quant = (int)numericQuantidade.Value;
            Produto produtoSelecionado = (Produto)listAdicionar.SelectedItem;

            if (listAdicionar.SelectedIndex != -1 && quant > 0)
            {
                Estoque estoque = null;

                foreach (Estoque es in PersistenciaEstoque.estoqueGeral)
                {
                    if (es.Produto.Codigo == produtoSelecionado.Codigo)
                    {
                        estoque = es;
                        break;
                    }
                }

                if (estoque != null && quant <= estoque.Quantidade)
                {
                    Produto novoItem = new Produto(produtoSelecionado.Codigo, produtoSelecionado.Item, produtoSelecionado.Preco, produtoSelecionado.IsChapa);

                    bool encontrado = false;

                    foreach (Produto item in listPedido.Items)
                    {
                        if (item.Codigo == produtoSelecionado.Codigo)
                        {
                            item.Quantidade += quant;
                            int index = listPedido.Items.IndexOf(item);
                            if (index >= 0)
                                listPedido.Items[index] = item;
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        novoItem.Quantidade = quant;
                        listPedido.Items.Add(novoItem);
                        extrato2.Add(novoItem);
                    }

                    // Atualiza total
                    totalPedido += novoItem.Preco * quant;
                    listPedido.Refresh();
                    total.Text = $"O total é: R${totalPedido:f2}";

                    // Decrementa estoque
                    estoque.RemoverQuantidade(quant);

                    // Limpa inputs
                    listAdicionar.SelectedIndex = -1;
                    numericQuantidade.Value = 0;
                }
                else
                {
                    MessageBox.Show("Estoque insuficiente para este produto.");
                }
            }
            else
            {
                MessageBox.Show("Tem que adicionar ao menos uma unidade.");
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listPedido.SelectedItem;
            int quantidadeRemover = (int)numericQuantidade.Value;

            if (produtoSelecionado == null || quantidadeRemover <= 0)
            {
                MessageBox.Show("Selecione um produto e quantidade válida.");
                return;
            }

            if (quantidadeRemover > produtoSelecionado.Quantidade)
            {
                MessageBox.Show($"Quantidade máxima: {produtoSelecionado.Quantidade}");
                return;
            }

            // Calcular valor a descontar
            double valorRemover = produtoSelecionado.Preco * quantidadeRemover;

            // Atualizar quantidade ou remover produto
            if (quantidadeRemover >= produtoSelecionado.Quantidade)
            {
                // Remove produto completamente
                listPedido.Items.Remove(produtoSelecionado);
                extrato2.Remove(produtoSelecionado);
            }
            else
            {
                // Remove apenas parte da quantidade
                produtoSelecionado.Quantidade -= quantidadeRemover;
                listPedido.Refresh();
            }
            var estoqueReal = PersistenciaEstoque.estoqueGeral.FirstOrDefault(e => e.Produto.Codigo == produtoSelecionado.Codigo);
            estoqueReal?.AdicionarQuantidade(quantidadeRemover);
            // Atualizar total e limpar seleção
            totalPedido -= valorRemover;
            total.Text = $"O total é: R${totalPedido:f2}";
            listPedido.SelectedIndex = -1;
            numericQuantidade.Value = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            if (txtBoxNome.Text.Length > 0 && listPedido.Items.Count != 0 && metodoPgmt != null)
            {


                DateTime hora = DateTime.Now;
                Pedido pedido = new Pedido();
                PersistenciaPedido.ProximoNumeroPedido();
                PersistenciaPedido.numeroPedido++;
                pedido.CodigoPedido = PersistenciaPedido.numeroPedido;
                pedido.Nome_Cliente = (txtBoxNome.Text);
                pedido.extrato = listPedido.Items.Cast<Produto>().ToList();

                bool pedidoTemChapa = false;
                foreach (Produto produto in pedido.extrato)
                {
                    if (produto.IsChapa)
                    {
                        pedidoTemChapa = true;
                        break; // Achou um, já pode parar de procurar
                    }
                }
                if (pedidoTemChapa)
                {
                    pedido.StatusPedido = Status.PREPARANDO;
                }
                else
                {
                    pedido.StatusPedido = Status.PRONTO;
                }
                pedido.IsViagem = checkBox1.Checked;
                pedido.MetodoPagamento = metodoPgmt;
                PersistenciaPedido.pedidos.Add(pedido);
                PersistenciaPedido.saveToFile();

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

        private void button3_Click(object sender, EventArgs e)
        {
            formsTela formsTela = new formsTela();
            formsTela.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersistenciaPedido.LimparArquivo();
            PersistenciaEstoque.LimparArquivoEstoque();
        }
    }
}
