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
    public partial class formsTela : Form
    {
        public formsTela()
        {
            InitializeComponent();
        }

        private void formsTela_Load(object sender, EventArgs e)
        {
            foreach (var item in PersistenciaPedido.pedidos)
            {
                if (item.StatusPedido == Status.PRONTO || item.StatusPedido == Status.PREPARANDO)
                {
                    listBoxNomePreparando.Items.Insert(0, item.Nome_Cliente);
                }
                else if (item.StatusPedido == Status.ENTREGUE)
                {
                    listBoxNomePronto.Items.Insert(0, item.Nome_Cliente);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            formsBalcao formlogin = new formsBalcao();
            formlogin.Show();
        }
    }
}
