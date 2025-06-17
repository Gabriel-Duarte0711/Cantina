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
        private void ExibirErroSenha()
        {
            MessageBox.Show("A senha está incorreta.\n\nTente novamente.");
            txtBoxSenha.Focus();
            txtBoxSenha.SelectAll(); // Seleciona todo o texto para facilitar a correção
        }
        public void login()
        {
            string usuario = txtBoxUsuario.Text.ToLower().Trim();
            string senha = txtBoxSenha.Text.ToLower().Trim();
            
            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                txtBoxUsuario.Focus();
                return;
            }

            switch (usuario)
            {
                case "pedido":
                    if (senha == "pedido")
                    {
                        formsPedido formpedido = new formsPedido();
                        formpedido.Show();
                        this.Hide();
                        loginAdm loginAdm = new loginAdm();
                        loginAdm.adm = false;
                    }
                    else 
                    {
                        ExibirErroSenha();
                    }
                    break;
                case "balcao":
                    if (senha == "balcao")
                    {
                        formsBalcao formbalcao = new formsBalcao();
                        formbalcao.Show();
                        this.Hide();
                        loginAdm loginAdm = new loginAdm();
                        loginAdm.adm = false;
                    }
                    else
                    {
                        ExibirErroSenha();
                    }
                    break;
                case "cozinha":
                    if(senha == "cozinha")
                    {
                        formsCozinha formcozinha = new formsCozinha();
                        formcozinha.Show();
                        this.Hide();
                        loginAdm loginAdm = new loginAdm();
                        loginAdm.adm = false;
                    }
                    else
                    {  
                        ExibirErroSenha(); 
                    } 
                    break;
                case "admin":
                    if (senha == "admin")
                    {
                        formsAdm formadm = new formsAdm();
                        formadm.Show();
                        this.Hide();
                        loginAdm loginAdm = new loginAdm();
                        loginAdm.adm = true;
                    }
                    else 
                    {
                        ExibirErroSenha();
                    }
                    break;
                default:
                    MessageBox.Show("O nome do usuário está incorreto.\n\nTente novamente.");
                    txtBoxUsuario.Focus();
                    break;


            }

        
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login();

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

        private void formsLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
