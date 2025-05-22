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
        private string status;

        public string Nome_Cliente
        {
            get { return nome_cliente; }
            set { nome_cliente = value; }
        }
        public void Add (Produto produto)
        {
            extrato.Add (produto);
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nome_cliente);
            foreach (Produto produto in extrato) 
            {
                sb.Append($"\n {produto}");
            }
            return sb.ToString();         
        }

    }
}
