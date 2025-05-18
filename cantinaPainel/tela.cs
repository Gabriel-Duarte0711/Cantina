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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void formsTela_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView2.View = View.Details;

            listView1.Columns.Add("PREPARANDO", 150, HorizontalAlignment.Center);
            listView2.Columns.Add("PRONTO", 150, HorizontalAlignment.Center);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
