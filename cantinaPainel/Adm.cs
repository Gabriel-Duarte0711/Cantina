﻿using System;
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

        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(
            IntPtr hWnd,
            int msg,
            int wParam,
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam
        );
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
            SendMessage(this.comboBoxMenu.Handle, CB_SETCUEBANNER, 0, "Menu");
            comboBoxMenu.Items.Add("Pedido");
            comboBoxMenu.Items.Add("Balcão");
            comboBoxMenu.Items.Add("Cozinha");
            comboBoxMenu.Items.Add("Chamada");
            comboBoxMenu.Items.Add("Estoque");
            comboBoxMenu.Items.Add("Login");

            comboBoxMenu.SelectedIndex = -1;
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
                txtBoxProcurar.Clear();
                checkBox1.Checked = false;
                btnAtivo.Visible = false;
                btnEditar.Visible = false;
                btnNoAtivo.Visible = false;
                lblCodigo.Text = "Código do Produto";
                lblProduto.Text = "Nome do Produto";
                lblPreco.Text = "Preço (R$)";
                AtualizarLista();
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
                    txtBoxCodigo.Focus();
                    return;
                }
                if (double.TryParse(txtBoxPreco.Text.Replace('.', ','), out double valor))
                {

                    txtBoxPreco.Text = valor.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Número inválido.");
                    txtBoxPreco.Focus();
                    return;
                }

                produtoSelecionado.Codigo = intValor;
                produtoSelecionado.Item = txtBoxProduto.Text;
                produtoSelecionado.Preco = valor;
                produtoSelecionado.IsChapa = checkBox1.Checked;
                PersistenciaProduto.saveToFile();
                PersistenciaEstoque.saveToFile();

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
            DialogResult result = MessageBox.Show(
            $"Deseja desativar esse produto? {produtoSelecionado.Item}",
            "Confirmação",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                if (produtoSelecionado != null)
                {
                    produtoSelecionado.IsAtivo = false;
                    MessageBox.Show($"{produtoSelecionado.Item} desativado");
                    PersistenciaProduto.saveToFile();
                    PersistenciaEstoque.saveToFile();

                    AtualizarLista();
                }
            }
            else { }





        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = (Produto)listBoxTest.SelectedItem;

            if (produtoSelecionado != null)
            {
                produtoSelecionado.IsAtivo = true;
                MessageBox.Show($"{produtoSelecionado.Item} Ativado");
                PersistenciaProduto.saveToFile();
                PersistenciaEstoque.saveToFile();

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

            foreach (var item in PersistenciaProduto.itemEstoque)
            {
                if (intValor == item.Codigo)
                {
                    MessageBox.Show("Código ja existe");
                    txtBoxCodigo.Focus();
                    return;
                }
            }


            int codigo = intValor;
            double preco = valor;
            bool isChapa = checkBox1.Checked;
            bool isAtivo = true;

            Produto novoProduto = new Produto(codigo, novoItem, preco, isChapa, isAtivo);
            Estoque estoque = new Estoque(novoProduto, 0);

            PersistenciaProduto.itemEstoque.Add(novoProduto);
            PersistenciaEstoque.estoqueGeral.Add(estoque);

            PersistenciaEstoque.saveToFile();
            PersistenciaProduto.saveToFile();

            AtualizarLista();
            txtBoxProduto.Clear();
            txtBoxCodigo.Clear();
            txtBoxPreco.Clear();
            checkBox1.Checked = false;

            txtBoxProduto.Focus();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            formsEstoque formsEstoque = new formsEstoque();
            formsEstoque.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void formsAdm_Activated(object sender, EventArgs e)
        {
            comboBoxMenu.SelectedIndex = -1;
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxMenu.SelectedIndex == 0)
            {
                formsPedido formsPedido = new formsPedido();
                formsPedido.Show();
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
                Globais.VoltarLogin(this);
                comboBoxMenu.SelectedIndex = -1;
            }

        }

        private void btnExcluirArquivo_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Realmente deseja excluir tudo salvo?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                DialogResult result2 = MessageBox.Show(
                    "ISSO VAI EXCLUIR TUDO JA SALVO, TEM CERTEZA?",
                    "CONFIRMAÇÂO",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (result2 == DialogResult.Yes)
                {
                    PersistenciaPedido.LimparArquivo();
                    PersistenciaEstoque.LimparArquivoEstoque();
                    PersistenciaProduto.LimparArquivo();
                    AtualizarLista();
                }
                else { }

            }
            else { }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxProcurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            int intValor=0;
            if (e.KeyChar == (char)Keys.Enter)
            {

                Int32.TryParse(txtBoxProcurar.Text, out intValor);

                foreach (Produto item in PersistenciaProduto.itemEstoque)
                {
                    if (intValor == item.Codigo)
                    {
                        listBoxTest.DataSource = null;
                        listBoxTest.Items.Clear();
                        listBoxTest.Items.Add(item);
                        listBoxTest.SelectedItem = item;
                        break;
                    }

                }
                if (listBoxTest.SelectedItem == null)
                {
                    MessageBox.Show("Digite um número válido");

                }
            }
        }

        

        private void txtBoxProcurar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
