using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    internal class PersistenciaProduto
    {
        public static List<Produto> itemEstoque = new List<Produto>()
        {
            new Produto(1, "Pão de Queijo", 3.50, false),

            new Produto(2, "Coxinha ", 5.00, false),

            new Produto(3, "Pastel de Carne", 6.00, true),

            new Produto(4, "Pastel de Queijo", 5.50, true),

            new Produto(5, "Suco Natural (300ml)", 4.00, false),

            new Produto(6, "Refrigerante Lata", 4.50, false),

            new Produto(7, "Hamburguer Simples", 8.00, true),

            new Produto(8, "Hambúrguer com Queijo", 9.00, true),

            new Produto(9, "X-Tudo", 12.00, true),

            new Produto(10, "Água Mineral (500ml)", 2.50, false)
        };
    }
}

