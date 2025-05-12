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
    public partial class formsLogin : Form
    {
        public formsLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtBoxUsuario.Text == "pedido" && txtBoxSenha.Text == "pedido")
            {
                formsPedido formpedido = new formsPedido();
                formpedido.Show();
                this.Hide();
            }
            else if (txtBoxUsuario.Text == "balcao" && txtBoxSenha.Text == "balcao")
            {
                formsBalcao formbalcao = new formsBalcao();
                formbalcao.Show();
                this.Hide();
            }
            else if (txtBoxUsuario.Text == "cozinha" && txtBoxSenha.Text == "cozinha")
            {
                formsCozinha formcozinha = new formsCozinha();
                formcozinha.Show();
                this.Hide();
            }
            else if (txtBoxUsuario.Text == "adm" && txtBoxSenha.Text == "adm")
            {
                formsAdm formadm = new formsAdm();
                formadm.Show();
                this.Hide();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxSenha_TextChanged(object sender, EventArgs e)
        {
           
            txtBoxSenha.PasswordChar = '*';
            txtBoxSenha.MaxLength = 10;
        }

       
    }
}
