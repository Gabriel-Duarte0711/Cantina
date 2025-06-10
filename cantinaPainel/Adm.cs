using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace cantinaPainel
{
    public partial class formsAdm : Form
    {
        public formsAdm()
        {
            InitializeComponent();
        }

        private void txtBoxAddProdito_TextChanged(object sender, EventArgs e)
        {

        }
        private void AtualizarLista()
        {
            listBoxTest.SelectedIndexChanged -= listBoxTest_SelectedIndexChanged;

            int selectedIndex = listBoxTest.SelectedIndex;
            listBoxTest.DataSource = null;
            listBoxTest.DataSource = PersistenciaProduto.itemEstoque;

            listBoxTest.SelectedIndex = -1;

            listBoxTest.SelectedIndexChanged += listBoxTest_SelectedIndexChanged;

            if (selectedIndex >= 0 && selectedIndex < listBoxTest.Items.Count)
            {
                listBoxTest.SelectedIndex = selectedIndex;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

        }

        private void formsAdm_Load(object sender, EventArgs e)
        {
            PersistenciaEstoque.LoadListFromFile();

            if (PersistenciaEstoque.estoqueGeral.Count == 0)
            {
                PersistenciaEstoque.InicializarEstoque();
            }

            AtualizarLista();
        }

        private void listBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listBoxTest.SelectedItem;

            

           
            if (produtoSelecionado != null)
            {
                txtBoxProduto.Text = produtoSelecionado.Item;
                txtBoxCodigo.Text = produtoSelecionado.Codigo.ToString();
                txtBoxPreco.Text = produtoSelecionado.Preco.ToString();
                lblCodigo.Text = "Edite o código";
                lblProduto.Text = "Edite o produto";
                lblPreco.Text = "Edite o preço";
            }
        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxTest.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
            {
                listBoxTest.ClearSelected();
            }
        }
    }
}
