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
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(
            IntPtr hWnd,
            int msg,
            int wParam,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam
        );
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in PersistenciaProduto.itemEstoque)
            {
                if (item.IsAtivo)
                {
                    listAdicionar.Items.Add(item);
                }
            }

            PersistenciaEstoque.LoadListFromFile();
            comboBoxPagamento.Items.Add("Pix");
            comboBoxPagamento.Items.Add("Dinheiro");
            comboBoxPagamento.Items.Add("Cr�dito");
            comboBoxPagamento.Items.Add("D�bito");
            comboBoxPagamento.Items.Add("Va");
            comboBoxPagamento.Items.Add("Vr");
            comboBoxPagamento.SelectedIndex = 0;

            if (loginAdm.adm == false)
            {
                comboBoxMenu.Visible = false;
            }
            if (loginAdm.adm == true)
            {
                comboBoxMenu.Visible = true;
            }
            //txtBoxTroco.ReadOnly = true;
            txtBoxTroco.Enabled = false;

            SendMessage(this.comboBoxMenu.Handle, CB_SETCUEBANNER, 0, "Menu");
            comboBoxMenu.Items.Add("Adm");
            comboBoxMenu.Items.Add("Balc�o");
            comboBoxMenu.Items.Add("Cozinha");
            comboBoxMenu.Items.Add("Chamada");
            comboBoxMenu.Items.Add("Estoque");
            comboBoxMenu.Items.Add("Login");
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
                    Produto novoItem = new Produto(produtoSelecionado.Codigo, produtoSelecionado.Item, produtoSelecionado.Preco, produtoSelecionado.IsChapa, produtoSelecionado.IsAtivo);

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
                    total.Text = $"O total �: R${totalPedido:f2}";

                    // Decrementa estoque
                    estoque.RemoverQuantidade(quant);

                    if (estoque.EstoqueBaixo())
                    {
                        MessageBox.Show($"Estoque est� baixo\n{produtoSelecionado.Item} - {estoque.Quantidade}");
                    }
                    PersistenciaEstoque.saveToFile();

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
                MessageBox.Show("Selecione um produto e quantidade v�lida.");
                return;
            }

            if (quantidadeRemover > produtoSelecionado.Quantidade)
            {
                MessageBox.Show($"Quantidade m�xima: {produtoSelecionado.Quantidade}");
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
            // Atualizar total e limpar sele��o
            totalPedido -= valorRemover;
            total.Text = $"O total �: R${totalPedido:f2}";
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
                pedido.CodigoPedido = PersistenciaPedido.numeroPedido;
                pedido.Nome_Cliente = (txtBoxNome.Text);
                pedido.extrato = listPedido.Items.Cast<Produto>().ToList();

                bool pedidoTemChapa = false;
                foreach (Produto produto in pedido.extrato)
                {
                    if (produto.IsChapa)
                    {
                        pedidoTemChapa = true;
                        break; // Achou um, j� pode parar de procurar
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
                MessageBox.Show($"Cliente: {pedido.Nome_Cliente} \n{Extrato}\n \no total �: {totalPedido:f2}\nPedido para: {check}\nPago no: {metodoPgmt}\ndata: {hora}");
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
            Globais.VoltarLogin(this);
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
                metodoPgmt = "Cr�dito";
            }
            else if (comboBoxPagamento.SelectedIndex == 3)
            {
                mostrarTroco = false;
                metodoPgmt = "D�bito";
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

        private void button4_Click(object sender, EventArgs e)
        {
            PersistenciaPedido.LimparArquivo();
            PersistenciaEstoque.LimparArquivoEstoque();
            PersistenciaProduto.LimparArquivo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formsEstoque formsEstoque = new formsEstoque();
            formsEstoque.Show();
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
                formsBalcao formsBalcao = new formsBalcao();
                formsBalcao.Show();
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
                comboBoxMenu.SelectedIndex= -1;
            }
        }
    }
}
