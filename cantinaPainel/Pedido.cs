using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    
    class Pedido
    {

      

        public List<Produto> extrato = new List<Produto>();
        private string nome_cliente;
        private string metodo_pgmt;
        private bool isViagem;
        private Status statusPedido;

        public Status StatusPedido
        {
            get { return statusPedido; }
            set { statusPedido = value; }
        }
  

        public string Nome_Cliente
        {
            get { return nome_cliente; }
            set { nome_cliente = value; }
        }

        public bool IsViagem
        {
            get { return isViagem; }
        }


        

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cliente: {nome_cliente} ");
            foreach (Produto produto in extrato)
            {

                sb.Append($"/ {produto.Quantidade}x - {produto.Item} ");
            }
            return sb.ToString();
        }

    }
}
