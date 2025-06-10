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
        private void AtualizarLista()
        {
            int selectedIndex = listBoxEstoque.SelectedIndex;

            listBoxEstoque.Items.Clear();

            foreach (Estoque estoque in PersistenciaEstoque.estoqueGeral)
            {
                if (estoque.Produto.IsAtivo)
                {
                    listBoxEstoque.Items.Add(estoque);
                }
            }

            // Restaurar seleção se ainda válida
            if (selectedIndex >= 0 && selectedIndex < listBoxEstoque.Items.Count)
            {
                listBoxEstoque.SelectedIndex = selectedIndex;
            }
        }

        private void telaEstoque_Load(object sender, EventArgs e)
        {
            PersistenciaEstoque.LoadListFromFile();

            if (PersistenciaEstoque.estoqueGeral.Count == 0)
            {
                PersistenciaEstoque.InicializarEstoque();
            }

            AtualizarLista();
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
    }
}
