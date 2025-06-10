using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace cantinaPainel
{
    internal class PersistenciaProduto
    {
        public static List<Produto> itemEstoque = new List<Produto>()
        {
            new Produto(1, "Pão de Queijo", 3.50, false, true),
            new Produto(2, "Coxinha ", 5.00, false, true),
            new Produto(3, "Pastel de Carne", 6.00, true, true),
            new Produto(4, "Pastel de Queijo", 5.50, true, true),
            new Produto(5, "Suco Natural (300ml)", 4.00, false, true),
            new Produto(6, "Refrigerante Lata", 4.50, false, true),
            new Produto(7, "Hamburguer Simples", 8.00, true, true),
            new Produto(8, "Hambúrguer com Queijo", 9.00, true, true),
            new Produto(9, "X-Tudo", 12.00, true, true),
            new Produto(10, "Água Mineral (500ml)", 2.50, false, true)
        };

        // MUDANÇA PRINCIPAL: Arquivo separado para produtos!
        private static string caminho = @"C:\Temp\produtos.json";

        public static void saveToFile()
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(caminho));
                string json = JsonConvert.SerializeObject(itemEstoque, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(caminho, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving products file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        itemEstoque = JsonConvert.DeserializeObject<List<Produto>>(json) ?? GetDefaultProducts();
                    }
                    else
                    {
                        itemEstoque = GetDefaultProducts();
                    }
                }
                else
                {
                    // Se arquivo não existe, usa produtos padrão e salva
                    itemEstoque = GetDefaultProducts();
                    saveToFile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                itemEstoque = GetDefaultProducts();
            }
        }

        // Método para retornar produtos padrão
        private static List<Produto> GetDefaultProducts()
        {
            return new List<Produto>()
            {
                new Produto(1, "Pão de Queijo", 3.50, false, true),
                new Produto(2, "Coxinha ", 5.00, false, true),
                new Produto(3, "Pastel de Carne", 6.00, true, true),
                new Produto(4, "Pastel de Queijo", 5.50, true, true),
                new Produto(5, "Suco Natural (300ml)", 4.00, false, true),
                new Produto(6, "Refrigerante Lata", 4.50, false, true),
                new Produto(7, "Hamburguer Simples", 8.00, true, true),
                new Produto(8, "Hambúrguer com Queijo", 9.00, true, true),
                new Produto(9, "X-Tudo", 12.00, true, true),
                new Produto(10, "Água Mineral (500ml)", 2.50, false, true)
            };
        }

        public static void LimparArquivo()
        {
            try
            {
                itemEstoque = GetDefaultProducts();
                saveToFile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}