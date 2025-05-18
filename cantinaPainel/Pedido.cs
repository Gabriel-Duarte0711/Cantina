using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    class Pedido
    {
        public Cardapio pedidos { get; set; }

        public Pedido(Cardapio Produto)
        {
            pedidos = Produto;
        }
        public override string ToString()
        {
                return $"{pedidos.Produto} - R$ {pedidos.Preco:f2}";
        }

    }
}
