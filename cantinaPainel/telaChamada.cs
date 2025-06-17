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
        private System.Windows.Forms.Timer temporizador;

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
                    ChamadaGigante chamadaGigante = new ChamadaGigante();
                    chamadaGigante.ShowDialog();
                    listBoxNomePronto.Items.Insert(0, item.Nome_Cliente);
                }
            }
            temporizador = new System.Windows.Forms.Timer();
            temporizador.Interval = 30000;
            temporizador.Tick += Temporizador_Tick;
            temporizador.Start();
        }
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (listBoxNomePronto.Items.Count > 0)
            {
                var ultimoItem = listBoxNomePronto.Items[listBoxNomePronto.Items.Count - 1];
                foreach (var item in PersistenciaPedido.pedidos)
                {
                    ultimoItem = (item.StatusPedido = Status.FINALIZADO);
                }
                listBoxNomePronto.Items.RemoveAt(listBoxNomePronto.Items.Count - 1);
            }
        }
        private void listBoxNomePronto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formsBalcao formlogin = new formsBalcao();
            formlogin.Show();
        }
    }
}
