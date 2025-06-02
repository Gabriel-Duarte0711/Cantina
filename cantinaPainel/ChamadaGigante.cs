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
    public partial class ChamadaGigante : Form
    {
        public ChamadaGigante()
        {
            InitializeComponent();
        }

        private void ChamadaGigante_Load(object sender, EventArgs e)
        {
            foreach (var item in PersistenciaPedido.pedidos)
            {
                label1.Text = item.Nome_Cliente;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }
    }
}
