using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinaPainel
{
    
    class Pedido
    {


        public static List<Produto> extrato = new();
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
            string Extrato = string.Join("\n", extrato);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cliente: {nome_cliente}\n");
            sb.AppendLine($"\nProdutos: {Extrato}");

            foreach (Produto produto in extrato) 
            {
                sb.AppendLine($"{Extrato}");
            }
            return sb.ToString();
        }

    }
}
