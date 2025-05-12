using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    class Cardapio
    {
        private string produto;
        private double preco;
        private int quantidade;

        public Cardapio(string produto, double preco)
        {
            this.produto = produto;
            this.preco = preco;
        }

        public string Produto
        {
            get { return produto;}
        }

        public double Preco
        {
            get { return preco; }  
        }

        public int Quantidade
        {
            get { return quantidade;}
        }

        public override string ToString()
        {
            return$"{produto}- R$ {preco:f2}";
        }
    }
}
