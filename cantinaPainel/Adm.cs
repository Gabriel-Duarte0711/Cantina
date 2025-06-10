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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void formsAdm_Load(object sender, EventArgs e)
        {
            PersistenciaProduto.LoadListFromFile();

            if (PersistenciaEstoque.estoqueGeral.Count == 0)
            {
                PersistenciaEstoque.InicializarEstoque();
            }
            btnAtivo.Visible = false;
            btnEditar.Visible = false;
            btnNoAtivo.Visible = false;
            AtualizarLista();
        }

        private void listBoxTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listBoxTest.SelectedItem;

            if (produtoSelecionado != null)
            {
                txtBoxProduto.Text = produtoSelecionado.Item;
                txtBoxCodigo.Text = produtoSelecionado.Codigo.ToString();
                txtBoxPreco.Text = produtoSelecionado.Preco.ToString("F2");
                checkBox1.Checked = produtoSelecionado.IsChapa;
                lblCodigo.Text = "Edite o Código";
                lblProduto.Text = "Edite o Produto";
                lblPreco.Text = "Edite o Preço (R$)";
                btnAtivo.Visible = true;
                btnEditar.Visible = true;
                btnNoAtivo.Visible = true;
            }

        }
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = listBoxTest.IndexFromPoint(e.Location);
            if (index == ListBox.NoMatches)
            {
                listBoxTest.ClearSelected();
                txtBoxCodigo.Clear();
                txtBoxProduto.Clear();
                txtBoxPreco.Clear();
                checkBox1.Checked = false;
                btnAtivo.Visible = false;
                btnEditar.Visible = false;
                btnNoAtivo.Visible = false;
                lblCodigo.Text = "Código do Produto";
                lblProduto.Text = "Nome do Produto";
                lblPreco.Text = "Preço (R$)";
            }
        }


        private void txtBoxPreco_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            // Impede mais de uma vírgula ou ponto
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string valorTexto = txtBoxPreco.Text;
            Produto produtoSelecionado = (Produto)listBoxTest.SelectedItem;
            if (txtBoxProduto.Text.Length > 0 && txtBoxPreco.Text.Length > 0 && txtBoxCodigo.Text.Length > 0 && produtoSelecionado != null)
            {
                if (Int32.TryParse(txtBoxCodigo.Text, out int intValor))
                {
                    txtBoxCodigo.Text = intValor.ToString();
                }
                else
                {
                    MessageBox.Show("Número inválido.");
                    txtBoxPreco.Focus();
                }
                if (double.TryParse(txtBoxPreco.Text.Replace('.', ','), out double valor))
                {

                    txtBoxPreco.Text = valor.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Número inválido.");
                    txtBoxPreco.Focus();
                }

                produtoSelecionado.Codigo = intValor;
                produtoSelecionado.Item = txtBoxProduto.Text;
                produtoSelecionado.Preco = valor;
                produtoSelecionado.IsChapa = checkBox1.Checked;
                PersistenciaProduto.saveToFile();

                AtualizarLista();
            }
            else if (string.IsNullOrWhiteSpace(txtBoxCodigo.Text) || string.IsNullOrWhiteSpace(txtBoxPreco.Text) || string.IsNullOrWhiteSpace(txtBoxProduto.Text) || produtoSelecionado == null)
            {
                MessageBox.Show("Falta alguma informação");
            }
        }

        private void txtBoxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

            // Impede mais de uma vírgula ou ponto
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (txt.Text.Contains(",") || txt.Text.Contains(".")))
            {
                e.Handled = true;
            }
        }

        private void btnNoAtivo_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listBoxTest.SelectedItem;

            if (produtoSelecionado != null)
            {
                produtoSelecionado.IsAtivo = false;
                MessageBox.Show($"{produtoSelecionado.Item} desativado");
                PersistenciaProduto.saveToFile();

                AtualizarLista();
            }
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listBoxTest.SelectedItem;

            if (produtoSelecionado != null)
            {
                produtoSelecionado.IsAtivo = true;
                MessageBox.Show($"{produtoSelecionado.Item} Ativado");
                PersistenciaProduto.saveToFile();

                AtualizarLista();
            }
        }

        
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novoItem = txtBoxProduto.Text.Trim();

            if (string.IsNullOrEmpty(novoItem))
            {
                MessageBox.Show("Digite um produto válido.");
                txtBoxProduto.Focus();
                return;
            }

            if (!Int32.TryParse(txtBoxCodigo.Text, out int intValor))
            {
                MessageBox.Show("Número inválido no código.");
                txtBoxCodigo.Focus();
                return;
            }

            if (!double.TryParse(txtBoxPreco.Text.Replace('.', ','), out double valor))
            {
                MessageBox.Show("Número inválido no preço.");
                txtBoxPreco.Focus();
                return;
            }

            int codigo = intValor;
            double preco = valor;
            bool isChapa = checkBox1.Checked;
            bool isAtivo = true;

            Produto novoProduto = new Produto(codigo, novoItem, preco, isChapa, isAtivo);

            PersistenciaProduto.itemEstoque.Add(novoProduto);
            PersistenciaProduto.saveToFile();

            AtualizarLista();

            // Limpa todos os campos depois de adicionar
            txtBoxProduto.Clear();
            txtBoxCodigo.Clear();
            txtBoxPreco.Clear();

            txtBoxProduto.Focus();
        }

    }
}
