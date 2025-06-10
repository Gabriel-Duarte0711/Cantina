using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace cantinaPainel
{
    internal class PersistenciaPedido
    {
        public static List<Pedido> pedidos = new List<Pedido>();
        private static string caminho = @"C:\Temp\pedidos.json";
        public static int numeroPedido = 0;

        public static int ProximoNumeroPedido()
        {
            try
            {
                // Só carrega se a lista estiver vazia
                if (pedidos.Count == 0)
                {
                    LoadListFromFile();
                }

                // Encontrar o maior número de pedido que não seja 0
                int maiorNumero = 0;
                foreach (var pedido in pedidos)
                {
                    if (pedido.CodigoPedido > maiorNumero)
                    {
                        maiorNumero = pedido.CodigoPedido;
                    }
                }

                numeroPedido = maiorNumero + 1;
                return numeroPedido;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter próximo número: {ex.Message}");
                return 1;
            }
        }

        public static void saveToFile()
        {
            try
            {
                // IMPORTANTE: Limpar pedidos vazios antes de salvar
                pedidos.RemoveAll(p => p.CodigoPedido == 0 ||
                                     string.IsNullOrEmpty(p.Nome_Cliente) ||
                                     p.extrato == null ||
                                     p.extrato.Count == 0);

                Directory.CreateDirectory(Path.GetDirectoryName(caminho));
                string json = JsonConvert.SerializeObject(pedidos, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(caminho, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message}");
            }
        }

        public static void LoadListFromFile()
        {
            try
            {
                if (File.Exists(caminho))
                {
                    string json = File.ReadAllText(caminho);
                    if (!string.IsNullOrEmpty(json))
                    {
                        var pedidosCarregados = JsonConvert.DeserializeObject<List<Pedido>>(json);
                        pedidos = pedidosCarregados ?? new List<Pedido>();

                        // Limpar pedidos vazios após carregar também
                        pedidos.RemoveAll(p => p.CodigoPedido == 0 ||
                                             string.IsNullOrEmpty(p.Nome_Cliente) ||
                                             p.extrato == null ||
                                             p.extrato.Count == 0);
                    }
                    else
                    {
                        pedidos = new List<Pedido>();
                    }
                }
                else
                {
                    pedidos = new List<Pedido>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar: {ex.Message}");
                pedidos = new List<Pedido>();
            }
        }

        public static void LimparArquivo()
        {
            try
            {
                File.WriteAllText(caminho, "[]");
                pedidos.Clear();
                numeroPedido = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar o arquivo: {ex.Message}");
            }
        }
    }
}