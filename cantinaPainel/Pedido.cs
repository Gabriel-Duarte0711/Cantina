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
        private string metodoPagamento;
        private bool isViagem;
        private Status statusPedido;
        private int codigoPedido = 0;


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
            set { isViagem = value; }
        }

        public string MetodoPagamento
        {
            get { return metodoPagamento; }
            set { metodoPagamento = value; }
        }

        public int CodigoPedido
        {
            get { return codigoPedido; }
            set { codigoPedido = value; }
        }



        public override string ToString()
        {
            //bool temProdutoChapa = false;
            StringBuilder sb = new StringBuilder();
            sb.Append($"Pedido: {codigoPedido} --");
            //foreach (Produto produto in extrato)
            //{
            //    if (produto.IsChapa)
            //    {
            //        temProdutoChapa = true;
            //        break;
            //    }
            //}
            if (this.statusPedido==Status.PREPARANDO)
            {
                foreach (var produto in extrato)
                 {                
                    if (produto.IsChapa)
                    {
                        sb.Append($" {produto.Quantidade}x - {produto.Item} /");
                    }
                }
            }
            
            else
            {
                foreach (var produto in extrato)
                    sb.Append($" {produto.Quantidade}x - {produto.Item} /");
            }
                return sb.ToString().TrimEnd(' ', '/');

            //else if (!temProdutoChapa)
            //{
            //    sb.Append($" {produto.Quantidade}x - {produto.Item} /");
            //}   
        }

            
        }

        //    public string ToStringSomenteChapas()
        //    {
        //        StringBuilder sb = new StringBuilder();

        //        foreach (var produto in extrato)
        //        {
        //            if (produto.IsChapa)
        //            {
        //                sb.AppendLine($"Pedido: {codigoPedido} -- {produto.Quantidade}x - {produto.Item} /");
        //            }
        //        }

        //        return sb.ToString();
        //    }

        //}
    }

