using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    internal class Globais
    {
        public static void VoltarLogin(Form formAtual)
        {
            DialogResult result = MessageBox.Show(
                "Deseja voltar para o login?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                formAtual.Close(); // Esconde o form atual
                formsLogin formLogin = new formsLogin();
                formLogin.Show();

                // Opcional: fechar o form atual completamente
                // formAtual.Close();
            }
        }
        }
    }
