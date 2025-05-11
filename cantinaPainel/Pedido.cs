using System.ComponentModel;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace cantinaPainel
{
    public partial class formsPedido : Form
    {
        public formsPedido()
        {
            InitializeComponent();
        }


        List<Cardapio> extrato = new();
        private double totalPedido = 0;

        private void listAdicionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAdicionar.SelectedIndex != -1)
            {
                numericQuantidade.Value = 1;
            }
        }

        private void listPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPedido.SelectedIndex != -1)
            {
                numericQuantidade.Value = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listAdicionar.Items.Add(new Cardapio("Coxinha ", 5.00));

            listAdicionar.Items.Add(new Cardapio("Pastel ", 6.00));

            listAdicionar.Items.Add(new Cardapio("Refrigerante ", 4.50));

            listAdicionar.Items.Add(new Cardapio("Suco ", 3.00));

            listAdicionar.Items.Add(new Cardapio("Brigadeiro ", 2.00));


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            if (listAdicionar.SelectedIndex != -1 && numericQuantidade.Value > 0)
            {
                double quant = (double)numericQuantidade.Value;
                Cardapio produtoSelecionado = (Cardapio)listAdicionar.SelectedItem;
                listPedido.Items.Add(produtoSelecionado);
                extrato.Add(produtoSelecionado);
                totalPedido += produtoSelecionado.Preco * quant;

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
                listPedido.Items.Remove(produtoSelecionado);
                extrato.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco * quant;
                listPedido.SelectedIndex = -1;
                total.Text = $"O total e: R${totalPedido:f2}";
                numericQuantidade.Value = 0;
            }
            else if (numericQuantidade.Value <= 0)
            {
                MessageBox.Show("tem que adicionar ao menos uma unidade");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            listPedido.Items.Clear();
            string Extrato = string.Join("\n", extrato);
            MessageBox.Show($"Extrato:\n{Extrato}\n\no total e: {totalPedido:f2}");
            total.Text = $"O total e: R${totalPedido = 0}";
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
    }
}
