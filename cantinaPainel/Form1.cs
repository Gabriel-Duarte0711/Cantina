using System.Numerics;

namespace cantinaPainel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double totalPedido = 0;

        private void listAdicionar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listAdicionar.Items.Add(new Cardapio("Coxinha", 5.00));
           
            listAdicionar.Items.Add(new Cardapio("Pastel", 6.00));

            listAdicionar.Items.Add(new Cardapio("Refrigerante", 4.50));

            listAdicionar.Items.Add(new Cardapio("Suco", 3.00));
            
            listAdicionar.Items.Add(new Cardapio("Brigadeiro", 2.00));


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (listAdicionar.SelectedIndex != -1)
            {
                Cardapio produtoSelecionado = (Cardapio)listAdicionar.SelectedItem;
                listPedido.Items.Add(produtoSelecionado);
                totalPedido += produtoSelecionado.Preco;

                total.Text = $"O total e: R${totalPedido:f2}";

                listAdicionar.SelectedIndex = -1;
               
            }
      
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listPedido.SelectedIndex != -1)
            {
                Cardapio produtoSelecionado = (Cardapio)listPedido.SelectedItem;
                listPedido.Items.Remove(produtoSelecionado);
                totalPedido -= produtoSelecionado.Preco;
                
                listPedido.SelectedIndex = -1;

                total.Text = $"O total e: R${totalPedido:f2}";
            }
        }

        private void total_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            listPedido.Items.Clear();
            MessageBox.Show($"o total e: {totalPedido:f2}");
            total.Text = $"O total e: R${totalPedido = 0}";

        }
    }
}
