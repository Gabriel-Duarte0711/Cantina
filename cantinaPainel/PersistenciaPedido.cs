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

                string teste = File.ReadAllText(caminho);

                pedidos = JsonConvert.DeserializeObject<List<Pedido>>(teste) ?? new List<Pedido>();
                int cont = 0;
                foreach (var pedido in pedidos)
                {
                    cont = pedido.CodigoPedido;

                }
                numeroPedido = cont++;
                return numeroPedido;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static void saveToFile()
        {
            try
            {

                string json = JsonConvert.SerializeObject(pedidos, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(caminho, json);



            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        pedidos = JsonConvert.DeserializeObject<List<Pedido>>(json) ?? new List<Pedido>();
                    }
                }
                else
                {
                    // File doesn't exist, will be created on first save
                    pedidos = new List<Pedido>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pedidos = new List<Pedido>(); // Initialize empty list on error
            }
        }
        public static void LimparArquivo()
        {
            try
            {
                File.WriteAllText(caminho, string.Empty);
                pedidos.Clear();
                numeroPedido = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
