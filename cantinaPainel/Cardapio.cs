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
            this.quantidade = 0;
        }

        public string Produto
        {
            get { return produto;}
        }

        public double Preco
        {
            get { return preco; }  
            set { preco = value; }
        }

        public int Quantidade
        {
            get { return quantidade;}
            set { quantidade = value; }
        }
        public override string ToString()
        {

            if (quantidade > 0)
                return$"{quantidade}x - {produto} - R$ {preco:f2}";
            else
                return$"{produto} - R$ {preco:f2}";
        }
    }
}
