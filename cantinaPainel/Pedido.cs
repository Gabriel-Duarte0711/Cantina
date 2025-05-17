using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    internal class Pedido
    {
        private string nomes;
        private int quantidade;

        public string Nome
        {
            get { return nomes; }
            set { nomes = value; }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}
