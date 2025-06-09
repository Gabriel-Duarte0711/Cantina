using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    internal class Estoque
    { 
      private Produto produto;
      private int quantidade;
        public Produto Produto 
        { 
            get { return produto; } 
            set { produto = value; } 
        }
        public int Quantidade
        {
            get { return quantidade; } 
            set { quantidade = value; } 
        }

        public override string ToString()
        {
            return$"{produto.Item} Qnt: {quantidade}";
        }
    }
}
