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
        List<Estoque> estoqueGeral = new List<Estoque>();
        public formsEstoque()
        {
            InitializeComponent();
        }

        private void telaEstoque_Load(object sender, EventArgs e)
        {
            foreach (var produto in PersistenciaProduto.itemEstoque)
            {
                Estoque novoEstoque = new Estoque();
                novoEstoque.Produto = produto;
                novoEstoque.Quantidade = 10; // exemplo: 10 unidades de cada
                estoqueGeral.Add(novoEstoque);
            }

            foreach (var item in estoqueGeral)
            {
                listBoxEstoque.Items.Add(item);
            }
        }
    }
}
