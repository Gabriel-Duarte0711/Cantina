using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;  
using System.Text.Json;
using System.Threading.Tasks;

namespace cantinaPainel
{
    internal class PersistenciaPedido
    {
        public static List<Pedido> pedidos = new List<Pedido>();
        public static int numeroPedido = 0;

        private static string caminho = @"C:\Temp\pedidos.json";

       
    }
}
