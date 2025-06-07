using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    class Produto
    {
        private string item;
        private double preco;
        private int quantidade;
        private int codigo=0;
        private bool isChapa;
        private int quantidadeEstoque;

        public Produto(int codigo,string produto, double preco, bool isChapa)
        {
            this.item = produto;
            this.preco = preco;
            this.quantidade = 0;
            this.codigo= codigo;
            this.isChapa= isChapa;
        }

        public string Item
        {
            get { return item;}
            set { item = value; }
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

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value;}
        }

        public bool IsChapa
        {
            get { return isChapa; }
            set { isChapa = value; }
        }
        public int QuantidadeEstoque
        {
            get { return quantidadeEstoque; }
            set { quantidadeEstoque = value; }
        }
        public override string ToString()
        {

            if (quantidade > 0)
                return$"{quantidade}x - {item} - R$ {preco * quantidade:f2}";
            else
                return$"{item} - R$ {preco:f2}";
        }
    }
}
